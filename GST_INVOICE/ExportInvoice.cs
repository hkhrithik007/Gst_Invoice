using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GST_INVOICE
{
    class ExportInvoice
    {
        public static void Export_to_excel(string query)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            //SqlConnection cnn;
            //string connectionString = null;
            // string sql = null;
            string data = null;
            int i = 0;
            int j = 0;
            cnn.Open();
            string get_company = "select  c_name from tbl_company where c_id=" + LoginInfo.loginId + "";
           DataSet dt = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(get_company, cnn);
            //con.Open();
            adpt.Fill(dt);
            //con.Close();


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //connectionString = "Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30";

            // cnn = new SqlConnection(connectionString);
            
            // sql = "SELECT * FROM Product";
            SqlDataAdapter dscmd = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);
            // 	Total Cess			

            xlWorkSheet.Cells[1, 1] = "Invoice Date";
            xlWorkSheet.Cells[1, 2] = "Invoice No.";
            xlWorkSheet.Cells[1, 3] = "Customer Name";
            xlWorkSheet.Cells[1, 4] = "GSTIN";
            xlWorkSheet.Cells[1, 5] = "Customer Mobile";
            xlWorkSheet.Cells[1, 6] = "Address 1";
            xlWorkSheet.Cells[1, 7] = "State";
            xlWorkSheet.Cells[1, 8] = "State Code";
            xlWorkSheet.Cells[1, 9] = "Particulars";
            xlWorkSheet.Cells[1, 10] = "HSN / SAC Code";
            xlWorkSheet.Cells[1, 11] = "Quantity";
            xlWorkSheet.Cells[1, 12] = "Unit of Measure";
            xlWorkSheet.Cells[1, 13] = "Rate";
            xlWorkSheet.Cells[1, 14] = "Value";
            xlWorkSheet.Cells[1, 15] = "Discount (Rs.)";
            xlWorkSheet.Cells[1, 16] = "Taxable Value";
            xlWorkSheet.Cells[1, 17] = "SGST Rate %";
            xlWorkSheet.Cells[1, 18] = "SGST Amount";
            xlWorkSheet.Cells[1, 19] = "CGST Rate %";
            xlWorkSheet.Cells[1, 20] = "CGST Amount";
            xlWorkSheet.Cells[1, 21] = "IGST Rate %";
            xlWorkSheet.Cells[1, 22] = "IGST Amount";
            xlWorkSheet.Cells[1, 23] = "Total Amount before Tax";
            xlWorkSheet.Cells[1, 24] = "Total SGST";
            xlWorkSheet.Cells[1, 25] = "Total CGST";
            xlWorkSheet.Cells[1, 26] = "Total IGST";
            xlWorkSheet.Cells[1, 27] = "Rounded Off";
            xlWorkSheet.Cells[1, 28] = "Grand Total";
            xlWorkSheet.Cells[1, 29] = "GST on Reverse Charge";
            xlWorkSheet.Cells[1, 30] = "DELETED";

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 2, j + 1] = data;
                }
            }
            string newPath = @"C:\GST Invoices\"+dt.Tables[0].Rows[0].ItemArray[0].ToString()+"\\Exported Excel\\";
            if (!Directory.Exists(newPath))
            {
                System.IO.Directory.CreateDirectory(newPath);
            }
            //xlWorkBook.SaveAs()
            //xlWorkBook.Path = "@" + newPath;

            xlWorkBook.SaveAs(newPath + System.DateTime.Today.ToString("dd-MMMM-yyyy") + "_invoice.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.SaveAs("" + System.DateTime.Today.ToString("dd-MMMM-yyyy") + "_invoice.xlsx", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            // xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Marshal.FinalReleaseComObject(xlRng);
            Marshal.FinalReleaseComObject(xlWorkSheet);

            xlWorkBook.Close(0);
            Marshal.FinalReleaseComObject(xlWorkBook);

            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);
            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);
            MessageBox.Show("Invoice Exported");
            System.Diagnostics.Process.Start(newPath + System.DateTime.Today.ToString("dd-MMMM-yyyy") + "_invoice.xls");
            //test tst = new test();
            //tst.Show();
            //this.Hide();
        }

        public static void BackupInvoices(string query)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["local_connection"].ToString());
            //SqlConnection cnn;
            //string connectionString = null;
            // string sql = null;
            cnn.Open();
            string data = null;
            int i = 0;
            int j = 0;
            string get_company = "select  c_name from tbl_company where c_id=" + LoginInfo.loginId + "";
            DataSet dt = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(get_company, cnn);
            //con.Open();
            adpt.Fill(dt);
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //connectionString = "Data Source=.;Initial Catalog=db_gst;Integrated Security=True;Pooling=False;Connect Timeout=30";

            // cnn = new SqlConnection(connectionString);
           // cnn.Open();
            // sql = "SELECT * FROM Product";
            SqlDataAdapter dscmd = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);
            // 	Total Cess			

            xlWorkSheet.Cells[1, 1] = "inv_no";
            xlWorkSheet.Cells[1, 2] = "inv_part";
            xlWorkSheet.Cells[1, 3] = "inv_hsn";
            xlWorkSheet.Cells[1, 4] = "inv_qty";
            xlWorkSheet.Cells[1, 5] = "inv_unit";
            xlWorkSheet.Cells[1, 6] = "inv_rate";
            xlWorkSheet.Cells[1, 7] = "inv_value";
            xlWorkSheet.Cells[1, 8] = "inv_disc";
            xlWorkSheet.Cells[1, 9] = "inv_tax_val";
            xlWorkSheet.Cells[1, 10] = "inv_sgst_rate";
            xlWorkSheet.Cells[1, 11] = "inv_sgst_amt";
            xlWorkSheet.Cells[1, 12] = "inv_cgst_rate";
            xlWorkSheet.Cells[1, 13] = "inv_cgst_amt";
            xlWorkSheet.Cells[1, 14] = "inv_igst_rate";
            xlWorkSheet.Cells[1, 15] = "inv_igst_amt";
            xlWorkSheet.Cells[1, 16] = "inv_cid";
            xlWorkSheet.Cells[1, 17] = "inv_consignee";
            xlWorkSheet.Cells[1, 18] = "inv_date";
            xlWorkSheet.Cells[1, 19] = "inv_befor_tax";
            xlWorkSheet.Cells[1, 20] = "inv_total_gst";
            xlWorkSheet.Cells[1, 21] = "inv_total_cgst";
            xlWorkSheet.Cells[1, 22] = "inv_total_igst";
            xlWorkSheet.Cells[1, 23] = "inv_other_charge";
            xlWorkSheet.Cells[1, 24] = "inv_grand_total";
            xlWorkSheet.Cells[1, 25] = "invoice_no";
            xlWorkSheet.Cells[1, 26] = "flag";
            xlWorkSheet.Cells[1, 27] = "gst_reserve";
            
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 2, j + 1] = data;
                }
            }
            string newPath = @"C:\GST Invoices\" + dt.Tables[0].Rows[0].ItemArray[0].ToString() + "\\Exported Excel\\";
            if (!Directory.Exists(newPath))
            {
                System.IO.Directory.CreateDirectory(newPath);
            }
            //xlWorkBook.SaveAs()
            //xlWorkBook.Path = "@" + newPath;
            
            //xlWorkBook.SaveAs(newPath + System.DateTime.Today.ToString("dd-MMMM-yyyy") + "_backup_invoice.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.SaveAs(newPath + System.DateTime.Today.ToString("dd-MMMM-yyyy") + "_backup_invoice.xls", Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, true, true, XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            
           // xlWorkBook.ReadOnly;
            //xlWorkBook.SaveAs("" + System.DateTime.Today.ToString("dd-MMMM-yyyy") + "_invoice.xlsx", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            // xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Marshal.FinalReleaseComObject(xlRng);
            Marshal.FinalReleaseComObject(xlWorkSheet);

            xlWorkBook.Close(0);
            Marshal.FinalReleaseComObject(xlWorkBook);

            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);
            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);
            MessageBox.Show("Invoice Exported");
            System.Diagnostics.Process.Start(newPath + System.DateTime.Today.ToString("dd-MMMM-yyyy") + "_backup_invoice.xls");
            //test tst = new test();
            //tst.Show();
            //this.Hide();
        }
    }
}
