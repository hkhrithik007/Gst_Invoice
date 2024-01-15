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
    public partial class edit_company : Form
    {
        public edit_company()
        {
            InitializeComponent();
        }
        public static int file = 0;
        private void edit_company_Load(object sender, EventArgs e)
        {
            fill_type_combo();
            fill_data();
        }
        private void fill_data()
        {
            // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string getdata = "select * from tbl_company where c_id="+LoginInfo.loginId+" ";
                string get_inv = "select count(inv_no) as no_of_rows from tbl_invoice" + LoginInfo.loginId + "  ";
                SqlDataAdapter get_inv_adpt = new SqlDataAdapter(get_inv, con);
                SqlDataAdapter adpt = new SqlDataAdapter(getdata, con);
                DataTable dt = new DataTable();
                DataTable inv_dt = new DataTable();
                con.Open();
                adpt.Fill(dt);
                get_inv_adpt.Fill(inv_dt);
                //con.Close();
                if (dt.Rows.Count > 0)
                {
                    txt_name.Text = dt.Rows[0]["c_name"].ToString();
                    txt_product.Text = dt.Rows[0]["c_deal"].ToString();
                    txt_address.Text = dt.Rows[0]["c_address"].ToString();
                    char[] chararray = dt.Rows[0]["c_gst"].ToString().ToCharArray();
                    for (int i = 0; i <= chararray.Length - 1; i++)
                    {
                        //  TextBox textBox = this.Controls.Find("txtg"+i,true);
                        TextBox tbx = (TextBox)this.Controls.Find("txt_g" + (i + 1), false).FirstOrDefault();
                        tbx.Text = chararray[i].ToString();
                        //("txt_g"+i+"")
                    }
                    txt_office.Text = dt.Rows[0]["c_office"].ToString();
                    txt_mobile.Text = dt.Rows[0]["c_mob"].ToString();
                    txt_mail.Text = dt.Rows[0]["c_mail"].ToString();
                    txt_acname.Text = dt.Rows[0]["account_name"].ToString();
                    txt_acno.Text = dt.Rows[0]["acc_no"].ToString();
                    txt_bank.Text = dt.Rows[0]["bank_name"].ToString();
                    txt_ifsc.Text = dt.Rows[0]["ifsc"].ToString();

                    if (dt.Rows[0]["c_logo"].ToString() != "")
                    {
                        file = 1;
                    }
                    txt_logo.Text = dt.Rows[0]["c_logo"].ToString();
                    combo_inv_type.SelectedValue = dt.Rows[0]["inv_type"].ToString();
                    if (inv_dt.Rows.Count > 0)
                    {
                        if (Convert.ToInt16(inv_dt.Rows[0][0].ToString()) > 0)
                        {
                            lbl_last_invoice.Visible = false;
                            txt_start_from.Visible = false;
                        }
                        else
                        {
                           
                            if (Convert.ToInt16(dt.Rows[0]["inv_start"].ToString()) < 0)
                            {
                                lbl_last_invoice.Visible = false;
                                txt_start_from.Visible = false;
                            }
                            else
                            {
                                lbl_last_invoice.Visible = true;
                                txt_start_from.Visible = true;
                                txt_start_from.Text = dt.Rows[0]["inv_start"].ToString();
                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code ST" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void fill_type_combo()
        {
            combo_inv_type.Items.Clear();

            combo_inv_type.DisplayMember = "Text";
            combo_inv_type.ValueMember = "Value";

            var items = new[] { new { Text = "TAX-INVOICE", Value = "TAX-INVOICE" }, new { Text = "COMPOSITION-INVOICE", Value = "COMPOSITION-INVOICE" } };

            combo_inv_type.DataSource = items;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            try
            {
                string url = "";
                if (txt_logo.Text == "") { }
                else
                {
                    if (file == 0)
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
                    else
                    {
                        url = txt_logo.Text;
                    }
                }

                string gstin = txt_g1.Text + txt_g2.Text + txt_g3.Text + txt_g4.Text + txt_g5.Text + txt_g6.Text + txt_g7.Text;
                gstin += txt_g8.Text + txt_g9.Text + txt_g10.Text + txt_g11.Text + txt_g12.Text + txt_g13.Text + txt_g14.Text + txt_g15.Text;

                int inv_no_update = -1;
                if (txt_start_from.Text != "") { inv_no_update = Convert.ToInt16(txt_start_from.Text); }

                string insert = "update tbl_company set c_name='" + txt_name.Text + "',c_deal='" + txt_product.Text + "',";
                insert += "c_address='" + txt_address.Text.Replace(",", "") + "',c_gst='" + gstin + "',";
                insert += "c_office='" + txt_office.Text + "',c_mob='" + txt_mobile.Text + "',c_mail='" + txt_mail.Text + "',c_logo='" + url + "',inv_type='" + combo_inv_type.SelectedValue + "', inv_start=" + inv_no_update;
                insert += ",account_name='"+txt_acname.Text+"',acc_no='"+txt_acno.Text+"',bank_name='"+txt_bank.Text+"',ifsc='"+txt_ifsc.Text+"' where c_id="+LoginInfo.loginId+" ";
                //insert += "account_name='" + txt_ac_name.Text + "',acc_no='" + txt_ac_num.Text + "',bank_name='" + txt_bank.Text + "',";
                // insert += "bank_branch='" + txt_branch.Text + "',ifsc='" + txt_ifsc.Text + "',micr='" + txt_micr.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(insert, con);
                //int result=cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Update Successfully");
                    test tst = new test();
                    tst.Show();
                    this.Hide();
                }
                else { MessageBox.Show("try again"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code UPC" + ex.Message);
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
