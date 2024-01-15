using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_INVOICE
{
    public partial class CHANGEPASSWORD : Form
    {
        public CHANGEPASSWORD()
        {
            InitializeComponent();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_cnf.Text == "" || txt_new.Text == "")
            {
                MessageBox.Show("Please Enter some text");
            }
            else
            {
                if (txt_cnf.Text == txt_new.Text)
                {
                    change_password.change(LoginInfo.loginId, txt_new.Text.Replace("'", ""));

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Must be same");
                }
            }
        }
    }
}
