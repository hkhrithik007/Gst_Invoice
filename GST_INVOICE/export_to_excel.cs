using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GST_INVOICE
{
    public partial class export_to_excel : Form
    {
        public export_to_excel()
        {
            InitializeComponent();
            txt_from_date.Text = System.DateTime.Today.ToShortDateString();
            txt_to_date.Text = System.DateTime.Today.ToShortDateString();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            cal_from_date.Visible = true;
        }

        private void cal_from_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            var cal_from_date = sender as MonthCalendar;
            txt_from_date.Text = cal_from_date.SelectionStart.ToShortDateString();

            //cal_from_date.Visible = false;
        }

        private void txt_from_date_Leave(object sender, EventArgs e)
        {
            if (!cal_from_date.Focused)
                cal_from_date.Visible = false;
            if (txt_from_date.Text == "")
            {
                txt_from_date.Text = System.DateTime.Today.ToShortDateString();
            }
        }

        private void cal_from_date_DateSelected(object sender, DateRangeEventArgs e)
        {
            var cal_from_date = sender as MonthCalendar;
            txt_from_date.Text = cal_from_date.SelectionStart.ToShortDateString();

             cal_from_date.Visible = false;
        }

        private void cal_from_date_Leave(object sender, EventArgs e)
        {
            var cal_from_date = sender as MonthCalendar;
            cal_from_date.Visible = false;
        }

        private void txt_to_date_Enter(object sender, EventArgs e)
        {
            cal_to_date.Visible = true;
        }

        private void txt_to_date_Leave(object sender, EventArgs e)
        {
            if (!cal_to_date.Focused)
                cal_to_date.Visible = false;
            if (txt_to_date.Text == "")
            {
                txt_to_date.Text = System.DateTime.Today.ToShortDateString();
            }
        }

        private void cal_to_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            var cal_to_date = sender as MonthCalendar;
            txt_to_date.Text = cal_to_date.SelectionStart.ToShortDateString();

           // cal_to_date.Visible = false;
        }

        private void cal_to_date_DateSelected(object sender, DateRangeEventArgs e)
        {
            var cal_to_date = sender as MonthCalendar;
            txt_to_date.Text = cal_to_date.SelectionStart.ToShortDateString();

            cal_to_date.Visible = false;
        }

        private void cal_to_date_Leave(object sender, EventArgs e)
        {
            var cal_to_date = sender as MonthCalendar;
            cal_to_date.Visible = false;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txt_search.Text == "" && radio_all.Checked == false)
                {
                    MessageBox.Show("Enter some text");
                }
                else
                {
                    string query = "";
                    string inv_data = "inv_date,invoice_no,cl_name,cl_gstin,cl_contact,cl_add";
                    inv_data += ",cl_state,cl_code,inv_part,inv_hsn,inv_qty,inv_unit,inv_rate";
                    inv_data += ",inv_value,inv_disc,inv_tax_val,inv_sgst_rate,inv_sgst_amt";
                    inv_data += ",inv_cgst_rate,inv_cgst_amt,inv_igst_rate,inv_igst_amt";
                    inv_data += ",inv_befor_tax,inv_total_gst,inv_total_cgst,inv_total_igst,inv_other_charge";
                    inv_data += ",inv_grand_total,gst_reserve,flag ";
                    if (chk_inc_del.Checked == true)
                    {
                        if (radio_byname.Checked == true)
                        {
                            query = "select " + inv_data + " from tbl_client" + LoginInfo.loginId + "  as a join tbl_invoice" + LoginInfo.loginId + "  as b ";
                            query += " on a.cl_id=b.inv_cid where b.inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "' and cl_name like '%" + txt_search.Text + "%' order by invoice_no asc ";
                        }
                        else if (radio_bygstin.Checked == true)
                        {
                            query = "select " + inv_data + " from tbl_client" + LoginInfo.loginId + "  as a join tbl_invoice" + LoginInfo.loginId + "  as b ";
                            query += " on a.cl_id=b.inv_cid where b.inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "' and a.cl_gstin= '" + txt_search.Text + "' order by invoice_no asc";
                        }
                        else
                        {
                            query = "select " + inv_data + " from tbl_client" + LoginInfo.loginId + "  as a join tbl_invoice" + LoginInfo.loginId + "  as b ";
                            query += " on a.cl_id=b.inv_cid where b.inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "'  order by invoice_no asc";
                        }
                    }
                    else
                    {
                        if (radio_byname.Checked == true)
                        {
                            query = "select " + inv_data + " from tbl_client" + LoginInfo.loginId + "  as a join tbl_invoice" + LoginInfo.loginId + "  as b ";
                            query += " on a.cl_id=b.inv_cid where b.inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "' and cl_name like '%" + txt_search.Text + "%' where flag=1 order by invoice_no asc";
                        }
                        else if (radio_bygstin.Checked == true)
                        {
                            query = "select " + inv_data + " from tbl_client" + LoginInfo.loginId + "  as a join tbl_invoice" + LoginInfo.loginId + "  as b ";
                            query += " on a.cl_id=b.inv_cid where b.inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "' and a.cl_gstin= '" + txt_search.Text + "' where flag=1 order by invoice_no asc";
                        }
                        else
                        {
                            query = "select " + inv_data + " from tbl_client" + LoginInfo.loginId + "  as a join tbl_invoice" + LoginInfo.loginId + "  as b ";
                            query += " on a.cl_id=b.inv_cid where b.inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "' where flag=1 order by invoice_no asc";
                        }
                    }

                    ExportInvoice.Export_to_excel(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code UPINSROWEXCL" + ex.Message);
            }
            finally
            {
               // cnn.Close();

            }

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
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

        private void txt_from_date_MouseClick(object sender, MouseEventArgs e)
        {
          cal_from_date.Visible = true;
        }

        private void txt_to_date_MouseClick(object sender, MouseEventArgs e)
        {
            cal_to_date.Visible = true;
        }

        private void btn_inv_backup_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from tbl_invoice" + LoginInfo.loginId + " ";
                    ExportInvoice.BackupInvoices(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show("BACKUP ERROR:"+ex.Message);
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
