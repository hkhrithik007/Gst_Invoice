namespace GST_INVOICE
{
    partial class consignee
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
            this.cl_detail = new System.Windows.Forms.Label();
            this.cl_name = new System.Windows.Forms.Label();
            this.c_address = new System.Windows.Forms.Label();
            this.c_contact = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.name_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.product_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gst_menu = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSIGNEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVOICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_state = new System.Windows.Forms.Label();
            this.combo_state = new System.Windows.Forms.ComboBox();
            this.lbl_stcode = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            //this.db_gstDataSet = new GST_INVOICE.db_gstDataSet();
            this.dbgstDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.name_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_error)).BeginInit();
            this.gst_menu.SuspendLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.db_gstDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgstDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cl_detail
            // 
            this.cl_detail.AutoSize = true;
            this.cl_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_detail.Location = new System.Drawing.Point(12, 35);
            this.cl_detail.Name = "cl_detail";
            this.cl_detail.Size = new System.Drawing.Size(312, 39);
            this.cl_detail.TabIndex = 0;
            this.cl_detail.Text = "Consignee Details";
            // 
            // cl_name
            // 
            this.cl_name.AutoSize = true;
            this.cl_name.Location = new System.Drawing.Point(22, 119);
            this.cl_name.Name = "cl_name";
            this.cl_name.Size = new System.Drawing.Size(84, 17);
            this.cl_name.TabIndex = 1;
            this.cl_name.Text = "Client Name";
            // 
            // c_address
            // 
            this.c_address.AutoSize = true;
            this.c_address.Location = new System.Drawing.Point(22, 211);
            this.c_address.Name = "c_address";
            this.c_address.Size = new System.Drawing.Size(60, 17);
            this.c_address.TabIndex = 3;
            this.c_address.Text = "Address";
            // 
            // c_contact
            // 
            this.c_contact.AutoSize = true;
            this.c_contact.Location = new System.Drawing.Point(22, 411);
            this.c_contact.Name = "c_contact";
            this.c_contact.Size = new System.Drawing.Size(103, 17);
            this.c_contact.TabIndex = 5;
            this.c_contact.Text = "Contact Details";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(190, 119);
            this.txt_name.MaxLength = 150;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(508, 22);
            this.txt_name.TabIndex = 6;
            this.txt_name.Text = " ";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(190, 211);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(508, 143);
            this.txt_address.TabIndex = 8;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(190, 411);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(212, 22);
            this.txt_mobile.TabIndex = 28;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(377, 678);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(187, 51);
            this.btn_register.TabIndex = 30;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // name_error
            // 
            this.name_error.ContainerControl = this;
            // 
            // product_error
            // 
            this.product_error.ContainerControl = this;
            // 
            // gst_menu
            // 
            this.gst_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gst_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.uSERREGISTRATIONToolStripMenuItem,
            this.cUSTOMERREGISTRATIONToolStripMenuItem,
            this.cONSIGNEToolStripMenuItem,
            this.iNVOICEToolStripMenuItem});
            this.gst_menu.Location = new System.Drawing.Point(0, 0);
            this.gst_menu.Name = "gst_menu";
            this.gst_menu.Size = new System.Drawing.Size(990, 28);
            this.gst_menu.TabIndex = 0;
            this.gst_menu.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hOMEToolStripMenuItem.Text = "HOME";
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
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.nEWToolStripMenuItem.Text = "NEW";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.eDITToolStripMenuItem.Text = "EDIT";
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
            this.nEWToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.nEWToolStripMenuItem1.Text = "NEW";
            // 
            // eDITToolStripMenuItem1
            // 
            this.eDITToolStripMenuItem1.Name = "eDITToolStripMenuItem1";
            this.eDITToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.eDITToolStripMenuItem1.Text = "EDIT";
            // 
            // cONSIGNEToolStripMenuItem
            // 
            this.cONSIGNEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem2,
            this.eDITToolStripMenuItem2});
            this.cONSIGNEToolStripMenuItem.Name = "cONSIGNEToolStripMenuItem";
            this.cONSIGNEToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.cONSIGNEToolStripMenuItem.Text = "CONSIGNE";
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
            // iNVOICEToolStripMenuItem
            // 
            this.iNVOICEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem3,
            this.eDITToolStripMenuItem3});
            this.iNVOICEToolStripMenuItem.Name = "iNVOICEToolStripMenuItem";
            this.iNVOICEToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.iNVOICEToolStripMenuItem.Text = "INVOICE";
            // 
            // nEWToolStripMenuItem3
            // 
            this.nEWToolStripMenuItem3.Name = "nEWToolStripMenuItem3";
            this.nEWToolStripMenuItem3.Size = new System.Drawing.Size(111, 24);
            this.nEWToolStripMenuItem3.Text = "NEW";
            // 
            // eDITToolStripMenuItem3
            // 
            this.eDITToolStripMenuItem3.Name = "eDITToolStripMenuItem3";
            this.eDITToolStripMenuItem3.Size = new System.Drawing.Size(111, 24);
            this.eDITToolStripMenuItem3.Text = "EDIT";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(22, 520);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(41, 17);
            this.lbl_state.TabIndex = 31;
            this.lbl_state.Text = "State";
            // 
            // combo_state
            // 
            this.combo_state.AllowDrop = true;
            this.combo_state.FormattingEnabled = true;
            this.combo_state.Location = new System.Drawing.Point(190, 513);
            this.combo_state.Name = "combo_state";
            this.combo_state.Size = new System.Drawing.Size(248, 24);
            this.combo_state.TabIndex = 32;
            this.combo_state.SelectedIndexChanged += new System.EventHandler(this.combo_state_SelectedIndexChanged);
            // 
            // lbl_stcode
            // 
            this.lbl_stcode.AutoSize = true;
            this.lbl_stcode.Location = new System.Drawing.Point(470, 520);
            this.lbl_stcode.Name = "lbl_stcode";
            this.lbl_stcode.Size = new System.Drawing.Size(76, 17);
            this.lbl_stcode.TabIndex = 33;
            this.lbl_stcode.Text = "State code";
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(588, 520);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(0, 17);
            this.lbl_code.TabIndex = 34;
            // 
            // db_gstDataSet
            // 
           // this.db_gstDataSet.DataSetName = "db_gstDataSet";
           // this.db_gstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbgstDataSetBindingSource
            // 
           // this.dbgstDataSetBindingSource.DataSource = this.db_gstDataSet;
            this.dbgstDataSetBindingSource.Position = 0;
            // 
            // consignee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(990, 840);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.lbl_stcode);
            this.Controls.Add(this.combo_state);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.gst_menu);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.c_contact);
            this.Controls.Add(this.c_address);
            this.Controls.Add(this.cl_name);
            this.Controls.Add(this.cl_detail);
            this.Name = "consignee";
            this.Text = "Company_Registraion";
            this.Load += new System.EventHandler(this.consignee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.name_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_error)).EndInit();
            this.gst_menu.ResumeLayout(false);
            this.gst_menu.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.db_gstDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgstDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cl_detail;
        private System.Windows.Forms.Label cl_name;
        private System.Windows.Forms.Label c_address;
        private System.Windows.Forms.Label c_contact;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ErrorProvider name_error;
        private System.Windows.Forms.ErrorProvider product_error;
        private System.Windows.Forms.MenuStrip gst_menu;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERREGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERREGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cONSIGNEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iNVOICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem3;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_stcode;
        private System.Windows.Forms.ComboBox combo_state;
        private System.Windows.Forms.Label lbl_state;
       // private db_gstDataSet db_gstDataSet;
        private System.Windows.Forms.BindingSource dbgstDataSetBindingSource;

        }

    
}