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
    class GenerateTables
    {
        public static void create_invoice_table(int cid)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string tbl = "";
               // tbl += " USE [db_gst] ";
                tbl += " ";
                tbl += " ";
                tbl += "/****** Object:  Table [dbo].[tbl_invoice]    Script Date: 8/15/2017 4:48:14 PM ******/";
                tbl += " SET ANSI_NULLS ON ";
                tbl += "  ";
                tbl += " ";
                tbl += " SET QUOTED_IDENTIFIER ON ";
                tbl += "  ";
                tbl += " ";
                tbl += " SET ANSI_PADDING ON ";
                tbl += "  ";
                tbl += " ";
                tbl += "CREATE TABLE  [dbo].[tbl_invoice" + cid + "](";
                tbl += "	[inv_no] [int] IDENTITY(1,1) NOT NULL,";
                tbl += "	[inv_part] [varchar](150) NULL,";
                tbl += "	[inv_hsn] [varchar](150) NULL,";
                tbl += "	[inv_qty] [int] NULL,";
                tbl += "	[inv_unit] [varchar](50) NULL,";
                tbl += "	[inv_rate] [varchar](50) NULL,";
                tbl += "	[inv_value] [varchar](150) NULL,";
                tbl += "	[inv_disc] [varchar](50) NULL,";
                tbl += "	[inv_tax_val] [varchar](150) NULL,";
                tbl += "	[inv_sgst_rate] [varchar](50) NULL,";
                tbl += "	[inv_sgst_amt] [varchar](150) NULL,";
                tbl += "	[inv_cgst_rate] [varchar](50) NULL,";
                tbl += "	[inv_cgst_amt] [varchar](150) NULL,";
                tbl += "	[inv_igst_rate] [varchar](50) NULL,";
                tbl += "	[inv_igst_amt] [varchar](150) NULL,";
                tbl += "	[inv_cid] [int] NULL,";
                tbl += "	[inv_consignee] [int] NULL,";
                tbl += "	[inv_date] [varchar](50) NULL,";
                tbl += "	[inv_befor_tax] [varchar](150) NULL,";
                tbl += "	[inv_total_gst] [varchar](150) NULL,";
                tbl += "	[inv_total_cgst] [varchar](150) NULL,";
                tbl += "	[inv_total_igst] [varchar](150) NULL,";
                tbl += "	[inv_other_charge] [varchar](150) NULL,";
                tbl += "	[inv_grand_total] [varchar](150) NULL,";
                tbl += "	[invoice_no] [int] NOT NULL,";
                tbl += "	[flag] [int] NOT NULL,";
                tbl += "	[gst_reserve] [varchar](50) NULL,";
                tbl += " CONSTRAINT [PK_tbl_invoice"+cid+"] PRIMARY KEY CLUSTERED ";
                tbl += " ( ";
                tbl += "	[inv_no] ASC ";
                tbl += " )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]";
                tbl += " ) ON [PRIMARY]";
                tbl += " ";
                tbl += "  ";
                tbl += " ";
                tbl += " SET ANSI_PADDING OFF ";
                tbl += " ";
                tbl += " ";
                tbl += " ALTER TABLE [dbo].[tbl_invoice"+cid+"] ADD  CONSTRAINT [DF_tbl_invoice"+cid+"_flag]  DEFAULT ((1)) FOR [flag] ";
                tbl += "  ";
                SqlCommand cmd = new SqlCommand(tbl, con);
                con.Open();
                if (cmd.ExecuteNonQuery() < 0)
                {
                   // MessageBox.Show("Database[invoice] Created for your company");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CREATING DATABASE[invoice]" + ex.Message);
                
            }
            finally
            {
                con.Close();
               
            }
        }

        public static void create_customer_table(int cid)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            try
            {
                string tbl = "";
                //tbl += "USE [db_gst] ";
                tbl += "  ";
                tbl += " ";
                tbl += "/****** Object:  Table [dbo].[tbl_client]    Script Date: 8/15/2017 4:53:34 PM ******/";
                tbl += " SET ANSI_NULLS ON ";
                tbl += "  ";
                tbl += " ";
                tbl += " SET QUOTED_IDENTIFIER ON ";
                tbl += "  ";
                tbl += " ";
                tbl += " SET ANSI_PADDING ON ";
                tbl += "  ";
                tbl += " ";
                tbl += " CREATE TABLE   [dbo].[tbl_client" + cid + "]( ";
                tbl += "	[cl_id] [int] IDENTITY(1,1) NOT NULL,";
                tbl += "	[cl_name] [varchar](150) NULL,";
                tbl += "	[cl_contact] [varchar](10) NULL,";
                tbl += "	[cl_add] [varchar](max) NULL,";
                tbl += "	[cl_state] [varchar](50) NULL,";
                tbl += "	[cl_code] [int] NULL,";
                tbl += "	[cl_gstin] [varchar](15) NULL,";
                tbl += " CONSTRAINT [PK_tbl_client"+cid+"] PRIMARY KEY CLUSTERED ";
                tbl += " ( ";
                tbl += "	[cl_id] ASC ";
                tbl += " )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]";
                tbl += " ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY] ";
                tbl += " ";
                tbl += "  ";
                tbl += " ";
                tbl += " SET ANSI_PADDING OFF ";
                tbl += "  ";
                SqlCommand cmd = new SqlCommand(tbl, con);
                con.Open();
                if (cmd.ExecuteNonQuery() < 0)
                {
                  //  MessageBox.Show("Database[Customer] Created for your company");
                    MessageBox.Show("Registered successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CREATING DATABASE[Customer]" + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
    }
}
