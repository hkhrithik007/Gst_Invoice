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
    public partial class edit_invoice : Form
    {
        public edit_invoice()
        {
            InitializeComponent();
        }

        private void edit_invoice_Load(object sender, EventArgs e)
        {
            fill_combo_gst(0);
            fill_combo_cgst(0);
            fill_combo_igst(0);
            fill_invoice();
            fill_reserve_combo();
           
        }

        private void fill_invoice()
        {
            // SqlConnection con = new SqlConnection("Data Source=RB-PC;Initial Catalog=db_gst;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string get_invoice = "select * from tbl_invoice" + LoginInfo.loginId + "  as a join tbl_client" + LoginInfo.loginId + "  as b on a.inv_cid=b.cl_id where invoice_no=" + search_invoice.invoice_id;
                string get_bill = "select inv_part,inv_hsn,inv_qty,inv_unit,inv_rate,inv_value,inv_disc,inv_tax_val,inv_sgst_rate,inv_sgst_amt,inv_cgst_rate,inv_cgst_amt,inv_igst_rate,inv_igst_amt,inv_no from tbl_invoice" + LoginInfo.loginId + "  where invoice_no=" + search_invoice.invoice_id;
                SqlDataAdapter adpt = new SqlDataAdapter(get_invoice, con);
                DataTable dt = new DataTable();
                SqlDataAdapter fill_bill = new SqlDataAdapter(get_bill, con);
                DataTable bill_dt = new DataTable();
                con.Open();
                adpt.Fill(dt);
                fill_bill.Fill(bill_dt);
                // con.Close();
                if ((Convert.ToInt16(dt.Rows[0]["invoice_no"].ToString())) < 10)
                {
                    txt_invoice_no.Text = "00" + Convert.ToString(Convert.ToInt16(dt.Rows[0]["invoice_no"].ToString()));
                }
                else if ((Convert.ToInt16(dt.Rows[0]["invoice_no"].ToString())) < 100) { txt_invoice_no.Text = "0" + Convert.ToString(Convert.ToInt16(dt.Rows[0]["invoice_no"].ToString())); }
                else { txt_invoice_no.Text = Convert.ToString(Convert.ToInt16(dt.Rows[0]["invoice_no"].ToString())); }

                if (dt.Rows.Count > 0)
                {
                    txt_date.Text =Convert.ToDateTime(dt.Rows[0]["inv_date"].ToString()).ToString("dd MMM yyyy");
                    lbl_inv_hid_date.Text = dt.Rows[0]["inv_date"].ToString();
                    c_id_hidden.Text = dt.Rows[0]["inv_cid"].ToString();
                    lbl_gstin.Text = "GSTIN :- " + dt.Rows[0]["cl_gstin"].ToString();
                    lbl_cust_name.Text = "NAME :- " + dt.Rows[0]["cl_name"].ToString();
                    lbl_address.Text = "ADDRESS :- " + dt.Rows[0]["cl_add"].ToString();
                    for (int i = 0; i < bill_dt.Rows.Count; i++)
                    {
                        //fill_combo_gst(i);
                       // fill_combo_cgst(i);
                        //fill_combo_igst(i);
                        //string[] row = new string[] { bill_dt.Rows[i][0].ToString(), bill_dt.Rows[i][1].ToString(), bill_dt.Rows[i][2].ToString(), bill_dt.Rows[i][3].ToString(), bill_dt.Rows[i][4].ToString(), bill_dt.Rows[i][5].ToString(), bill_dt.Rows[i][6].ToString(), bill_dt.Rows[i][7].ToString(), bill_dt.Rows[i][8].ToString(), bill_dt.Rows[i][9].ToString(), bill_dt.Rows[i][10].ToString(), bill_dt.Rows[i][11].ToString(), bill_dt.Rows[i][12].ToString(), bill_dt.Rows[i][13].ToString(), bill_dt.Rows[i][14].ToString(), "X" };
                        string[] row = new string[] { bill_dt.Rows[i][0].ToString(), bill_dt.Rows[i][1].ToString(), bill_dt.Rows[i][2].ToString(), bill_dt.Rows[i][3].ToString(), bill_dt.Rows[i][4].ToString(), bill_dt.Rows[i][5].ToString(), bill_dt.Rows[i][6].ToString(), bill_dt.Rows[i][7].ToString(), bill_dt.Rows[i][8].ToString(), bill_dt.Rows[i][9].ToString(), bill_dt.Rows[i][10].ToString(), bill_dt.Rows[i][11].ToString(), bill_dt.Rows[i][12].ToString(), bill_dt.Rows[i][13].ToString(), bill_dt.Rows[i][14].ToString(), "X" };
                        dataGridView1.Rows.Add(row);

                    }
                    // dataGridView1.DataSource = bill_dt;
                    txt_before_tax.Text = dt.Rows[0]["inv_befor_tax"].ToString();
                    txt_sgst.Text = dt.Rows[0]["inv_total_gst"].ToString();
                    txt_cgst.Text = dt.Rows[0]["inv_total_cgst"].ToString();
                    txt_igst.Text = dt.Rows[0]["inv_total_igst"].ToString();
                    txt_other.Text = dt.Rows[0]["inv_other_charge"].ToString();
                    txt_grand.Text = dt.Rows[0]["inv_grand_total"].ToString();
                    combo_reserve.SelectedValue = dt.Rows[0]["gst_reserve"].ToString();
                }
                lbl_amt_word.Text = Convert.ToString(num_to_words.convert_number(Convert.ToDouble(txt_grand.Text)));
                panel_invoice.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code FILLINV" + ex.Message);
            }
            finally
            {
                con.Close();
            }
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
        private void fill_reserve_combo()
        {
            combo_reserve.Items.Clear();

            combo_reserve.DisplayMember = "Text";
            combo_reserve.ValueMember = "Value";

            var items = new[] { new { Text = "NO", Value = "NO" }, new { Text = "YES", Value = "YES" } };

            combo_reserve.DataSource = items;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {


            update_records();

        }


        public void update_records()
        {
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string get_bill = "select inv_part,inv_hsn,inv_qty,inv_unit,inv_rate,inv_value,inv_disc,inv_tax_val,inv_sgst_rate,inv_sgst_amt,inv_cgst_rate,inv_cgst_amt,inv_igst_rate,inv_igst_amt,inv_no from tbl_invoice" + LoginInfo.loginId + "  where invoice_no=" + search_invoice.invoice_id;
                SqlDataAdapter adpt = new SqlDataAdapter(get_bill, con);
                DataTable dt = new DataTable();
                con.Open();
                adpt.Fill(dt);
                //con.Close();
                int flag = 0;
                if (dt.Rows.Count > 0 && dataGridView1.RowCount > 1)
                {

                    for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                    {


                        int i = 0;
                        while (i < dt.Rows.Count)
                        {
                            if (dataGridView1["grid_inv_id", j].Value == null) { }
                            else
                            {
                                if (dt.Rows[i]["inv_no"].ToString() == dataGridView1["grid_inv_id", j].Value.ToString())
                                {
                                    //MessageBox.Show("FOUND");
                                    flag = 1;
                                }
                            }
                            i++;
                        }
                        if (flag == 1) { update_row(Convert.ToInt32(dataGridView1["grid_inv_id", j].Value), j); flag = 0; }
                        else { insert_data(j); }

                    }
                    MessageBox.Show("Updated successfully");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code UPREC" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }





        public void update_row(int invoice, int i)
        {
            int success = 0;
            // string constring = @"Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString()))
            {
                try
                {
                    string query = "update tbl_invoice" + LoginInfo.loginId + "  set inv_part=@inv_part,inv_hsn=@inv_hsn,inv_qty=@inv_qty,inv_unit=@inv_unit";
                    query += ",inv_rate=@inv_rate,inv_value =@inv_value";
                    query += ",inv_disc=@inv_disc,inv_tax_val=@inv_tax_val,inv_sgst_rate=@inv_sgst_rate,inv_sgst_amt=@inv_sgst_amt,inv_cgst_rate=@inv_cgst_rate";
                    query += ",inv_cgst_amt=@inv_cgst_amt,inv_igst_rate=@inv_igst_rate,inv_igst_amt=@inv_igst_amt,inv_date=@inv_date";
                    query += ",inv_befor_tax=@inv_befor_tax,inv_total_gst=@inv_total_gst,inv_total_cgst=@inv_total_cgst,inv_total_igst=@inv_total_igst";
                    query += ",inv_other_charge=@inv_other_charge,inv_grand_total=@inv_grand_total,gst_reserve=@gst_reserve where inv_no=" + invoice;
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        if (dataGridView1["grid_part", i].Value == null)
                        { cmd.Parameters.AddWithValue("@inv_part", "NULL"); }
                        else { cmd.Parameters.AddWithValue("@inv_part", dataGridView1["grid_part", i].Value.ToString()); }

                        if (dataGridView1["grid_hsn", i].Value == null)
                        { cmd.Parameters.AddWithValue("@inv_hsn", "NULL"); }
                        else { cmd.Parameters.AddWithValue("@inv_hsn", dataGridView1["grid_hsn", i].Value.ToString()); }

                        if (dataGridView1["grid_qty", i].Value == null)
                        { cmd.Parameters.AddWithValue("@inv_qty", 0); }
                        else { cmd.Parameters.AddWithValue("@inv_qty", Convert.ToInt16(dataGridView1["grid_qty", i].Value.ToString())); }

                        if (dataGridView1["grid_unit", i].Value == null)
                        { cmd.Parameters.AddWithValue("@inv_unit", "0"); }
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

                        cmd.Parameters.AddWithValue("@inv_date", lbl_inv_hid_date.Text);
                        cmd.Parameters.AddWithValue("@inv_befor_tax", txt_before_tax.Text);
                        cmd.Parameters.AddWithValue("@inv_total_gst", txt_sgst.Text);
                        cmd.Parameters.AddWithValue("@inv_total_cgst", txt_cgst.Text);
                        cmd.Parameters.AddWithValue("@inv_total_igst", txt_igst.Text);
                        cmd.Parameters.AddWithValue("@inv_other_charge", txt_other.Text);
                        cmd.Parameters.AddWithValue("@inv_grand_total", txt_grand.Text);
                        cmd.Parameters.AddWithValue("@gst_reserve", combo_reserve.SelectedValue.ToString());
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0) { //success = 1; 
                        }

                        // con.Close();
                      
                    }
                    //return success;
                    }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Code UPINSROW" + ex.Message);
                }
                finally
                {
                    con.Close();
                 
                }

            }
        }

        public void insert_data(int i)
        {
            int success = 0;
            //string constring = @"Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString()))
            {
                try
                {
                    string query = "insert into tbl_invoice" + LoginInfo.loginId + " (inv_part,inv_hsn,inv_qty,inv_unit,inv_rate,inv_value,inv_disc,";
                    query += "inv_tax_val,inv_sgst_rate,inv_sgst_amt,inv_cgst_rate,inv_cgst_amt,inv_igst_rate,inv_igst_amt";
                    query += ",inv_cid,inv_consignee,inv_date,inv_befor_tax,inv_total_gst,inv_total_cgst,inv_total_igst";
                    query += ",inv_other_charge,inv_grand_total,invoice_no)";
                    query += "values(@inv_part,@inv_hsn,@inv_qty,@inv_unit,@inv_rate,@inv_value,@inv_disc,";
                    query += "@inv_tax_val,@inv_sgst_rate,@inv_sgst_amt,@inv_cgst_rate,@inv_cgst_amt,@inv_igst_rate,@inv_igst_amt";
                    query += ",@inv_cid,@inv_consignee,@inv_date,@inv_befor_tax,@inv_total_gst,@inv_total_cgst";
                    query += ",@inv_total_igst,@inv_other_charge,@inv_grand_total,@invoice_no)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        if (dataGridView1["grid_part", i].Value == null)
                        { cmd.Parameters.AddWithValue("@inv_part", "NULL"); }
                        else { cmd.Parameters.AddWithValue("@inv_part", dataGridView1["grid_part", i].Value.ToString()); }

                        if (dataGridView1["grid_hsn", i].Value == null)
                        { cmd.Parameters.AddWithValue("@inv_hsn", "NULL"); }
                        else { cmd.Parameters.AddWithValue("@inv_hsn", dataGridView1["grid_hsn", i].Value.ToString()); }

                        if (dataGridView1["grid_qty", i].Value == null)
                        { cmd.Parameters.AddWithValue("@inv_qty", 0); }
                        else { cmd.Parameters.AddWithValue("@inv_qty", Convert.ToInt16(dataGridView1["grid_qty", i].Value.ToString())); }

                        if (dataGridView1["grid_unit", i].Value == null)
                        { cmd.Parameters.AddWithValue("@inv_unit", "0"); }
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
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            //success = 1;
                        }
                        con.Close();
                        //return success;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Code UPINSREC" + ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }

            // MessageBox.Show("Records inserted.");
        }







        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error Code INVCELLCH" + ex.Message);
                }
                finally
                {
                    //con.Close();

                }
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

        private void txt_date_Enter(object sender, EventArgs e)
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
            txt_date.Text =Convert.ToDateTime(monthCalendar.SelectionStart.ToShortDateString()).ToString("dd MMM yyyy");
            lbl_inv_hid_date.Text = monthCalendar.SelectionStart.ToShortDateString();
            monthCalendar.Visible = false;
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            monthCalendar1.Visible = false;
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            txt_date.Text = Convert.ToDateTime(monthCalendar.SelectionStart.ToShortDateString()).ToString("dd MMM yyyy");
            lbl_inv_hid_date.Text = monthCalendar.SelectionStart.ToShortDateString();

            //monthCalendar1.Visible = false;
        }

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
                    if (cell.OwningColumn.Name == "grid_del_row")
                    {
                        var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                   "Confirm Delete!!",
                                   MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {

                            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30");

                            string del_query = "delete from tbl_invoice" + LoginInfo.loginId + "  where inv_no=" + Convert.ToInt32(cell.OwningRow.Cells["grid_inv_id"].Value.ToString());
                            con.Open();
                            SqlCommand cmd = new SqlCommand(del_query, con);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                            }
                            else { MessageBox.Show("Error"); }
                            //con.Close();
                        }
                        else { MessageBox.Show("Error!..."); }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code UPINVCELCLIK" + ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            fill_combo_gst(e.RowIndex);
            fill_combo_cgst(e.RowIndex);
            fill_combo_igst(e.RowIndex);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void txt_date_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = true;
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

    }
}
