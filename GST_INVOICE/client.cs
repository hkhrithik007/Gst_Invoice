using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Data.OleDb;

namespace GST_INVOICE
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string get_state = "select * from tbl_state";
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(get_state, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    combo_state.Items.Clear();
                    DataRow dr;
                    dr = dt.NewRow();
                    dr.ItemArray = new object[] { 0, "--Select State--" };
                    dt.Rows.InsertAt(dr, 0);

                    combo_state.ValueMember = "st_code";

                    combo_state.DisplayMember = "st_name";
                    combo_state.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR(in LOADING)" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void combo_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_code.Text = combo_state.SelectedValue.ToString();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True");

                string gstin = txt_g1.Text + txt_g2.Text + txt_g3.Text + txt_g4.Text + txt_g5.Text + txt_g6.Text + txt_g7.Text;
                gstin += txt_g8.Text + txt_g9.Text + txt_g10.Text + txt_g11.Text + txt_g12.Text + txt_g13.Text + txt_g14.Text + txt_g15.Text;
               // string check_query = "select * from tbl_client"+LoginInfo.loginId+" where cl_gstin='" + gstin + "'";
               // SqlDataAdapter adpt = new SqlDataAdapter(check_query, con);
                //DataTable dt = new DataTable();
                //adpt.Fill(dt);
                con.Open();
               // if (dt.Rows.Count > 0)
                //{
                   // MessageBox.Show("GSTIN ALREADY EXISTS", "Duplicate");
              //  }
               // else
                {
                    string insert = "insert into tbl_client" + LoginInfo.loginId + " (cl_name,cl_contact,cl_add,cl_state,cl_code,cl_gstin)";
                    insert += "values('" + txt_name.Text + "','" + txt_mobile.Text + "','" + txt_address.Text.Replace(",", "") + "'";
                    insert += ",'" + combo_state.SelectedValue.ToString() + "','" + Convert.ToInt16(lbl_code.Text) + "','" + gstin + "')";

                    SqlCommand cmd = new SqlCommand(insert, con);
                    //int result=cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Added");
                        test tst = new test();
                        tst.Show();
                        this.Hide();
                    }
                    else { MessageBox.Show("try again"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!" + ex.Message);
            }
            finally { con.Close(); }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.ShowDialog();
            openfiledialog1.Filter = "allfiles|*.xls";
            textfilepath.Text = openfiledialog1.FileName;
        }

        private void upload_excel_Click(object sender, EventArgs e)
        {
            // string con = "Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string path = textfilepath.Text;

                string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";

                DataTable Data = new DataTable();

                using (OleDbConnection conn = new OleDbConnection(ConnString))
                {
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand(@"SELECT * FROM [sheet1$]", conn);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(Data);

                    conn.Close();
                }
                //string ConnStr = con;
                if (Data.Rows.Count > 0)
                {
                    //  SqlConnection connstr = new SqlConnection(con);
                    con.Open();
                    for (int i = 0; i < Data.Rows.Count; i++)
                    {
                       // string ins_query = "if not exists(select cl_id from tbl_client" + LoginInfo.loginId + "  where cl_gstin='" + Data.Rows[i][5].ToString() + "' and cl_gstin<>'NA')";
                       string ins_query = "Insert into tbl_client" + LoginInfo.loginId + " (cl_name,cl_contact,cl_add,cl_state,cl_code,cl_gstin) values ";
                        ins_query += " ('" + Data.Rows[i][0].ToString().Replace("'", "") + "','" + Data.Rows[i][1].ToString() + "','" + Data.Rows[i][2].ToString().Replace("'", "") + "','" + Data.Rows[i][3].ToString() + "'," + Convert.ToInt16(Data.Rows[i][4].ToString()) + ",'" + Data.Rows[i][5].ToString() + "')";
                        SqlCommand cmd = new SqlCommand(ins_query, con);
                        cmd.ExecuteNonQuery();
                    }
                    //con.Close();
                    MessageBox.Show("UPLOAD SUCCESSFULLY");
                    test tst = new test();
                    tst.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload ERROR" + ex.Message);
            }
            finally { con.Close(); }
        }
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                test home = new test();
                home.Show();
                this.Hide();
            }
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                client customer = new client();
                customer.Show();
                this.Hide();
            }
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                view_customer edit_cust = new view_customer();
                edit_cust.Show();
                this.Hide();
            }
        }

        private void nEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (check_registration.company_registration_check() > 0) { }
            else
            {
                Company_Registraion company = new Company_Registraion();
                company.Show();
                this.Hide();
            }
        }

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                edit_company edit_com = new edit_company();
                edit_com.Show();
                this.Hide();
            }
        }

        private void nEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                invoice inv = new invoice();
                inv.Show();
                this.Hide();
            }
        }

        private void eDITToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            search_invoice search = new search_invoice();
            search.Show();
            this.Hide();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export_to_excel export = new export_to_excel();
            export.Show();
            this.Hide();
        }

        private void client_Click(object sender, EventArgs e)
        {
            //this.Focus();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                import_invoice import = new import_invoice();
                import.ShowDialog();
                // this.Hide();
            }
        }

        private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHANGEPASSWORD change = new CHANGEPASSWORD();
            change.ShowDialog();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            company_login login = new company_login();
            login.Show();
            this.Close();
        }
    }
}
