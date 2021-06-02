namespace ElementConfigsReader
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenConfigFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveConfigFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeListName = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigDialog = new System.Windows.Forms.OpenFileDialog();
            this.ListCombobox = new System.Windows.Forms.ComboBox();
            this.ListItemGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddField = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveField = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.BytesAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.NewListName = new System.Windows.Forms.TextBox();
            this.DeleteList = new System.Windows.Forms.Button();
            this.AddList = new System.Windows.Forms.Button();
            this.AllBytesAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListItemGrid)).BeginInit();
            this.ListContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BytesAmountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBytesAmountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenConfigFile,
            this.SaveConfigFile,
            this.ChangeListName,
            this.InformationButton,
            this.List});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenConfigFile
            // 
            this.OpenConfigFile.Image = global::ElementConfigsReader.Properties.Resources.Open_file;
            this.OpenConfigFile.Name = "OpenConfigFile";
            this.OpenConfigFile.Size = new System.Drawing.Size(81, 20);
            this.OpenConfigFile.Text = "Открыть";
            this.OpenConfigFile.Click += new System.EventHandler(this.OpenConfigFile_Click);
            // 
            // SaveConfigFile
            // 
            this.SaveConfigFile.Image = global::ElementConfigsReader.Properties.Resources.write_document;
            this.SaveConfigFile.Name = "SaveConfigFile";
            this.SaveConfigFile.Size = new System.Drawing.Size(92, 20);
            this.SaveConfigFile.Text = "Сохранить";
            this.SaveConfigFile.Click += new System.EventHandler(this.SaveConfigFile_Click);
            // 
            // ChangeListName
            // 
            this.ChangeListName.Image = global::ElementConfigsReader.Properties.Resources.monotone_pen_write;
            this.ChangeListName.Name = "ChangeListName";
            this.ChangeListName.Size = new System.Drawing.Size(172, 20);
            this.ChangeListName.Text = "Изменить название листа";
            this.ChangeListName.Click += new System.EventHandler(this.ChangeListName_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.Image = global::ElementConfigsReader.Properties.Resources.info;
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(107, 20);
            this.InformationButton.Text = "Информация";
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // ConfigDialog
            // 
            this.ConfigDialog.FileName = "Element Config File";
            this.ConfigDialog.Filter = "Config File|*.cfg|All Files|*.*";
            // 
            // ListCombobox
            // 
            this.ListCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCombobox.FormattingEnabled = true;
            this.ListCombobox.Location = new System.Drawing.Point(0, 27);
            this.ListCombobox.Name = "ListCombobox";
            this.ListCombobox.Size = new System.Drawing.Size(472, 21);
            this.ListCombobox.TabIndex = 1;
            this.ListCombobox.SelectedIndexChanged += new System.EventHandler(this.ListCombobox_SelectedIndexChanged);
            // 
            // ListItemGrid
            // 
            this.ListItemGrid.AllowUserToAddRows = false;
            this.ListItemGrid.AllowUserToDeleteRows = false;
            this.ListItemGrid.AllowUserToResizeColumns = false;
            this.ListItemGrid.AllowUserToResizeRows = false;
            this.ListItemGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListItemGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ListItemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListItemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.ListItemGrid.ContextMenuStrip = this.ListContext;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListItemGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListItemGrid.EnableHeadersVisualStyles = false;
            this.ListItemGrid.Location = new System.Drawing.Point(0, 50);
            this.ListItemGrid.Name = "ListItemGrid";
            this.ListItemGrid.RowHeadersVisible = false;
            this.ListItemGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListItemGrid.Size = new System.Drawing.Size(521, 423);
            this.ListItemGrid.TabIndex = 2;
            this.ListItemGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListItemGrid_CellValueChanged);
            this.ListItemGrid.CurrentCellChanged += new System.EventHandler(this.ListItemGrid_CurrentCellChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 13.32046F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 33;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 112.2882F;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 184;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 174.3913F;
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ListContext
            // 
            this.ListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddField,
            this.RemoveField});
            this.ListContext.Name = "ListContext";
            this.ListContext.Size = new System.Drawing.Size(157, 48);
            // 
            // AddField
            // 
            this.AddField.Image = global::ElementConfigsReader.Properties.Resources.Add_item_icon;
            this.AddField.Name = "AddField";
            this.AddField.Size = new System.Drawing.Size(156, 22);
            this.AddField.Text = "Добавить поле";
            this.AddField.Click += new System.EventHandler(this.AddField_Click);
            // 
            // RemoveField
            // 
            this.RemoveField.Image = global::ElementConfigsReader.Properties.Resources.remove;
            this.RemoveField.Name = "RemoveField";
            this.RemoveField.Size = new System.Drawing.Size(156, 22);
            this.RemoveField.Text = "Удалить поле";
            this.RemoveField.Click += new System.EventHandler(this.RemoveField_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-3, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Занимаемое количество байт выделенными элементами:";
            // 
            // BytesAmountNumeric
            // 
            this.BytesAmountNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BytesAmountNumeric.Location = new System.Drawing.Point(345, 476);
            this.BytesAmountNumeric.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.BytesAmountNumeric.Name = "BytesAmountNumeric";
            this.BytesAmountNumeric.Size = new System.Drawing.Size(176, 20);
            this.BytesAmountNumeric.TabIndex = 4;
            // 
            // NewListName
            // 
            this.NewListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewListName.Location = new System.Drawing.Point(0, 28);
            this.NewListName.Multiline = true;
            this.NewListName.Name = "NewListName";
            this.NewListName.Size = new System.Drawing.Size(472, 20);
            this.NewListName.TabIndex = 8;
            this.NewListName.Visible = false;
            this.NewListName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewListName_KeyDown);
            this.NewListName.Leave += new System.EventHandler(this.NewListName_Leave);
            // 
            // DeleteList
            // 
            this.DeleteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteList.Image = global::ElementConfigsReader.Properties.Resources.remove;
            this.DeleteList.Location = new System.Drawing.Point(497, 26);
            this.DeleteList.Name = "DeleteList";
            this.DeleteList.Size = new System.Drawing.Size(23, 23);
            this.DeleteList.TabIndex = 7;
            this.DeleteList.UseVisualStyleBackColor = true;
            this.DeleteList.Click += new System.EventHandler(this.DeleteList_Click);
            // 
            // AddList
            // 
            this.AddList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddList.Image = global::ElementConfigsReader.Properties.Resources.Add_item_icon;
            this.AddList.Location = new System.Drawing.Point(473, 26);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(23, 23);
            this.AddList.TabIndex = 6;
            this.AddList.UseVisualStyleBackColor = true;
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // AllBytesAmountNumeric
            // 
            this.AllBytesAmountNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AllBytesAmountNumeric.Location = new System.Drawing.Point(345, 497);
            this.AllBytesAmountNumeric.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.AllBytesAmountNumeric.Name = "AllBytesAmountNumeric";
            this.AllBytesAmountNumeric.Size = new System.Drawing.Size(176, 20);
            this.AllBytesAmountNumeric.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Занимаемое количество байт всеми элементами:";
            // 
            // List
            // 
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(58, 20);
            this.List.Text = "Список";
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 518);
            this.Controls.Add(this.AllBytesAmountNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteList);
            this.Controls.Add(this.AddList);
            this.Controls.Add(this.BytesAmountNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListItemGrid);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.NewListName);
            this.Controls.Add(this.ListCombobox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(537, 540);
            this.Name = "Form1";
            this.Text = "Elements Configs Editor By Luka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListItemGrid)).EndInit();
            this.ListContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BytesAmountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBytesAmountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenConfigFile;
        private System.Windows.Forms.OpenFileDialog ConfigDialog;
        private System.Windows.Forms.ComboBox ListCombobox;
        private System.Windows.Forms.DataGridView ListItemGrid;
        private System.Windows.Forms.ToolStripMenuItem SaveConfigFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BytesAmountNumeric;
        private System.Windows.Forms.ContextMenuStrip ListContext;
        private System.Windows.Forms.ToolStripMenuItem AddField;
        private System.Windows.Forms.ToolStripMenuItem RemoveField;
        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.Button DeleteList;
        private System.Windows.Forms.ToolStripMenuItem ChangeListName;
        private System.Windows.Forms.TextBox NewListName;
        private System.Windows.Forms.ToolStripMenuItem InformationButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.NumericUpDown AllBytesAmountNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem List;
    }
}

