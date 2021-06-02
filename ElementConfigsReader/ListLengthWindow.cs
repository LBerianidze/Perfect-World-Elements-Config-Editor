using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementConfigsReader
{
    public partial class ListLengthWindow : Form
    {
        public ListLengthWindow(List<List> Lists)
        {
            InitializeComponent();
            for (int i = 0; i < Lists.Count; i++)
            {
                int Value = 0;
                for (int z = 0; z < Lists[i].Types.Count; z++)
                {
                    string St = Lists[i].Types[z];
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
                        Value += Convert.ToInt32(St.Split(':')[1]);
                    }
                    else if (St == "byte")
                    {
                        Value++;
                    }
                    else if(St == "double" || St=="int64")
                    {
                        Value += 8;
                    }
                    else
                    {

                    }
                }
                ListItemGrid.Rows.Add(i, Lists[i].ListName, Value);
            }
        }
    }
}
