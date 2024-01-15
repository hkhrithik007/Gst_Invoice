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
using System.Data.OleDb;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Configuration;

namespace GST_INVOICE
{
    public partial class invoice : Form
    {
        //public static num_to_words change = new num_to_words();
        public invoice()
        {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = 1;
            txt_date.Text =Convert.ToDateTime(DateTime.Today.ToShortDateString()).ToString("dd MMM yyyy");
            lbl_inv_hid_date.Text = DateTime.Today.ToShortDateString();

        }

        private void invoice_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                fill_combo_gst(0);
                fill_combo_cgst(0);
                fill_combo_igst(0);
                fill_reserve_combo();
                //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");
                string get_inv_no = "select top 1 inv_start from tbl_company where c_id= "+LoginInfo.loginId+" ";
                string get_client = "select * from tbl_client" + LoginInfo.loginId + " ";
                string get_invoice = "select top 1 invoice_no from tbl_invoice" + LoginInfo.loginId + "  order by invoice_no desc";
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(get_client, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    combo_client.Items.Clear();
                    DataRow dr;
                    dr = dt.NewRow();
                    dr.ItemArray = new object[] { 0, "--Select client--" };
                    dt.Rows.InsertAt(dr, 0);
                    combo_client.ValueMember = "cl_id";
                    combo_client.DisplayMember = "cl_name";
                    combo_client.DataSource = dt;
                }

                SqlDataAdapter adpt_inv = new SqlDataAdapter(get_invoice, con);
                DataTable dt_inv = new DataTable();
                adpt_inv.Fill(dt_inv);
                if (dt_inv.Rows.Count > 0)
                {
                    if ((Convert.ToInt16(dt_inv.Rows[0]["invoice_no"].ToString()) + 1) < 10)
                    {
                        txt_invoice_no.Text = "00" + Convert.ToString(Convert.ToInt16(dt_inv.Rows[0]["invoice_no"].ToString()) + 1);
                    }
                    else if ((Convert.ToInt16(dt_inv.Rows[0]["invoice_no"].ToString()) + 1) < 100) { txt_invoice_no.Text = "0" + Convert.ToString(Convert.ToInt16(dt_inv.Rows[0]["invoice_no"].ToString()) + 1); }
                    else { txt_invoice_no.Text = Convert.ToString(Convert.ToInt16(dt_inv.Rows[0]["invoice_no"].ToString()) + 1); }
                }
                else
                {
                    SqlDataAdapter adpt_inv_start = new SqlDataAdapter(get_inv_no, con);
                    DataTable dt_inv_start = new DataTable();
                    adpt_inv_start.Fill(dt_inv_start);
                    if (dt_inv_start.Rows.Count > 0)
                    {
                        if (Convert.ToInt16(dt_inv_start.Rows[0][0].ToString()) < 0) {
                            txt_invoice_no.Text = "001";
                        }
                        else
                        {
                           // txt_invoice_no.Text = dt_inv_start.Rows[0][0].ToString();
                            if ((Convert.ToInt16(dt_inv_start.Rows[0][0].ToString())) < 10)
                            {
                                txt_invoice_no.Text = "00" + Convert.ToString(Convert.ToInt16(dt_inv_start.Rows[0][0].ToString()));
                            }
                            else if ((Convert.ToInt16(dt_inv_start.Rows[0][0].ToString())) < 100) { txt_invoice_no.Text = "0" + Convert.ToString(Convert.ToInt16(dt_inv_start.Rows[0][0].ToString()) ); }
                            else { txt_invoice_no.Text = Convert.ToString(Convert.ToInt16(dt_inv_start.Rows[0][0].ToString()) ); }
                        }
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code INVLOD" + ex.Message);
            }
            finally
            {
                con.Close();

            }
            //con.Close();
        }

        private void fill_combo_gst(int row)
        {
            //dataGridView1.cel
            string query = "select * from tbl_rates where rate_type=1 order by rate_val asc";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView1[8, row];
                comboCell.Items.Clear();
                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, 0 };
                dt.Rows.InsertAt(dr, 0);
                comboCell.ValueMember = "rate_val";
                comboCell.DisplayMember = "rate_val";
                comboCell.DataSource = dt;
                //comboCell.Items.sel   
            }
            //comboCell.Items.AddRange(;
        }


        private void fill_combo_cgst(int row)
        {
            //dataGridView1.cel
            string query = "select * from tbl_rates where rate_type=2 order by rate_val asc";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView1[10, row];
                comboCell.Items.Clear();
                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, 0 };
                dt.Rows.InsertAt(dr, 0);
                comboCell.ValueMember = "rate_val";
                comboCell.DisplayMember = "rate_val";
                comboCell.DataSource = dt;
                //comboCell.Items.sel   
            }
            //comboCell.Items.AddRange(;
        }
        private void fill_combo_igst(int row)
        {
            //dataGridView1.cel
            string query = "select * from tbl_rates where rate_type=3 order by rate_val asc";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView1[12, row];
                comboCell.Items.Clear();
                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, 0 };
                dt.Rows.InsertAt(dr, 0);
                comboCell.ValueMember = "rate_val";
                comboCell.DisplayMember = "rate_val";
                comboCell.DataSource = dt;
                //comboCell.Items.sel   
            }
            //comboCell.Items.AddRange(;
        }







        private void combo_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                if (combo_client.SelectedIndex == 0)
                {
                    // MessageBox.Show("Please Select");
                    panel_invoice.Visible = false;
                    lbl_gstin.Text = "";
                    lbl_address.Text = "";
                }
                else
                {
                    textBox1.Text = "";
                    //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");

                    string get_client = "select a.cl_id,a.cl_name,a.cl_gstin,a.cl_add,b.st_name,b.st_code from tbl_client" + LoginInfo.loginId + "  as a join tbl_state as b on a.cl_code=b.st_code where cl_id='" + combo_client.SelectedValue + "'";
                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(get_client, con);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        panel_invoice.Visible = true;
                        c_id_hidden.Text = dt.Rows[0]["cl_id"].ToString();
                        lbl_gstin.Text = "GSTIN:- " + dt.Rows[0]["cl_gstin"].ToString();
                        lbl_cust_name.Text = "NAME:- " + dt.Rows[0]["cl_name"].ToString();
                        lbl_address.Text = "ADDRESS:- " + dt.Rows[0]["cl_add"].ToString() + " STATE:- " + dt.Rows[0]["st_name"].ToString() + " STATE CODE:- " + dt.Rows[0]["st_code"].ToString();
                    }
                    else
                    {
                        panel_invoice.Visible = false;
                        lbl_gstin.Text = "No Data Found";
                        lbl_cust_name.Text = "";
                        lbl_address.Text = "";
                    }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                lbl_gstin.Text = "";
                lbl_address.Text = "";

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                if (textBox1.Text == "") { MessageBox.Show("Enter some text"); }
                else
                {
                    combo_client.SelectedIndex = 0;
                    //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");

                    string get_client = "select a.cl_id,a.cl_name,a.cl_gstin,a.cl_add,b.st_name,b.st_code from tbl_client" + LoginInfo.loginId + "  as a join tbl_state as b on a.cl_code=b.st_code where cl_gstin='" + textBox1.Text.ToString() + "'";
                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(get_client, con);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        panel_invoice.Visible = true;
                        c_id_hidden.Text = dt.Rows[0]["cl_id"].ToString();
                        lbl_gstin.Text = "GSTIN:- " + dt.Rows[0]["cl_gstin"].ToString();
                        lbl_cust_name.Text = "NAME:- " + dt.Rows[0]["cl_name"].ToString();
                        lbl_address.Text = "ADDRESS:- " + dt.Rows[0]["cl_add"].ToString() + " STATE:- " + dt.Rows[0]["st_name"].ToString() + " STATE CODE:- " + dt.Rows[0]["st_code"].ToString();
                    }
                    else
                    {
                        panel_invoice.Visible = false;
                        lbl_gstin.Text = "No Data Found";
                        lbl_cust_name.Text = "";
                        lbl_address.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code INVSEARHCL" + ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 1)
                {
                    var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                    // total amount calculation
                    if (cell.OwningColumn.Name == "grid_qty" || cell.OwningColumn.Name == "grid_rate")
                    {
                        //update the Amount cell
                        cell.OwningRow.Cells["grid_value"].Value = Convert.ToDecimal(cell.OwningRow.Cells["grid_qty"].Value) *
                                                              Convert.ToDecimal(cell.OwningRow.Cells["grid_rate"].Value);
                        //get_sum();
                    }

                    //Taxable Value calculation
                    if (cell.OwningColumn.Name == "grid_disc" || cell.OwningColumn.Name == "grid_value" || cell.OwningColumn.Name == "grid_rate")
                    {
                        cell.OwningRow.Cells["grid_tax_val"].Value = Convert.ToDecimal(cell.OwningRow.Cells["grid_value"].Value) -
                                                                              Convert.ToDecimal(cell.OwningRow.Cells["grid_disc"].Value);
                        //get_sum();
                    }


                    //SGST Value calculation
                    if (cell.OwningColumn.Name == "grid_disc" || cell.OwningColumn.Name == "grid_gst_Rate" || cell.OwningColumn.Name == "grid_rate")
                    {
                        cell.OwningRow.Cells["grid_gst_amt"].Value = Convert.ToDecimal(cell.OwningRow.Cells["grid_tax_val"].Value) * Convert.ToDecimal(
                                                                              Convert.ToDecimal(cell.OwningRow.Cells["grid_gst_Rate"].Value) / 100);
                        //get_sum();
                    }

                    //CGST Value calculation
                    if (cell.OwningColumn.Name == "grid_disc" || cell.OwningColumn.Name == "grid_cgst_rate" || cell.OwningColumn.Name == "grid_rate")
                    {
                        cell.OwningRow.Cells["grid_cgst_amt"].Value = Convert.ToDecimal(cell.OwningRow.Cells["grid_tax_val"].Value) * Convert.ToDecimal(
                                                                              Convert.ToDecimal(cell.OwningRow.Cells["grid_cgst_Rate"].Value) / 100);
                        // get_sum();
                    }

                    //ICGST Value calculation
                    if (cell.OwningColumn.Name == "grid_disc" || cell.OwningColumn.Name == "grid_igst_rate" || cell.OwningColumn.Name == "grid_rate")
                    {
                        cell.OwningRow.Cells["grid_igst_amt"].Value = Convert.ToDecimal(cell.OwningRow.Cells["grid_tax_val"].Value) * Convert.ToDecimal(
                                                                              Convert.ToDecimal(cell.OwningRow.Cells["grid_igst_Rate"].Value) / 100);
                        // get_sum();
                    }
                    if (cell.OwningColumn.Name == "grid_tax_val")
                    {
                        get_sum();
                    }
                    if (cell.OwningColumn.Name == "grid_gst_amt")
                    {
                        sgst_sum();
                    }
                    if (cell.OwningColumn.Name == "grid_cgst_amt")
                    {
                        cgst_sum();
                    }
                    if (cell.OwningColumn.Name == "grid_igst_amt")
                    {
                        igst_sum();
                    }

                    txt_grand.Text = Convert.ToString(Convert.ToDecimal(txt_before_tax.Text) + Convert.ToDecimal(txt_cgst.Text) + Convert.ToDecimal(txt_igst.Text) + Convert.ToDecimal(txt_sgst.Text) + Convert.ToDecimal(txt_other.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code INVNEWCELLCH" + ex.Message);
            }
            finally
            {
                // con.Close();

            }
        }
        private void get_sum()
        {
            txt_before_tax.Text = "0";
            txt_grand.Text = "0";
            if (dataGridView1.RowCount > 1)
            {
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    if (Convert.ToDecimal(dataGridView1["grid_tax_val", i].Value) > 0)
                    {
                        txt_before_tax.Text = Convert.ToString(Convert.ToDecimal(txt_before_tax.Text.ToString()) + Convert.ToDecimal(dataGridView1["grid_tax_val", i].Value));
                    }

                }
            }

        }
        private void sgst_sum()
        {
            txt_sgst.Text = "0";
            if (dataGridView1.RowCount > 1)
            {
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    if (Convert.ToDecimal(dataGridView1["grid_gst_amt", i].Value) > 0)
                    {
                        txt_sgst.Text = Convert.ToString(Convert.ToDecimal(txt_sgst.Text.ToString()) + Convert.ToDecimal(dataGridView1["grid_gst_amt", i].Value));
                    }

                }
            }
        }
        private void cgst_sum()
        {
            txt_cgst.Text = "0";
            if (dataGridView1.RowCount > 1)
            {
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    if (Convert.ToDecimal(dataGridView1["grid_cgst_amt", i].Value) > 0)
                    {
                        txt_cgst.Text = Convert.ToString(Convert.ToDecimal(txt_cgst.Text.ToString()) + Convert.ToDecimal(dataGridView1["grid_cgst_amt", i].Value));
                    }

                }
            }
        }
        private void igst_sum()
        {
            txt_igst.Text = "0";
            if (dataGridView1.RowCount > 1)
            {
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    if (Convert.ToDecimal(dataGridView1["grid_igst_amt", i].Value) > 0)
                    {
                        txt_igst.Text = Convert.ToString(Convert.ToDecimal(txt_igst.Text.ToString()) + Convert.ToDecimal(dataGridView1["grid_igst_amt", i].Value));
                    }

                }
            }
        }
        private void fill_reserve_combo()
        {
            combo_reserve.Items.Clear();

            combo_reserve.DisplayMember = "Text";
            combo_reserve.ValueMember = "Value";

            var items = new[] { new { Text = "NO", Value = "NO" }, new { Text = "YES", Value = "YES" } };

            combo_reserve.DataSource = items;
        }

        private void txt_other_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void txt_date_Leave(object sender, EventArgs e)
        {
            if (!monthCalendar1.Focused)
                monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            txt_date.Text = Convert.ToDateTime(monthCalendar.SelectionStart.ToShortDateString()).ToString("dd MMM yyyy");
            lbl_inv_hid_date.Text = monthCalendar.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            monthCalendar1.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (insert_record() == 1)
            {
                GeneratePDF.Generate(Convert.ToInt32(txt_invoice_no.Text));
                search_invoice search = new search_invoice();
                search.Show();
                this.Hide();
            }
        }




        //Insert Records
        public int insert_record()
        {
            int success = 0;
            if (dataGridView1.RowCount > 1)
            {

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    //string constring = @"Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30";
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString()))
                    {
                        string query = "insert into tbl_invoice" + LoginInfo.loginId + " (inv_part,inv_hsn,inv_qty,inv_unit,inv_rate,inv_value,inv_disc,";
                        query += "inv_tax_val,inv_sgst_rate,inv_sgst_amt,inv_cgst_rate,inv_cgst_amt,inv_igst_rate,inv_igst_amt";
                        query += ",inv_cid,inv_consignee,inv_date,inv_befor_tax,inv_total_gst,inv_total_cgst,inv_total_igst";
                        query += ",inv_other_charge,inv_grand_total,invoice_no,gst_reserve)";
                        query += "values(@inv_part,@inv_hsn,@inv_qty,@inv_unit,@inv_rate,@inv_value,@inv_disc,";
                        query += "@inv_tax_val,@inv_sgst_rate,@inv_sgst_amt,@inv_cgst_rate,@inv_cgst_amt,@inv_igst_rate,@inv_igst_amt";
                        query += ",@inv_cid,@inv_consignee,@inv_date,@inv_befor_tax,@inv_total_gst,@inv_total_cgst";
                        query += ",@inv_total_igst,@inv_other_charge,@inv_grand_total,@invoice_no,@gst_reserve)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {

                            if (dataGridView1["grid_part", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_part", "NA"); }
                            else { cmd.Parameters.AddWithValue("@inv_part", dataGridView1["grid_part", i].Value.ToString()); }

                            if (dataGridView1["grid_hsn", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_hsn", "NA"); }
                            else { cmd.Parameters.AddWithValue("@inv_hsn", dataGridView1["grid_hsn", i].Value.ToString()); }

                            if (dataGridView1["grid_qty", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_qty", 0); }
                            else { cmd.Parameters.AddWithValue("@inv_qty", Convert.ToInt16(dataGridView1["grid_qty", i].Value.ToString())); }

                            if (dataGridView1["grid_unit", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_unit", "NA"); }
                            else { cmd.Parameters.AddWithValue("@inv_unit", dataGridView1["grid_unit", i].Value.ToString()); }

                            if (dataGridView1["grid_rate", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_rate", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_rate", dataGridView1["grid_rate", i].Value.ToString()); }

                            if (dataGridView1["grid_value", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_value", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_value", dataGridView1["grid_value", i].Value.ToString()); }

                            if (dataGridView1["grid_disc", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_disc", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_disc", dataGridView1["grid_disc", i].Value.ToString()); }

                            if (dataGridView1["grid_tax_val", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_tax_val", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_tax_val", dataGridView1["grid_tax_val", i].Value.ToString()); }

                            if (dataGridView1["grid_gst_rate", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_sgst_rate", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_sgst_rate", dataGridView1["grid_gst_rate", i].Value.ToString()); }

                            if (dataGridView1["grid_gst_amt", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_sgst_amt", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_sgst_amt", dataGridView1["grid_gst_amt", i].Value.ToString()); }

                            if (dataGridView1["grid_cgst_rate", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_cgst_rate", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_cgst_rate", dataGridView1["grid_cgst_rate", i].Value.ToString()); }

                            if (dataGridView1["grid_cgst_amt", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_cgst_amt", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_cgst_amt", dataGridView1["grid_cgst_amt", i].Value.ToString()); }

                            if (dataGridView1["grid_igst_rate", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_igst_rate", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_igst_rate", dataGridView1["grid_igst_rate", i].Value.ToString()); }

                            if (dataGridView1["grid_igst_amt", i].Value == null)
                            { cmd.Parameters.AddWithValue("@inv_igst_amt", "0"); }
                            else { cmd.Parameters.AddWithValue("@inv_igst_amt", dataGridView1["grid_igst_amt", i].Value.ToString()); }

                            cmd.Parameters.AddWithValue("@inv_cid", Convert.ToInt16(c_id_hidden.Text));
                            cmd.Parameters.AddWithValue("@inv_consignee", Convert.ToInt16(c_id_hidden.Text));
                            cmd.Parameters.AddWithValue("@inv_date", lbl_inv_hid_date.Text);
                            cmd.Parameters.AddWithValue("@inv_befor_tax", txt_before_tax.Text);
                            cmd.Parameters.AddWithValue("@inv_total_gst", txt_sgst.Text);
                            cmd.Parameters.AddWithValue("@inv_total_cgst", txt_cgst.Text);
                            cmd.Parameters.AddWithValue("@inv_total_igst", txt_igst.Text);
                            cmd.Parameters.AddWithValue("@inv_other_charge", txt_other.Text);
                            cmd.Parameters.AddWithValue("@inv_grand_total", txt_grand.Text);
                            cmd.Parameters.AddWithValue("@invoice_no", Convert.ToInt32(txt_invoice_no.Text));
                            cmd.Parameters.AddWithValue("@gst_reserve", combo_reserve.SelectedValue.ToString());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                    }
                }
                MessageBox.Show("Records inserted.");
                success = 1;
            }
            return success;
        }






        private void txt_grand_TextChanged(object sender, EventArgs e)
        {
            lbl_amt_word.Text = Convert.ToString(num_to_words.convert_number(Convert.ToDouble(txt_grand.Text)));
        }

        private void txt_other_Leave(object sender, EventArgs e)
        {
            if (txt_other.Text != "")
            {

                if (txt_other.Text.ToString().Contains("-"))
                {
                    decimal big = (Convert.ToDecimal(txt_before_tax.Text) + Convert.ToDecimal(txt_cgst.Text) + Convert.ToDecimal(txt_igst.Text) + Convert.ToDecimal(txt_sgst.Text));
                    decimal small = Convert.ToDecimal(txt_other.Text.ToString());

                    txt_grand.Text = (Convert.ToString(Math.Abs(big) - Math.Abs(small)));
                }
                else
                {
                    txt_grand.Text = Convert.ToString(Convert.ToDecimal(txt_before_tax.Text) + Convert.ToDecimal(txt_cgst.Text) + Convert.ToDecimal(txt_igst.Text) + Convert.ToDecimal(txt_sgst.Text) + Convert.ToDecimal(txt_other.Text));
                }

                lbl_amt_word.Text = Convert.ToString(num_to_words.convert_number(Convert.ToDouble(txt_grand.Text)));
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.ShowDialog();
            openfiledialog1.Filter = "allfiles|*.xls";
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            invoice new_in = new invoice();
            new_in.Show();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            txt_date.Text = Convert.ToDateTime(monthCalendar.SelectionStart.ToShortDateString()).ToString("dd MMM yyyy");
           lbl_inv_hid_date.Text = monthCalendar.SelectionStart.ToShortDateString();
            //monthCalendar1.Visible = false;
        }

        private void btn_pdf_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                if (cell.OwningColumn.Name == "grid_del_row")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {

                        //cell.OwningRow.r
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    }
                    else { MessageBox.Show("Error!..."); }
                }

            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            fill_combo_gst(e.RowIndex);
            fill_combo_cgst(e.RowIndex);
            fill_combo_igst(e.RowIndex);
        }

        private void txt_date_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void txt_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0 && e.Control is TextBox)
            {
                TextBox txtUserName = (TextBox)e.Control;
                txtUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtUserName.AutoCompleteCustomSource = autocomplete.autofill_data(0);
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 1 && e.Control is TextBox)
            {
                TextBox txtUserName = (TextBox)e.Control;
                txtUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtUserName.AutoCompleteCustomSource = autocomplete.autofill_data(1);
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 2 && e.Control is TextBox)
            {
                TextBox txtUserName = (TextBox)e.Control;
                txtUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtUserName.AutoCompleteCustomSource = autocomplete.autofill_data(2);
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 3 && e.Control is TextBox)
            {
                TextBox txtUserName = (TextBox)e.Control;
                txtUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtUserName.AutoCompleteCustomSource = autocomplete.autofill_data(3);
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