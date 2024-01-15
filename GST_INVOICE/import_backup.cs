using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_INVOICE
{
    class import_backup
    {
        public static void import(string path)
        {
            // int success = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                //string path = textfilepath.Text;

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
                        string query = "SET IDENTITY_INSERT tbl_invoice  ON if not exists(select inv_no from tbl_invoice where inv_no=" + Data.Rows[i][0].ToString() + ")";
                        query += "  insert into tbl_invoice(inv_no,inv_part,inv_hsn,inv_qty,inv_unit,inv_rate,inv_value,inv_disc,";
                        query += "inv_tax_val,inv_sgst_rate,inv_sgst_amt,inv_cgst_rate,inv_cgst_amt,inv_igst_rate,inv_igst_amt";
                        query += ",inv_cid,inv_consignee,inv_date,inv_befor_tax,inv_total_gst,inv_total_cgst,inv_total_igst";
                        query += ",inv_other_charge,inv_grand_total,invoice_no,flag,gst_reserve)";
                        query += "";
                        query += "values(@inv_no,@inv_part,@inv_hsn,@inv_qty,@inv_unit,@inv_rate,@inv_value,@inv_disc,";
                        query += "@inv_tax_val,@inv_sgst_rate,@inv_sgst_amt,@inv_cgst_rate,@inv_cgst_amt,@inv_igst_rate,@inv_igst_amt";
                        query += ",@inv_cid,@inv_consignee,@inv_date,@inv_befor_tax,@inv_total_gst,@inv_total_cgst";
                        query += ",@inv_total_igst,@inv_other_charge,@inv_grand_total,@invoice_no,@flag,@gst_reserve) SET IDENTITY_INSERT tbl_invoice OFF";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@inv_no", Convert.ToInt16(Data.Rows[i][0].ToString()));
                        cmd.Parameters.AddWithValue("@inv_part", Data.Rows[i][1].ToString());
                        cmd.Parameters.AddWithValue("@inv_hsn", Data.Rows[i][2].ToString());
                        cmd.Parameters.AddWithValue("@inv_qty",Convert.ToInt16(Data.Rows[i][3].ToString()));
                        cmd.Parameters.AddWithValue("@inv_unit", Data.Rows[i][4].ToString());
                        cmd.Parameters.AddWithValue("@inv_rate", Data.Rows[i][5].ToString());
                        cmd.Parameters.AddWithValue("@inv_value", Data.Rows[i][6].ToString());
                        cmd.Parameters.AddWithValue("@inv_disc", Data.Rows[i][7].ToString());
                        cmd.Parameters.AddWithValue("@inv_tax_val", Data.Rows[i][8].ToString());
                        cmd.Parameters.AddWithValue("@inv_sgst_rate", Data.Rows[i][9].ToString());
                        cmd.Parameters.AddWithValue("@inv_sgst_amt", Data.Rows[i][10].ToString());
                        cmd.Parameters.AddWithValue("@inv_cgst_rate", Data.Rows[i][11].ToString());
                        cmd.Parameters.AddWithValue("@inv_cgst_amt", Data.Rows[i][12].ToString());
                        cmd.Parameters.AddWithValue("@inv_igst_rate", Data.Rows[i][13].ToString());
                        cmd.Parameters.AddWithValue("@inv_igst_amt", Data.Rows[i][14].ToString());
                        cmd.Parameters.AddWithValue("@inv_cid",Convert.ToInt16(Data.Rows[i][15].ToString()));
                        cmd.Parameters.AddWithValue("@inv_consignee",Convert.ToInt16(Data.Rows[i][16].ToString()));
                        cmd.Parameters.AddWithValue("@inv_date", Data.Rows[i][17].ToString());
                        cmd.Parameters.AddWithValue("@inv_befor_tax", Data.Rows[i][18].ToString());
                        cmd.Parameters.AddWithValue("@inv_total_gst", Data.Rows[i][19].ToString());
                        cmd.Parameters.AddWithValue("@inv_total_cgst", Data.Rows[i][20].ToString());
                        cmd.Parameters.AddWithValue("@inv_total_igst", Data.Rows[i][21].ToString());
                        cmd.Parameters.AddWithValue("@inv_other_charge", Data.Rows[i][22].ToString());
                        cmd.Parameters.AddWithValue("@inv_grand_total", Data.Rows[i][23].ToString());
                        cmd.Parameters.AddWithValue("@invoice_no",Convert.ToInt16(Data.Rows[i][24].ToString()));
                        cmd.Parameters.AddWithValue("@flag",Convert.ToInt16(Data.Rows[i][25].ToString()));
                        cmd.Parameters.AddWithValue("@gst_reserve", Data.Rows[i][26].ToString());

                        cmd.ExecuteNonQuery();
                    }
                    //con.Close();
                    MessageBox.Show("UPLOAD SUCCESSFULLY");
                    //success = 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload ERROR" + ex.Message);
            }
            finally
            {
                con.Close();

            }

        }
    }
}
