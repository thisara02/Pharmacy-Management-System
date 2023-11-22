using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Management_System
{
    public partial class FrmBrowse : Form
    {
        public FrmBrowse()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtMedicine.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                string searchUrl = "https://www.google.com/search?q=" + Uri.EscapeDataString(searchText);

                Process.Start(new ProcessStartInfo
                {
                    FileName = searchUrl,
                    UseShellExecute = true
                });
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedicine.Text = "";
            txtMedicine.Focus();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmDashBoard objdash = new FrmDashBoard();
            this.Hide();
            objdash.Show();
        }
    }
}
