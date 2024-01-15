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
using System.IO;

namespace GST_INVOICE
{
    public partial class Company_Registraion : Form
    {
        public Company_Registraion()
        {
            InitializeComponent();
            //SqlConnection con = new SqlConnection("Data Source=RB-PC;Initial Catalog=db_gst;Integrated Security=True"); 
        }

        private void Company_Registraion_Load(object sender, EventArgs e)
        {
            fill_type_combo();

        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txt_product_Validating(object sender, CancelEventArgs e)
        {

        }
        private void fill_type_combo()
        {
            combo_inv_type.Items.Clear();

            combo_inv_type.DisplayMember = "Text";
            combo_inv_type.ValueMember = "Value";

            var items = new[] { new { Text = "TAX-INVOICE", Value = "TAX-INVOICE" }, new { Text = "COMPOSITION-INVOICE", Value = "COMPOSITION-INVOICE" } };

            combo_inv_type.DataSource = items;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string gstin = txt_g1.Text + txt_g2.Text + txt_g3.Text + txt_g4.Text + txt_g5.Text + txt_g6.Text + txt_g7.Text;
                gstin += txt_g8.Text + txt_g9.Text + txt_g10.Text + txt_g11.Text + txt_g12.Text + txt_g13.Text + txt_g14.Text + txt_g15.Text;
                string check_query = "select * from tbl_company where c_gst='" + gstin + "'";
                SqlDataAdapter adpt = new SqlDataAdapter(check_query, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                con.Open();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("GSTIN ALREADY EXISTS", "Duplicate");
                }
                else
                {
                    string insert = "";
                    SqlCommand cmd = new SqlCommand();
                    string url = " ";
                    int start_index = -1;
                    if (txt_start_from.Text == "") { }
                    else { start_index = Convert.ToInt16(txt_start_from.Text); }
                    if (txt_logo.Text == "")
                    {

                    }

                    else
                    {
                        string picname = txt_logo.Text.Substring(txt_logo.Text.LastIndexOf('\\'));
                        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\images\";
                        if (Directory.Exists(path) == false)
                        {
                            Directory.CreateDirectory(path);
                        }
                        string iName = image_upload.SafeFileName;   // <---
                        string filepath = image_upload.FileName;
                        File.Delete(path + iName);// <---
                        File.Copy(filepath, path + iName);
                        url = path + iName;
                    }
                    string password = Guid.NewGuid().ToString().Substring(0, 7);
                    insert = "insert into tbl_company(c_name,c_deal,c_address,c_gst,c_office,c_mob,c_mail,c_logo,inv_type,inv_start,account_name,acc_no,bank_name,ifsc)";
                    insert += "values('" + txt_name.Text + "','" + txt_product.Text + "','" + txt_address.Text.Replace(",", "") + "'";
                    insert += ",'" + gstin + "','" + txt_office.Text + "','" + txt_mobile.Text + "','" + txt_mail.Text + "','" + url + "','" + combo_inv_type.SelectedValue + "'," + start_index + "";
                    insert += ",'" + txt_acname.Text + "','" + txt_acno.Text + "','" + txt_bank.Text + "','" + txt_ifsc.Text + "' )";

                    cmd = new SqlCommand(insert, con);
                    





                    //int result=cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string get_cid="select c_id from tbl_company where c_gst='"+gstin+"'";
                        SqlDataAdapter adptcid = new SqlDataAdapter(get_cid,con);
                        DataTable dtcid= new DataTable();
                        adptcid.Fill(dtcid);
                        GenerateTables.create_invoice_table(Convert.ToInt16(dtcid.Rows[0][0].ToString()));
                        GenerateTables.create_customer_table(Convert.ToInt16(dtcid.Rows[0][0].ToString()));
                        //company_login clogin = new company_login();
                       // clogin.Refresh();
                        this.Close();
                      
                       // clogin.Load;
                        //clogin.Invalidate();
                        //clogin.fill_company();
                       // clogin.Load();
                        //clogin.Refresh();
                       // clogin.Show();
                        //clogin.Dispose();
                        //clogin.Show();
                        
                    }
                    else { MessageBox.Show("try again"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Registration" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txt_address_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_g1_Validating(object sender, CancelEventArgs e)
        {

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

        private void nEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (check_registration.company_registration_check() > 0) { }
            else
            {
                Company_Registraion company = new Company_Registraion();
                company.Show();
                this.Hide();
            }
            //Company_Registraion com = new Company_Registraion();
            //com.Show();
            //this.Hide();
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
        public static string image_stream = "";
        private void btn_brows_Click(object sender, EventArgs e)
        {

            image_upload.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (image_upload.ShowDialog() == DialogResult.OK)
            {
                txt_logo.Text = image_upload.FileName;


            }

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


    }

}
