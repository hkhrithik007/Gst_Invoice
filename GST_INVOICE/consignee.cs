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
    public partial class consignee : Form
    {
        public consignee()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=RB-PC;Initial Catalog=db_gst;Integrated Security=True");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
           
            string check_query = "select * from tbl_consignee where cn_name='" + txt_name.Text+ "'";
            SqlDataAdapter adpt = new SqlDataAdapter(check_query, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Open();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("NAME ALREADY EXISTS", "Duplicate");
            }
            else
            {
                string insert = "insert into tbl_consignee(cn_name,cn_contact,cn_add,cn_state,cn_code)";
                insert += "values('" + txt_name.Text + "','" + txt_mobile.Text + "','" + txt_address.Text.Replace(",", "") + "'";
                insert += ",'" + combo_state.SelectedValue.ToString() + "','" + Convert.ToInt16(lbl_code.Text) + "')";

                SqlCommand cmd = new SqlCommand(insert, con);
                //int result=cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Added");
                }
                else { MessageBox.Show("try again"); }
            }
            con.Close();
        }

        private void consignee_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=RB-PC;Initial Catalog=db_gst;Integrated Security=True");
            string get_state = "select * from tbl_state";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(get_state, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                combo_state.Items.Clear();
                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select State--" };
                dt.Rows.InsertAt(dr, 0);

                combo_state.ValueMember = "st_code";

                combo_state.DisplayMember = "st_name";
                combo_state.DataSource = dt;
            }
            con.Close();    
        }

        private void combo_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_code.Text = combo_state.SelectedValue.ToString();
        }
    }
}
