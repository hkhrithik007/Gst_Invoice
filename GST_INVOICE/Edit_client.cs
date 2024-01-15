using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_INVOICE
{
    public partial class Edit_client : Form
    {
        public Edit_client()
        {
            InitializeComponent();

        }

        private void Edit_client_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(view_customer.gstin);
            fill_state();
            fill_client();
        }
        public static int cust_id = 0;
        private void fill_client()
        {
            // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string get_cust = "select * from tbl_client" + LoginInfo.loginId + "  where cl_id=" + view_customer.clid + "";
                SqlDataAdapter adpt = new SqlDataAdapter(get_cust, con);
                DataTable dt = new DataTable();
                con.Open();
                adpt.Fill(dt);
                //con.Close();
                if (dt.Rows.Count > 0)
                {
                    cust_id = Convert.ToInt16(dt.Rows[0]["cl_id"].ToString());
                    txt_name.Text = dt.Rows[0]["cl_name"].ToString();
                    txt_address.Text = dt.Rows[0]["cl_add"].ToString();
                    char[] chararray = dt.Rows[0]["cl_gstin"].ToString().ToCharArray();
                    for (int i = 0; i <= chararray.Length - 1; i++)
                    {
                        //  TextBox textBox = this.Controls.Find("txtg"+i,true);
                        TextBox tbx = (TextBox)this.Controls.Find("txt_g" + (i + 1), false).FirstOrDefault();
                        tbx.Text = chararray[i].ToString();
                        //("txt_g"+i+"")
                    }
                    txt_mobile.Text = dt.Rows[0]["cl_contact"].ToString();
                    combo_state.SelectedValue = dt.Rows[0]["cl_code"].ToString();
                    lbl_code.Text = combo_state.SelectedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error(CODE-CL)" + ex.Message);
            }
            finally { con.Close(); }
        }
        private void fill_state()
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
                MessageBox.Show("Error Code ST" + ex.Message);
            }
            finally {
                con.Close();
            }
        }

        private void combo_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_code.Text = combo_state.SelectedValue.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());


            try
            {
                string gstin = txt_g1.Text + txt_g2.Text + txt_g3.Text + txt_g4.Text + txt_g5.Text + txt_g6.Text + txt_g7.Text;
                gstin += txt_g8.Text + txt_g9.Text + txt_g10.Text + txt_g11.Text + txt_g12.Text + txt_g13.Text + txt_g14.Text + txt_g15.Text;
               // string query = "";
                //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
               // if (gstin.ToString() != "NA") {
                //    query = "select cl_id from tbl_client" + LoginInfo.loginId + "  where cl_gstin='" + gstin + "' and cl_id not in (" + cust_id + ") ";
               // }
               // else { query = "select cl_id from tbl_client" + LoginInfo.loginId + "  where cl_id=" + view_customer.clid + " and cl_id not in (" + cust_id + ")"; }
               // SqlDataAdapter adpt = new SqlDataAdapter(query, con);
               // DataTable dt = new DataTable();
                con.Open();
               // adpt.Fill(dt);
                //con.Close();
               // if (dt.Rows.Count > 0)
              //  {
               //     MessageBox.Show("GSTIN/CUSTOMER already exists!");
               // }
               // else
                {
                    string insert = "update  tbl_client" + LoginInfo.loginId + "  set cl_name='" + txt_name.Text + "',cl_contact='" + txt_mobile.Text + "',cl_add='" + txt_address.Text.Replace(",", "") + "',cl_state='" + combo_state.SelectedValue.ToString() + "'";
                    insert += " ,cl_code='" + Convert.ToInt16(lbl_code.Text) + "',cl_gstin='" + gstin + "' where cl_id=" + cust_id + "";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    //int result=cmd.ExecuteNonQuery();
                   // con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Update Successfully");
                        test tst = new test();
                        tst.Show();
                        this.Hide();
                        //Edit_client edt = new Edit_client();
                        //edt.Closed();
                    }
                    else { MessageBox.Show("try again"); }
                   // con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code UPCL" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                test tst = new test();
                tst.Show();
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

        private void cUSTOMERREGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                Company_Registraion com = new Company_Registraion();
                com.Show();
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
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                search_invoice search = new search_invoice();
                search.Show();
                this.Hide();
            }
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_registration.check_if_registered() > 0) { }
            else
            {
                export_to_excel export = new export_to_excel();
                export.Show();
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


    }
}
