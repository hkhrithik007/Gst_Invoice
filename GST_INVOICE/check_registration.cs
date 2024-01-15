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
    class check_registration
    {
        public static int company_registration_check()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            int count = 0;
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select * from tbl_company ", con);
                DataTable dt = new DataTable();
                con.Open();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Cannot register more than 1 company!!You can only edit");
                    count = 1;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                count = 1;
            }
            finally
            {
                con.Close();


            }
            return count;

        }

        public static int check_if_registered()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            int count = 0;
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter("select * from tbl_company", con);
                DataTable dt = new DataTable();
                con.Open();
                adpt.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Please Register Your Company");
                    count = 1;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                count = 1;
            }
            finally
            {
                con.Close();

            }
            return count;
        }
    }
}
