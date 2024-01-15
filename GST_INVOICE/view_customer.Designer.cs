namespace GST_INVOICE
{
    partial class view_customer
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
            this.components = new System.ComponentModel.Container();
            this.lbl_by_name = new System.Windows.Forms.Label();
            this.radio_name = new System.Windows.Forms.RadioButton();
            this.radio_gstin = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_view_all = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
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
            this.tblcompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gst_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_by_name
            // 
            this.lbl_by_name.AutoSize = true;
            this.lbl_by_name.Location = new System.Drawing.Point(28, 94);
            this.lbl_by_name.Name = "lbl_by_name";
            this.lbl_by_name.Size = new System.Drawing.Size(73, 17);
            this.lbl_by_name.TabIndex = 0;
            this.lbl_by_name.Text = "Search By";
            // 
            // radio_name
            // 
            this.radio_name.AutoSize = true;
            this.radio_name.Checked = true;
            this.radio_name.Location = new System.Drawing.Point(116, 94);
            this.radio_name.Name = "radio_name";
            this.radio_name.Size = new System.Drawing.Size(66, 21);
            this.radio_name.TabIndex = 1;
            this.radio_name.TabStop = true;
            this.radio_name.Text = "Name";
            this.radio_name.UseVisualStyleBackColor = true;
            this.radio_name.CheckedChanged += new System.EventHandler(this.radio_name_CheckedChanged);
            // 
            // radio_gstin
            // 
            this.radio_gstin.AutoSize = true;
            this.radio_gstin.Location = new System.Drawing.Point(197, 94);
            this.radio_gstin.Name = "radio_gstin";
            this.radio_gstin.Size = new System.Drawing.Size(71, 21);
            this.radio_gstin.TabIndex = 2;
            this.radio_gstin.Text = "GSTIN";
            this.radio_gstin.UseVisualStyleBackColor = true;
            this.radio_gstin.CheckedChanged += new System.EventHandler(this.radio_gstin_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(67, 167);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(151, 31);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_view_all
            // 
            this.btn_view_all.Location = new System.Drawing.Point(294, 100);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(75, 62);
            this.btn_view_all.TabIndex = 4;
            this.btn_view_all.Text = "VIEW ALL";
            this.btn_view_all.UseVisualStyleBackColor = true;
            this.btn_view_all.Click += new System.EventHandler(this.btn_view_all_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 300);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(40, 125);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(227, 22);
            this.txt_search.TabIndex = 7;
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
            this.gst_menu.Size = new System.Drawing.Size(957, 28);
            this.gst_menu.TabIndex = 112;
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
            // view_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(957, 762);
            this.Controls.Add(this.gst_menu);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_view_all);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.radio_gstin);
            this.Controls.Add(this.radio_name);
            this.Controls.Add(this.lbl_by_name);
            this.Name = "view_customer";
            this.Text = "SEARCH CLIENTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.view_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gst_menu.ResumeLayout(false);
            this.gst_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcompanyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_by_name;
        private System.Windows.Forms.RadioButton radio_name;
        private System.Windows.Forms.RadioButton radio_gstin;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_view_all;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.BindingSource dbgstDataSetBindingSource;
       // private db_gstDataSet db_gstDataSet;
        private System.Windows.Forms.BindingSource tblcompanyBindingSource;
       // private db_gstDataSetTableAdapters.tbl_companyTableAdapter tbl_companyTableAdapter;
        private System.Windows.Forms.TextBox txt_search;
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