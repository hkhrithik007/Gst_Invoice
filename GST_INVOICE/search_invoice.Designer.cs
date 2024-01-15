namespace GST_INVOICE
{
    partial class search_invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_search = new System.Windows.Forms.TextBox();
            this.radio_byinvoice = new System.Windows.Forms.RadioButton();
            this.radio_byname = new System.Windows.Forms.RadioButton();
            this.cal_to_date = new System.Windows.Forms.MonthCalendar();
            this.txt_to_date = new System.Windows.Forms.TextBox();
            this.lbl_to_date = new System.Windows.Forms.Label();
            this.lbl_from_date = new System.Windows.Forms.Label();
            this.txt_from_date = new System.Windows.Forms.TextBox();
            this.cal_from_date = new System.Windows.Forms.MonthCalendar();
            this.btn_search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk_date = new System.Windows.Forms.CheckBox();
            this.gst_menu = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVOICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSIGNEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gst_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(647, 159);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(246, 22);
            this.txt_search.TabIndex = 17;
            // 
            // radio_byinvoice
            // 
            this.radio_byinvoice.AutoSize = true;
            this.radio_byinvoice.Location = new System.Drawing.Point(739, 108);
            this.radio_byinvoice.Name = "radio_byinvoice";
            this.radio_byinvoice.Size = new System.Drawing.Size(115, 21);
            this.radio_byinvoice.TabIndex = 16;
            this.radio_byinvoice.Text = "By Invoice No";
            this.radio_byinvoice.UseVisualStyleBackColor = true;
            this.radio_byinvoice.CheckedChanged += new System.EventHandler(this.radio_byinvoice_CheckedChanged);
            // 
            // radio_byname
            // 
            this.radio_byname.AutoSize = true;
            this.radio_byname.Checked = true;
            this.radio_byname.Location = new System.Drawing.Point(647, 107);
            this.radio_byname.Name = "radio_byname";
            this.radio_byname.Size = new System.Drawing.Size(86, 21);
            this.radio_byname.TabIndex = 15;
            this.radio_byname.TabStop = true;
            this.radio_byname.Text = "By Name";
            this.radio_byname.UseVisualStyleBackColor = true;
            this.radio_byname.CheckedChanged += new System.EventHandler(this.radio_byname_CheckedChanged);
            // 
            // cal_to_date
            // 
            this.cal_to_date.Location = new System.Drawing.Point(350, 140);
            this.cal_to_date.Name = "cal_to_date";
            this.cal_to_date.TabIndex = 14;
            this.cal_to_date.Visible = false;
            this.cal_to_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_to_date_DateChanged);
            this.cal_to_date.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_to_date_DateSelected);
            this.cal_to_date.Leave += new System.EventHandler(this.cal_to_date_Leave);
            // 
            // txt_to_date
            // 
            this.txt_to_date.Location = new System.Drawing.Point(412, 106);
            this.txt_to_date.Name = "txt_to_date";
            this.txt_to_date.ReadOnly = true;
            this.txt_to_date.Size = new System.Drawing.Size(187, 22);
            this.txt_to_date.TabIndex = 13;
            this.txt_to_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_to_date_MouseClick);
            this.txt_to_date.Enter += new System.EventHandler(this.txt_to_date_Enter);
            this.txt_to_date.Leave += new System.EventHandler(this.txt_to_date_Leave);
            // 
            // lbl_to_date
            // 
            this.lbl_to_date.AutoSize = true;
            this.lbl_to_date.Location = new System.Drawing.Point(347, 106);
            this.lbl_to_date.Name = "lbl_to_date";
            this.lbl_to_date.Size = new System.Drawing.Size(59, 17);
            this.lbl_to_date.TabIndex = 12;
            this.lbl_to_date.Text = "To Date";
            // 
            // lbl_from_date
            // 
            this.lbl_from_date.AutoSize = true;
            this.lbl_from_date.Location = new System.Drawing.Point(42, 106);
            this.lbl_from_date.Name = "lbl_from_date";
            this.lbl_from_date.Size = new System.Drawing.Size(74, 17);
            this.lbl_from_date.TabIndex = 10;
            this.lbl_from_date.Text = "From Date";
            // 
            // txt_from_date
            // 
            this.txt_from_date.Location = new System.Drawing.Point(136, 106);
            this.txt_from_date.Name = "txt_from_date";
            this.txt_from_date.ReadOnly = true;
            this.txt_from_date.Size = new System.Drawing.Size(187, 22);
            this.txt_from_date.TabIndex = 11;
            this.txt_from_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_from_date_MouseClick);
            this.txt_from_date.Enter += new System.EventHandler(this.txt_from_date_Enter);
            this.txt_from_date.Leave += new System.EventHandler(this.txt_from_date_Leave);
            // 
            // cal_from_date
            // 
            this.cal_from_date.Location = new System.Drawing.Point(54, 140);
            this.cal_from_date.Name = "cal_from_date";
            this.cal_from_date.TabIndex = 9;
            this.cal_from_date.Visible = false;
            this.cal_from_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_from_date_DateChanged);
            this.cal_from_date.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_from_date_DateSelected);
            this.cal_from_date.Leave += new System.EventHandler(this.cal_from_date_Leave);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(647, 207);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 32);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "View ALL Between Dates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(45, 369);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 473);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // chk_date
            // 
            this.chk_date.AutoSize = true;
            this.chk_date.Checked = true;
            this.chk_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_date.Location = new System.Drawing.Point(860, 109);
            this.chk_date.Name = "chk_date";
            this.chk_date.Size = new System.Drawing.Size(114, 21);
            this.chk_date.TabIndex = 21;
            this.chk_date.Text = "Include dates";
            this.chk_date.UseVisualStyleBackColor = true;
            this.chk_date.CheckStateChanged += new System.EventHandler(this.chk_date_CheckStateChanged);
            // 
            // gst_menu
            // 
            this.gst_menu.BackColor = System.Drawing.Color.Lavender;
            this.gst_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gst_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.cUSTOMERREGISTRATIONToolStripMenuItem,
            this.uSERREGISTRATIONToolStripMenuItem,
            this.iNVOICEToolStripMenuItem,
            this.cONSIGNEToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.gst_menu.Location = new System.Drawing.Point(0, 0);
            this.gst_menu.Name = "gst_menu";
            this.gst_menu.Size = new System.Drawing.Size(1082, 28);
            this.gst_menu.TabIndex = 111;
            this.gst_menu.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // cUSTOMERREGISTRATIONToolStripMenuItem
            // 
            this.cUSTOMERREGISTRATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem1,
            this.eDITToolStripMenuItem1});
            this.cUSTOMERREGISTRATIONToolStripMenuItem.Name = "cUSTOMERREGISTRATIONToolStripMenuItem";
            this.cUSTOMERREGISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.cUSTOMERREGISTRATIONToolStripMenuItem.Text = "COMPANY";
            // 
            // nEWToolStripMenuItem1
            // 
            this.nEWToolStripMenuItem1.Name = "nEWToolStripMenuItem1";
            this.nEWToolStripMenuItem1.Size = new System.Drawing.Size(174, 24);
            this.nEWToolStripMenuItem1.Text = "NEW";
            this.nEWToolStripMenuItem1.Visible = false;
            this.nEWToolStripMenuItem1.Click += new System.EventHandler(this.nEWToolStripMenuItem1_Click);
            // 
            // eDITToolStripMenuItem1
            // 
            this.eDITToolStripMenuItem1.Name = "eDITToolStripMenuItem1";
            this.eDITToolStripMenuItem1.Size = new System.Drawing.Size(174, 24);
            this.eDITToolStripMenuItem1.Text = "VIEW/UPDATE";
            this.eDITToolStripMenuItem1.Click += new System.EventHandler(this.eDITToolStripMenuItem1_Click);
            // 
            // uSERREGISTRATIONToolStripMenuItem
            // 
            this.uSERREGISTRATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.eDITToolStripMenuItem});
            this.uSERREGISTRATIONToolStripMenuItem.Name = "uSERREGISTRATIONToolStripMenuItem";
            this.uSERREGISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.uSERREGISTRATIONToolStripMenuItem.Text = "CUSTOMER";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.nEWToolStripMenuItem.Text = "NEW";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.eDITToolStripMenuItem.Text = "SEARCH";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // iNVOICEToolStripMenuItem
            // 
            this.iNVOICEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem3,
            this.eDITToolStripMenuItem3,
            this.exportToExcelToolStripMenuItem,
            this.importToolStripMenuItem});
            this.iNVOICEToolStripMenuItem.Name = "iNVOICEToolStripMenuItem";
            this.iNVOICEToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.iNVOICEToolStripMenuItem.Text = "INVOICE";
            // 
            // nEWToolStripMenuItem3
            // 
            this.nEWToolStripMenuItem3.Name = "nEWToolStripMenuItem3";
            this.nEWToolStripMenuItem3.Size = new System.Drawing.Size(177, 24);
            this.nEWToolStripMenuItem3.Text = "NEW";
            this.nEWToolStripMenuItem3.Click += new System.EventHandler(this.nEWToolStripMenuItem3_Click);
            // 
            // eDITToolStripMenuItem3
            // 
            this.eDITToolStripMenuItem3.Name = "eDITToolStripMenuItem3";
            this.eDITToolStripMenuItem3.Size = new System.Drawing.Size(177, 24);
            this.eDITToolStripMenuItem3.Text = "SEARCH";
            this.eDITToolStripMenuItem3.Click += new System.EventHandler(this.eDITToolStripMenuItem3_Click);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // cONSIGNEToolStripMenuItem
            // 
            this.cONSIGNEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem2,
            this.eDITToolStripMenuItem2});
            this.cONSIGNEToolStripMenuItem.Name = "cONSIGNEToolStripMenuItem";
            this.cONSIGNEToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.cONSIGNEToolStripMenuItem.Text = "CONSIGNE";
            this.cONSIGNEToolStripMenuItem.Visible = false;
            // 
            // nEWToolStripMenuItem2
            // 
            this.nEWToolStripMenuItem2.Name = "nEWToolStripMenuItem2";
            this.nEWToolStripMenuItem2.Size = new System.Drawing.Size(111, 24);
            this.nEWToolStripMenuItem2.Text = "NEW";
            // 
            // eDITToolStripMenuItem2
            // 
            this.eDITToolStripMenuItem2.Name = "eDITToolStripMenuItem2";
            this.eDITToolStripMenuItem2.Size = new System.Drawing.Size(111, 24);
            this.eDITToolStripMenuItem2.Text = "EDIT";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // search_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1082, 994);
            this.Controls.Add(this.gst_menu);
            this.Controls.Add(this.chk_date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.radio_byinvoice);
            this.Controls.Add(this.radio_byname);
            this.Controls.Add(this.cal_to_date);
            this.Controls.Add(this.txt_to_date);
            this.Controls.Add(this.lbl_to_date);
            this.Controls.Add(this.lbl_from_date);
            this.Controls.Add(this.txt_from_date);
            this.Controls.Add(this.cal_from_date);
            this.Name = "search_invoice";
            this.Text = "INVOICE SEARCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.search_invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gst_menu.ResumeLayout(false);
            this.gst_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.RadioButton radio_byinvoice;
        private System.Windows.Forms.RadioButton radio_byname;
        private System.Windows.Forms.MonthCalendar cal_to_date;
        private System.Windows.Forms.TextBox txt_to_date;
        private System.Windows.Forms.Label lbl_to_date;
        private System.Windows.Forms.Label lbl_from_date;
        private System.Windows.Forms.TextBox txt_from_date;
        private System.Windows.Forms.MonthCalendar cal_from_date;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chk_date;
        private System.Windows.Forms.MenuStrip gst_menu;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERREGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERREGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iNVOICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cONSIGNEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}