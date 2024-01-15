namespace GST_INVOICE {
partial class CHANGEPASSWORD {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed;
  /// otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

#region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.label2 = new System.Windows.Forms.Label();
    this.label3 = new System.Windows.Forms.Label();
    this.txt_new = new System.Windows.Forms.TextBox();
    this.txt_cnf = new System.Windows.Forms.TextBox();
    this.btn_change = new System.Windows.Forms.Button();
    this.SuspendLayout();
    //
    // label2
    //
    this.label2.AutoSize = true;
    this.label2.Location = new System.Drawing.Point(89, 116);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(100, 17);
    this.label2.TabIndex = 1;
    this.label2.Text = "New Password";
    //
    // label3
    //
    this.label3.AutoSize = true;
    this.label3.Location = new System.Drawing.Point(89, 158);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(121, 17);
    this.label3.TabIndex = 2;
    this.label3.Text = "Confirm Password";
    //
    // txt_new
    //
    this.txt_new.Location = new System.Drawing.Point(229, 111);
    this.txt_new.Name = "txt_new";
    this.txt_new.Size = new System.Drawing.Size(268, 22);
    this.txt_new.TabIndex = 4;
    //
    // txt_cnf
    //
    this.txt_cnf.Location = new System.Drawing.Point(229, 153);
    this.txt_cnf.Name = "txt_cnf";
    this.txt_cnf.Size = new System.Drawing.Size(268, 22);
    this.txt_cnf.TabIndex = 5;
    //
    // btn_change
    //
    this.btn_change.Location = new System.Drawing.Point(229, 213);
    this.btn_change.Name = "btn_change";
    this.btn_change.Size = new System.Drawing.Size(268, 40);
    this.btn_change.TabIndex = 6;
    this.btn_change.Text = "Change password";
    this.btn_change.UseVisualStyleBackColor = true;
    this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
    //
    // CHANGEPASSWORD
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(574, 338);
    this.Controls.Add(this.btn_change);
    this.Controls.Add(this.txt_cnf);
    this.Controls.Add(this.txt_new);
    this.Controls.Add(this.label3);
    this.Controls.Add(this.label2);
    this.Name = "CHANGEPASSWORD";
    this.Text = "CHANGEPASSWORD";
    this.ResumeLayout(false);
    this.PerformLayout();
  }

#endregion

  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txt_new;
  private System.Windows.Forms.TextBox txt_cnf;
  private System.Windows.Forms.Button btn_change;
}
}
