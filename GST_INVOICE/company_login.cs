using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_INVOICE
{
    public partial class company_login : Form
    {
        public company_login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Company_Registraion register = new Company_Registraion();
            register.ShowDialog();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {


            if (combo_company.SelectedIndex==0)
            {
                MessageBox.Show("Select A company");
            }
            else
            {
                LoginInfo.loginId = Convert.ToInt16(combo_company.SelectedValue);
                test home = new test();
                home.Show();
                this.Hide();

            }


        }
        public void fill_company()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {

                string check = "Select c_id,c_name from tbl_company";
                SqlDataAdapter adpt = new SqlDataAdapter(check, con);
                DataTable dt = new DataTable();
                con.Open();
                adpt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    btn_login.Visible = true;
                    // DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView1[12, row];
                    combo_company.Items.Clear();
                    DataRow dr;
                    dr = dt.NewRow();
                    dr.ItemArray = new object[] { 0, "--Select Company--" };
                    dt.Rows.InsertAt(dr, 0);
                    combo_company.ValueMember = "c_id";
                    combo_company.DisplayMember = "c_name";
                    combo_company.DataSource = dt;

                    //comboCell.Items.sel   
                }
                else
                {
                    btn_login.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void company_login_Load(object sender, EventArgs e)
        {
            fill_company();
            string path = Path.GetFullPath(Environment.CurrentDirectory);
           
        }

        private void lbl_refrs_lst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            combo_company.DataSource = null;
            fill_company();
        }
    }
}
