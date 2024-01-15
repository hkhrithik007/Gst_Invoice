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
    public partial class search_invoice : Form
    {
        public search_invoice()
        {
            InitializeComponent();
            txt_from_date.Text = System.DateTime.Today.ToShortDateString();
            txt_to_date.Text = System.DateTime.Today.ToShortDateString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                dataGridView1.Visible = false;
                MessageBox.Show("Please enter some text");
            }
            else
            {
                dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                bind_grid(0);
            }

        }
        private void bind_grid(int check)
        {
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                DataTable dt = new DataTable();
                string query = "";
                if (check == 0)
                {
                    if (chk_date.Checked == true)
                    {
                        if (radio_byname.Checked == true)
                        {
                            query = "select distinct (invoice_no),cl_name,inv_date from tbl_invoice" + LoginInfo.loginId + "  as a join tbl_client" + LoginInfo.loginId + "  as b on a.inv_cid=b.cl_id ";
                            query += "where inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "' and cl_name like '%" + txt_search.Text + "%' and flag=1";
                        }
                        else
                        {
                            query = "select distinct (invoice_no),cl_name,inv_date from tbl_invoice" + LoginInfo.loginId + "  as a join tbl_client" + LoginInfo.loginId + "  as b on a.inv_cid=b.cl_id ";
                            query += "where inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "' and invoice_no =" + txt_search.Text + " and flag=1";
                        }
                    }
                    else
                    {
                        if (radio_byname.Checked == true)
                        {
                            query = "select distinct (invoice_no),cl_name,inv_date from tbl_invoice" + LoginInfo.loginId + "  as a join tbl_client" + LoginInfo.loginId + "  as b on a.inv_cid=b.cl_id ";
                            query += "where  cl_name like '%" + txt_search.Text + "%' and flag=1";
                        }
                        else
                        {
                            query = "select distinct (invoice_no),cl_name,inv_date from tbl_invoice" + LoginInfo.loginId + "  as a join tbl_client" + LoginInfo.loginId + "  as b on a.inv_cid=b.cl_id ";
                            query += "where  invoice_no =" + txt_search.Text + " and flag=1";
                        }
                    }
                }
                else
                {
                    query = "select distinct (invoice_no),cl_name,inv_date from tbl_invoice" + LoginInfo.loginId + "  as a join tbl_client" + LoginInfo.loginId + "  as b on a.inv_cid=b.cl_id ";
                    query += "where inv_date between '" + txt_from_date.Text + "' and '" + txt_to_date.Text + "' and flag=1";
                }

                SqlDataAdapter adpt = new SqlDataAdapter(query, con);
                con.Open();
                adpt.Fill(dt);
               // con.Close();
                if (dt.Rows.Count > 0)
                {
                    // dataGridView1.DataSource = dt;
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].Name = "grid_inv_no";
                    dataGridView1.Columns[0].HeaderText = "INVOICE NO.";

                    dataGridView1.Columns[1].Name = "grid_clname";
                    dataGridView1.Columns[1].HeaderText = "CLIENT NAME";

                    dataGridView1.Columns[2].Name = "grid_date";
                    dataGridView1.Columns[2].HeaderText = "DATE OF ISSUE";


                    DataGridViewButtonColumn printButton = new DataGridViewButtonColumn();
                    printButton.FlatStyle = FlatStyle.Popup;
                    printButton.Text = "PRINT";
                    printButton.HeaderText = "PRINT";
                    dataGridView1.Columns.Add(printButton);

                    DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                    editButton.FlatStyle = FlatStyle.Popup;
                    editButton.Text = "EDIT";
                    editButton.HeaderText = "EDIT";
                    dataGridView1.Columns.Add(editButton);




                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                    deleteButton.FlatStyle = FlatStyle.Popup;
                    deleteButton.Text = "DELETE";
                    deleteButton.HeaderText = "DELETE";
                    dataGridView1.Columns.Add(deleteButton);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string[] row = new string[] { dt.Rows[i]["invoice_no"].ToString(), dt.Rows[i]["cl_name"].ToString(), Convert.ToDateTime(dt.Rows[i]["inv_date"]).ToString("dd MMM yyyy"), "PRINT", "EDIT", "DELETE" };
                        dataGridView1.Rows.Add(row);

                    }
                    dataGridView1.Visible = true;

                }
                else
                {
                    dataGridView1.Visible = false;
                    dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    MessageBox.Show("No data available");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code BINDINVGRID" + ex.Message);
            }
            finally
            {
                con.Close();

            }
        }





        private void txt_from_date_Enter(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            bind_grid(1);
        }

        private void radio_byname_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            txt_search.Text = "";
        }

        private void radio_byinvoice_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            txt_search.Text = "";
        }

        private void chk_date_CheckStateChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            txt_search.Text = "";
        }
        public static int invoice_id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {

                    var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                    if (cell.OwningColumn.HeaderText == "DELETE")
                    {
                        var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                   "Confirm Delete!!",
                                   MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            // If 'Yes', do something here.

                            //TODO - Button Clicked - Execute Code Here

                            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True");

                            string query = "update tbl_invoice" + LoginInfo.loginId + "  set flag=0 where invoice_no=" + Convert.ToInt32(cell.OwningRow.Cells["grid_inv_no"].Value.ToString());
                            SqlCommand cmd = new SqlCommand(query, con);
                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Deleted");
                                dataGridView1.DataSource = null;
                                this.dataGridView1.Rows.Clear();
                                bind_grid(1);
                            }
                            else
                            {
                                dataGridView1.DataSource = null;
                                this.dataGridView1.Rows.Clear(); MessageBox.Show("Not delelted");
                            }
                            con.Close();
                        }
                        else { }
                    }
                    if (cell.OwningColumn.HeaderText == "PRINT")
                    {
                        GeneratePDF.Generate(Convert.ToInt32(cell.OwningRow.Cells["grid_inv_no"].Value.ToString()));
                    }
                    if (cell.OwningColumn.HeaderText == "EDIT")
                    {
                        invoice_id = Convert.ToInt32(cell.OwningRow.Cells["grid_inv_no"].Value.ToString());
                        edit_invoice edit_inv = new edit_invoice();
                        edit_inv.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code GRIDCELLCLIK" + ex.Message);
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

        private void search_invoice_Load(object sender, EventArgs e)
        {

        }

        private void txt_from_date_MouseClick(object sender, MouseEventArgs e)
        {
            cal_from_date.Visible = true;
        }

        private void txt_to_date_MouseClick(object sender, MouseEventArgs e)
        {
            cal_to_date.Visible = true;
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
