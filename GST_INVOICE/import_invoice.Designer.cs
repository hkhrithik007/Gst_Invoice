namespace GST_INVOICE
{
    partial class import_invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.textfilepath = new System.Windows.Forms.TextBox();
            this.btn_import_backup = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT INVOICE";
            // 
            // textfilepath
            // 
            this.textfilepath.Location = new System.Drawing.Point(205, 125);
            this.textfilepath.Name = "textfilepath";
            this.textfilepath.ReadOnly = true;
            this.textfilepath.Size = new System.Drawing.Size(221, 22);
            this.textfilepath.TabIndex = 1;
            // 
            // btn_import_backup
            // 
            this.btn_import_backup.Location = new System.Drawing.Point(260, 211);
            this.btn_import_backup.Name = "btn_import_backup";
            this.btn_import_backup.Size = new System.Drawing.Size(166, 48);
            this.btn_import_backup.TabIndex = 2;
            this.btn_import_backup.Text = "IMPORT BACKUP";
            this.btn_import_backup.UseVisualStyleBackColor = true;
            this.btn_import_backup.Click += new System.EventHandler(this.btn_import_backup_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(432, 124);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 3;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // import_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(808, 685);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_import_backup);
            this.Controls.Add(this.textfilepath);
            this.Controls.Add(this.label1);
            this.Name = "import_invoice";
            this.Text = "IMPORT BACKUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textfilepath;
        private System.Windows.Forms.Button btn_import_backup;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}