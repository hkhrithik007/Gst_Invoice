using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_INVOICE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new company_login());
            //string path = Path.GetFullPath(Environment.CurrentDirectory);
            //string database_name = "db_gst.mdf";
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;AttachDbfilename=" + path + @"\" + database_name + ";Integrated Security=true");
            //if(System.DateTime.Today)
         
        }
    }
}
