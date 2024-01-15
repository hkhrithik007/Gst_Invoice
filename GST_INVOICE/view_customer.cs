using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace GST_INVOICE
{
    public partial class view_customer : Form
    {
        public view_customer()
        {
            InitializeComponent();

        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            txt_search.Text = "";
            bind_grid();
        }
        private void bind_grid()
        {

           // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                DataTable dt = new DataTable();
                string query = "";
                query = "select cl_id,cl_name,cl_add,cl_contact,st_name,cl_code,cl_gstin from tbl_client" + LoginInfo.loginId + "  as a join tbl_state as b ";
                query += " on a.cl_code=b.st_code ";

                SqlDataAdapter adpt = new SqlDataAdapter(query, con);
                con.Open();
                adpt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].Name = "grid_name";
                    dataGridView1.Columns[0].HeaderText = "Name";

                    dataGridView1.Columns[1].Name = "grid_add";
                    dataGridView1.Columns[1].HeaderText = "Address";

                    dataGridView1.Columns[2].Name = "grid_contact";
                    dataGridView1.Columns[2].HeaderText = "Contact";

                    dataGridView1.Columns[3].Name = "grid_state";
                    dataGridView1.Columns[3].HeaderText = "State";

                    dataGridView1.Columns[4].Name = "grid_code";
                    dataGridView1.Columns[4].HeaderText = "Code";

                    dataGridView1.Columns[5].Name = "grid_gstin";
                    dataGridView1.Columns[5].HeaderText = "GSTIN";

                    dataGridView1.Columns[6].Name = "grid_clid";
                    dataGridView1.Columns[6].HeaderText = "CLID";
                    dataGridView1.Columns[6].Visible = false;

                    DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                    editButton.FlatStyle = FlatStyle.Popup;
                    editButton.Text = "Edit";
                    editButton.HeaderText = "Edit";
                    dataGridView1.Columns.Add(editButton);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string[] row = new string[] { dt.Rows[i]["cl_name"].ToString(), dt.Rows[i]["cl_add"].ToString(), dt.Rows[i]["cl_contact"].ToString(), dt.Rows[i]["st_name"].ToString(), dt.Rows[i]["cl_code"].ToString(), dt.Rows[i]["cl_gstin"].ToString(), dt.Rows[i]["cl_id"].ToString(), "EDIT" };
                        dataGridView1.Rows.Add(row);

                    }
                    dataGridView1.Visible = true;

                }
                else
                {
                    dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                    MessageBox.Show("No data available");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code BINDGRID" + ex.Message);
            }
            finally
            {
                con.Close();

            }
        }


        private void bind_grid(int val, string search)
        {
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                DataTable dt = new DataTable();
                string query = "";
                if (val == 1)
                {
                    query = "select cl_id,cl_name,cl_add,cl_contact,st_name,cl_code,cl_gstin from tbl_client" + LoginInfo.loginId + "  as a join tbl_state as b ";
                    query += " on a.cl_code=b.st_code where cl_name like '%" + search + "%'";
                }
                else
                {
                    query = "select cl_id,cl_name,cl_add,cl_contact,st_name,cl_code,cl_gstin from tbl_client" + LoginInfo.loginId + "  as a join tbl_state as b ";
                    query += " on a.cl_code=b.st_code where cl_gstin='" + search + "'";
                }
                SqlDataAdapter adpt = new SqlDataAdapter(query, con);
                con.Open();
                adpt.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].Name = "grid_name";
                    dataGridView1.Columns[0].HeaderText = "Name";

                    dataGridView1.Columns[1].Name = "grid_add";
                    dataGridView1.Columns[1].HeaderText = "Address";

                    dataGridView1.Columns[2].Name = "grid_contact";
                    dataGridView1.Columns[2].HeaderText = "Contact";

                    dataGridView1.Columns[3].Name = "grid_state";
                    dataGridView1.Columns[3].HeaderText = "State";

                    dataGridView1.Columns[4].Name = "grid_code";
                    dataGridView1.Columns[4].HeaderText = "Code";

                    dataGridView1.Columns[5].Name = "grid_gstin";
                    dataGridView1.Columns[5].HeaderText = "GSTIN";

                    dataGridView1.Columns[6].Name = "grid_clid";
                    dataGridView1.Columns[6].HeaderText = "CLID";
                    dataGridView1.Columns[6].Visible = false;

                    DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                    editButton.FlatStyle = FlatStyle.Popup;
                    editButton.Text = "Edit";
                    editButton.HeaderText = "Edit";
                    dataGridView1.Columns.Add(editButton);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string[] row = new string[] { dt.Rows[i]["cl_name"].ToString(), dt.Rows[i]["cl_add"].ToString(), dt.Rows[i]["cl_contact"].ToString(), dt.Rows[i]["st_name"].ToString(), dt.Rows[i]["cl_code"].ToString(), dt.Rows[i]["cl_gstin"].ToString(), dt.Rows[i]["cl_id"].ToString(), "EDIT" };
                        dataGridView1.Rows.Add(row);

                    }
                    dataGridView1.Visible = true;

                }
                else
                {
                    dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                    MessageBox.Show("No data available");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code CLINXCH" + ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void view_customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_gstDataSet.tbl_company' table. You can move, or remove it, as needed.
            //this.tbl_companyTableAdapter.Fill(this.db_gstDataSet.tbl_company);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.tbl_companyTableAdapter.FillBy(this.db_gstDataSet.tbl_company);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                dataGridView1.Visible = false;

                if (txt_search.Text == "")
                {
                    dataGridView1.DataSource = null;
                    this.dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                    MessageBox.Show("Please enter some text");
                }
                else
                {
                    if (radio_name.Checked == true)
                    {
                        bind_grid(1, txt_search.Text.ToString().Replace("'", ""));
                    }
                    else
                    {
                        bind_grid(0, txt_search.Text.ToString().Replace("'", ""));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code CLINXCH" + ex.Message);
            }
            finally
            {
             //   con.Close();

            }
        }

        private void radio_name_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            txt_search.Text = "";
        }

        private void radio_gstin_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            txt_search.Text = "";
        }

        public static int clid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                    Edit_client edit_customer = new Edit_client();
                    clid = Convert.ToInt16(cell.OwningRow.Cells["grid_clid"].Value);
                    edit_customer.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code CLINXCH" + ex.Message);
            }
            finally
            {
             //   con.Close();

            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test tst = new test();
            tst.Show();
            this.Hide();
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
