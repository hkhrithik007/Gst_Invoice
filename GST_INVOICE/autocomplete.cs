using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_INVOICE
{
    class autocomplete
    {

        public static AutoCompleteStringCollection autofill_data(int val)
        {
            AutoCompleteStringCollection scAutoComplete = new AutoCompleteStringCollection();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());

            //  SqlDataAdapter daUsers = new SqlDataAdapter("select distinct inv_part from tbl_invoice", con);
            // DataSet ds = new DataSet();
            // daUsers.Fill(ds, "UserProfile");
            //Display PKUserId,UserName in the DataGridView
            // dataGridView1.DataSource = ds.Tables["UserProfile"];
            string query = "";
            
            if (val == 0)
            {
                query = "select distinct inv_part from tbl_invoice" + LoginInfo.loginId + " ";
            }
            if(val==1)
            {
                query = "select distinct inv_hsn from tbl_invoice" + LoginInfo.loginId + " ";
            }
            if (val == 2) { query = "select distinct inv_qty from tbl_invoice" + LoginInfo.loginId + " "; }
            if (val == 3) { query = "select distinct inv_unit from tbl_invoice" + LoginInfo.loginId + " "; }
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter adpt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for(int i=0;i<=dt.Rows.Count-1;i++){
                    scAutoComplete.Add(dt.Rows[i][0].ToString());
                }
            }
            //SqlDataReader dr;
            //con.Open();
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    scAutoComplete.Add(Convert.ToString(dr.GetString(0)));
            //}
            con.Close();
            return scAutoComplete;

        }
    }
}
