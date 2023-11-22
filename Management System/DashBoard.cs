using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer_Registration objcus= new FrmCustomer_Registration();
            this.Hide();
            objcus.Show();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            FrmAddMedicine objmed=new FrmAddMedicine();
            this.Hide();
            objmed.Show();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FrmBrowse objbrow=new FrmBrowse();  
            this.Hide();
            objbrow.Show();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            FrmAddSupplier objsup = new FrmAddSupplier();
            this.Hide();
            objsup.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure, Do You want to Logout...?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                FrmLogin objlog = new FrmLogin();
                this.Hide();
                objlog.Show();
            }
        }
    }
}
