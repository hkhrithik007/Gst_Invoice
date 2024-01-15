namespace GST_INVOICE
{
    partial class company_login
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
            this.lbl_mail = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.combo_company = new System.Windows.Forms.ComboBox();
            this.lbl_refrs_lst = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(60, 74);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(110, 17);
            this.lbl_mail.TabIndex = 0;
            this.lbl_mail.Text = "Select Company";
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(325, 127);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(152, 31);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(383, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register New Company";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // combo_company
            // 
            this.combo_company.FormattingEnabled = true;
            this.combo_company.Location = new System.Drawing.Point(204, 74);
            this.combo_company.Name = "combo_company";
            this.combo_company.Size = new System.Drawing.Size(273, 24);
            this.combo_company.TabIndex = 7;
            // 
            // lbl_refrs_lst
            // 
            this.lbl_refrs_lst.AutoSize = true;
            this.lbl_refrs_lst.Location = new System.Drawing.Point(483, 77);
            this.lbl_refrs_lst.Name = "lbl_refrs_lst";
            this.lbl_refrs_lst.Size = new System.Drawing.Size(84, 17);
            this.lbl_refrs_lst.TabIndex = 8;
            this.lbl_refrs_lst.TabStop = true;
            this.lbl_refrs_lst.Text = "Refresh List";
            this.lbl_refrs_lst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_refrs_lst_LinkClicked);
            // 
            // company_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 319);
            this.Controls.Add(this.lbl_refrs_lst);
            this.Controls.Add(this.combo_company);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_mail);
            this.Name = "company_login";
            this.Text = "COMPANY LOGIN";
            this.Load += new System.EventHandler(this.company_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox combo_company;
        private System.Windows.Forms.LinkLabel lbl_refrs_lst;
    }
}