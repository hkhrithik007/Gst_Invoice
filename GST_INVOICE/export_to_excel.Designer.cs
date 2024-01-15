namespace GST_INVOICE
{
    partial class export_to_excel
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
            this.cal_from_date = new System.Windows.Forms.MonthCalendar();
            this.txt_from_date = new System.Windows.Forms.TextBox();
            this.lbl_from_date = new System.Windows.Forms.Label();
            this.lbl_to_date = new System.Windows.Forms.Label();
            this.txt_to_date = new System.Windows.Forms.TextBox();
            this.cal_to_date = new System.Windows.Forms.MonthCalendar();
            this.radio_byname = new System.Windows.Forms.RadioButton();
            this.radio_bygstin = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
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
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.chk_inc_del = new System.Windows.Forms.CheckBox();
            this.btn_inv_backup = new System.Windows.Forms.Button();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gst_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cal_from_date
            // 
            this.cal_from_date.Location = new System.Drawing.Point(29, 33);
            this.cal_from_date.Name = "cal_from_date";
            this.cal_from_date.TabIndex = 0;
            this.cal_from_date.Visible = false;
            this.cal_from_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_from_date_DateChanged);
            this.cal_from_date.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_from_date_DateSelected);
            this.cal_from_date.Leave += new System.EventHandler(this.cal_from_date_Leave);
            // 
            // txt_from_date
            // 
            this.txt_from_date.Location = new System.Drawing.Point(111, 262);
            this.txt_from_date.Name = "txt_from_date";
            this.txt_from_date.ReadOnly = true;
            this.txt_from_date.Size = new System.Drawing.Size(187, 22);
            this.txt_from_date.TabIndex = 1;
            this.txt_from_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_from_date_MouseClick);
            this.txt_from_date.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txt_from_date.Leave += new System.EventHandler(this.txt_from_date_Leave);
            // 
            // lbl_from_date
            // 
            this.lbl_from_date.AutoSize = true;
            this.lbl_from_date.Location = new System.Drawing.Point(26, 267);
            this.lbl_from_date.Name = "lbl_from_date";
            this.lbl_from_date.Size = new System.Drawing.Size(74, 17);
            this.lbl_from_date.TabIndex = 1;
            this.lbl_from_date.Text = "From Date";
            // 
            // lbl_to_date
            // 
            this.lbl_to_date.AutoSize = true;
            this.lbl_to_date.Location = new System.Drawing.Point(363, 262);
            this.lbl_to_date.Name = "lbl_to_date";
            this.lbl_to_date.Size = new System.Drawing.Size(59, 17);
            this.lbl_to_date.TabIndex = 3;
            this.lbl_to_date.Text = "To Date";
            // 
            // txt_to_date
            // 
            this.txt_to_date.Location = new System.Drawing.Point(444, 259);
            this.txt_to_date.Name = "txt_to_date";
            this.txt_to_date.ReadOnly = true;
            this.txt_to_date.Size = new System.Drawing.Size(187, 22);
            this.txt_to_date.TabIndex = 4;
            this.txt_to_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_to_date_MouseClick);
            this.txt_to_date.Enter += new System.EventHandler(this.txt_to_date_Enter);
            this.txt_to_date.Leave += new System.EventHandler(this.txt_to_date_Leave);
            // 
            // cal_to_date
            // 
            this.cal_to_date.Location = new System.Drawing.Point(444, 33);
            this.cal_to_date.Name = "cal_to_date";
            this.cal_to_date.TabIndex = 5;
            this.cal_to_date.Visible = false;
            this.cal_to_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_to_date_DateChanged);
            this.cal_to_date.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_to_date_DateSelected);
            this.cal_to_date.Leave += new System.EventHandler(this.cal_to_date_Leave);
            // 
            // radio_byname
            // 
            this.radio_byname.AutoSize = true;
            this.radio_byname.Location = new System.Drawing.Point(65, 376);
            this.radio_byname.Name = "radio_byname";
            this.radio_byname.Size = new System.Drawing.Size(86, 21);
            this.radio_byname.TabIndex = 6;
            this.radio_byname.Text = "By Name";
            this.radio_byname.UseVisualStyleBackColor = true;
            // 
            // radio_bygstin
            // 
            this.radio_bygstin.AutoSize = true;
            this.radio_bygstin.Location = new System.Drawing.Point(191, 376);
            this.radio_bygstin.Name = "radio_bygstin";
            this.radio_bygstin.Size = new System.Drawing.Size(91, 21);
            this.radio_bygstin.TabIndex = 7;
            this.radio_bygstin.Text = "By GSTIN";
            this.radio_bygstin.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(65, 431);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(311, 22);
            this.txt_search.TabIndex = 8;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(444, 417);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(222, 36);
            this.btn_export.TabIndex = 9;
            this.btn_export.Text = "Export To Excel";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
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
            this.gst_menu.Size = new System.Drawing.Size(826, 28);
            this.gst_menu.TabIndex = 109;
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
            // radio_all
            // 
            this.radio_all.AutoSize = true;
            this.radio_all.Checked = true;
            this.radio_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_all.Location = new System.Drawing.Point(312, 376);
            this.radio_all.Name = "radio_all";
            this.radio_all.Size = new System.Drawing.Size(133, 21);
            this.radio_all.TabIndex = 110;
            this.radio_all.TabStop = true;
            this.radio_all.Text = "ALL INVOICES";
            this.radio_all.UseVisualStyleBackColor = true;
            // 
            // chk_inc_del
            // 
            this.chk_inc_del.AutoSize = true;
            this.chk_inc_del.Checked = true;
            this.chk_inc_del.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_inc_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_inc_del.Location = new System.Drawing.Point(29, 318);
            this.chk_inc_del.Name = "chk_inc_del";
            this.chk_inc_del.Size = new System.Drawing.Size(143, 21);
            this.chk_inc_del.TabIndex = 111;
            this.chk_inc_del.Text = "Include Deleted";
            this.chk_inc_del.UseVisualStyleBackColor = true;
            // 
            // btn_inv_backup
            // 
            this.btn_inv_backup.Location = new System.Drawing.Point(444, 480);
            this.btn_inv_backup.Name = "btn_inv_backup";
            this.btn_inv_backup.Size = new System.Drawing.Size(222, 39);
            this.btn_inv_backup.TabIndex = 112;
            this.btn_inv_backup.Text = "BACK-UP ALL INVOICES";
            this.btn_inv_backup.UseVisualStyleBackColor = true;
            this.btn_inv_backup.Click += new System.EventHandler(this.btn_inv_backup_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // export_to_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(826, 726);
            this.Controls.Add(this.btn_inv_backup);
            this.Controls.Add(this.chk_inc_del);
            this.Controls.Add(this.radio_all);
            this.Controls.Add(this.gst_menu);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.radio_bygstin);
            this.Controls.Add(this.radio_byname);
            this.Controls.Add(this.cal_to_date);
            this.Controls.Add(this.txt_to_date);
            this.Controls.Add(this.lbl_to_date);
            this.Controls.Add(this.lbl_from_date);
            this.Controls.Add(this.txt_from_date);
            this.Controls.Add(this.cal_from_date);
            this.Name = "export_to_excel";
            this.Text = "EXPORT TO EXCEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gst_menu.ResumeLayout(false);
            this.gst_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cal_from_date;
        private System.Windows.Forms.TextBox txt_from_date;
        private System.Windows.Forms.Label lbl_from_date;
        private System.Windows.Forms.Label lbl_to_date;
        private System.Windows.Forms.TextBox txt_to_date;
        private System.Windows.Forms.MonthCalendar cal_to_date;
        private System.Windows.Forms.RadioButton radio_byname;
        private System.Windows.Forms.RadioButton radio_bygstin;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_export;
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
        private System.Windows.Forms.RadioButton radio_all;
        private System.Windows.Forms.CheckBox chk_inc_del;
        private System.Windows.Forms.Button btn_inv_backup;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}