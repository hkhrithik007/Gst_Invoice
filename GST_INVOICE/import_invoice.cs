using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_INVOICE
{
    public partial class import_invoice : Form
    {
        public import_invoice()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.ShowDialog();
            openfiledialog1.Filter = "allfiles|*.xls";
            textfilepath.Text = openfiledialog1.FileName;
        }

        private void btn_import_backup_Click(object sender, EventArgs e)
        {
            if (textfilepath.Text == "")
            {
                MessageBox.Show("Select a file");
            }
            else
            {
                import_backup.import(textfilepath.Text);
            }
        }
    }
}
