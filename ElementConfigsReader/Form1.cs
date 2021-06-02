using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ElementConfigsReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<List> ElementsLists;
        public int ListsAmount;
        public int DialogsListPosition;
        int SelectedList;
        private void OpenConfigFile_Click(object sender, EventArgs e)
        {
            if (ConfigDialog.ShowDialog() == DialogResult.OK)
            {
                ElementsLists = new List<List>();
                ReadConfig(ConfigDialog.FileName);
            }
        }
        public void ReadConfig(string FilePath)
        {
            try
            {
                ListCombobox.Items.Clear();
                StreamReader sr = new StreamReader(FilePath, Encoding.UTF8);
                ListsAmount = Convert.ToInt32(sr.ReadLine());
                DialogsListPosition = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < ListsAmount; i++)
                {
                    string Line = "";
                    while (Line == "") Line = sr.ReadLine();
                    List list = new List();
                    list.ListName = Line;
                    list.ListType = sr.ReadLine();
                    list.TypesNames = sr.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    list.Types = sr.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    ElementsLists.Add(list);
                    ListCombobox.Items.Add(list.ListName);
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Упсс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItemGrid.Rows.Clear();
            SelectedList = ListCombobox.SelectedIndex;
            for (int i = 0; i < ElementsLists[SelectedList].Types.Count; i++)
            {
                ListItemGrid.Rows.Add(i, ElementsLists[SelectedList].TypesNames[i], ElementsLists[SelectedList].Types[i]);
            }
            int Value = 0;
            for (int i = 0; i < ListItemGrid.Rows.Count; i++)
            {
                string St = ListItemGrid.Rows[i].Cells[2].Value.ToString();
                if (St.Contains("int32") || St.Contains("float"))
                {
                    Value += 4;
                }
                else if (St.Contains("string"))
                {
                    Value += Convert.ToInt32(St.Split(':')[1]);
                }
                else if (St.Contains("wstring"))
                {
                    Value += Value += Convert.ToInt32(St.Split(':')[1]);
                }
            }
            AllBytesAmountNumeric.Value = Value;
        }

        private void SaveConfigFile_Click(object sender, EventArgs e)
        {
            if (ElementsLists != null)
            {
                StreamWriter sw = new StreamWriter(ConfigDialog.FileName);
                sw.WriteLine(ListsAmount.ToString());
                sw.WriteLine(DialogsListPosition.ToString());
                sw.WriteLine();
                for (int i = 0; i < ListsAmount; i++)
                {
                    sw.WriteLine(ElementsLists[i].ListName);
                    sw.WriteLine(ElementsLists[i].ListType);
                    sw.WriteLine(string.Join(";", ElementsLists[i].TypesNames));
                    sw.WriteLine(string.Join(";", ElementsLists[i].Types));
                    sw.WriteLine();
                }
                sw.Close();
            }
        }

        private void ListItemGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ElementsLists != null)
            {
                if (e.ColumnIndex == 1)
                {
                    ElementsLists[SelectedList].TypesNames[e.RowIndex] = ListItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                else if (e.ColumnIndex == 2)
                {
                    ElementsLists[SelectedList].Types[e.RowIndex] = ListItemGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }
        }

        private void ListItemGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ListItemGrid.CurrentRow != null)
            {
                if (ListItemGrid.CurrentRow.Index != -1)
                {
                    int Value = 0;
                    for (int i = 0; i < ListItemGrid.SelectedCells.Count; i++)
                    {
                        string St = ListItemGrid.SelectedCells[i].Value.ToString();
                        if (St.Contains("int32") || St.Contains("float"))
                        {
                            Value += 4;
                        }
                        else if (St.Contains("string:128"))
                        {
                            Value += 128;
                        }
                        else if (St.Contains("string:512"))
                        {
                            Value += 512;
                        }
                        else if (St.Contains("wstring:64"))
                        {
                            Value += 64;
                        }
                    }
                    BytesAmountNumeric.Value = Value;
                }
            }
        }

        private void AddField_Click(object sender, EventArgs e)
        {
            if (ElementsLists != null && ListCombobox.SelectedIndex != -1)
            {
                ElementsLists[SelectedList].TypesNames.Add("NewField");
                ElementsLists[SelectedList].Types.Add("int32");
                ListItemGrid.Rows.Add(ListItemGrid.Rows.Count + 1, "NewField", "int32");
                ListItemGrid.CurrentCell = ListItemGrid.Rows[ListItemGrid.Rows.Count - 1].Cells[1];
            }
        }

        private void RemoveField_Click(object sender, EventArgs e)
        {
            if (ElementsLists != null && ListCombobox.SelectedIndex != -1)
            {
                if (ListItemGrid.CurrentRow != null)
                {
                    int i = ListItemGrid.CurrentRow.Index;
                    ElementsLists[SelectedList].Types.RemoveAt(i);
                    ElementsLists[SelectedList].TypesNames.RemoveAt(i);
                    ListItemGrid.Rows.RemoveAt(i);
                    for (int iz = 0; iz < ListItemGrid.Rows.Count; iz++)
                    {
                        ListItemGrid.Rows[iz].Cells[0].Value = iz + 1;
                    }
                }
            }
        }

        private void AddList_Click(object sender, EventArgs e)
        {
            if (ElementsLists != null)
            {
                ElementsLists.Add(new List());
                ListsAmount++;
                ElementsLists.Last().Types = new List<string>();
                ElementsLists.Last().TypesNames = new List<string>();
                ElementsLists.Last().ListName = ListsAmount + " - New Added List";
                ElementsLists.Last().ListType = "0";
                ListCombobox.Items.Add(ListsAmount + " - New Added List");
                ListCombobox.SelectedIndex = ListCombobox.Items.Count - 1;
            }
        }

        private void DeleteList_Click(object sender, EventArgs e)
        {
            if (ElementsLists != null && ListCombobox.SelectedIndex != -1)
            {
                int i = ListCombobox.SelectedIndex;
                ElementsLists.RemoveAt(i);
                ListsAmount--;
                ListCombobox.Items.RemoveAt(i);
                if (ListCombobox.Items.Count != 0)
                {
                    ListCombobox.SelectedIndex = i - 1;
                }
            }
        }

        private void ChangeListName_Click(object sender, EventArgs e)
        {
            if (ElementsLists != null && ListCombobox.SelectedIndex != -1)
            {
                NewListName.Text = ListCombobox.Items[ListCombobox.SelectedIndex].ToString();
                NewListName.Visible = true;
                NewListName.Focus();
            }
        }
        private void NewListName_Leave(object sender, EventArgs e)
        {
            ChangeListNameM();
        }
        private void NewListName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangeListNameM();
            }
        }
        public void ChangeListNameM()
        {
            int i = ListCombobox.SelectedIndex;
            ElementsLists[i].ListName = NewListName.Text;
            ListCombobox.Items[i] = NewListName.Text;
            NewListName.Visible = false;
        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Маленький гайд по программе:\r" +
                "1)Для изменения названия поля кликните по нему дважды.\r" +
                "2)Чтобы добавить\\удалить поле,кликните правой кнопкой мыши по списку.\r" +
                "3)Чтобы добавить\\удалить лист,нажмите кнопку справа от элемента выбора листа.\r" +
                "4)Для изменения названия листа,нажмите кнопку выше элемента выбора листа и введите желаемое название в появившемся поле ввода.После этого нажмите кнопку Enter,либо кликните мышкой в любом месте программы.\r" +
                "5)Для добавления своего типа,добавьте его в Types.cfg,который лежит в папке с программой.\r" +
                "                                      Skype:Luka007789\r" +
                "                                           06.05.2017\r" +
                "                                            (c) Luka", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(Application.StartupPath + "\\Types.cfg");
            DataGridViewComboBoxColumn theColumn = (DataGridViewComboBoxColumn)this.ListItemGrid.Columns[2];
            theColumn.Items.Clear();
            theColumn.Items.AddRange(lines);
        }

        private void List_Click(object sender, EventArgs e)
        {
            ListLengthWindow l = new ListLengthWindow(ElementsLists);
            l.ShowDialog(this);
        }
    }
    public class List
    {
        public string ListName { get; set; }
        public string ListType { get; set; }
        public List<string> TypesNames { get; set; }
        public List<string> Types { get; set; }
    }
}
