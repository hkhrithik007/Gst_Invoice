using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_INVOICE
{
    class change_password
    {
        public static void change(int cid, string pass)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string update = "update tbl_company set c_pass='" + pass + "' where c_id=" + cid;
                SqlCommand cmd = new SqlCommand(update, con);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Password Changed Succesfully!You have to LOGIN again");
                }
                else
                {
                    MessageBox.Show("ERROR!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PASSWORD CHANGE ERROR" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
