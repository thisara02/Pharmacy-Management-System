using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class FrmAddSupplier : Form
    {
        public FrmAddSupplier()
        {
            InitializeComponent();
        }

        public DataSet Dset = new DataSet();
        public SqlDataAdapter sqlda = new SqlDataAdapter();
        public SqlCommand cmd = new SqlCommand();
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\asust\OneDrive\Desktop\C# Final Project\dbPMS\dbPMS.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            txtSname.Text = "";
            txtSaddress.Text = "";
            txtScontact.Text = "";
            txtSreg.Text = "";
            txtLicence.Text = "";
            txtSname.Focus();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmDashBoard objdash = new FrmDashBoard();
            this.Hide();
            objdash.Show();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtSname.Text == "" || txtSaddress.Text == "" || txtScontact.Text == "" || txtSreg.Text == "" || txtLicence.Text == "")
            {
                MessageBox.Show("Please fill in the required fields", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string SaveQuery = "INSERT INTO Supplier(name,address,contact,reg_no,licence_no) " +
                        "VALUES('" + txtSname.Text + "','" + txtSaddress.Text + "','" + txtScontact.Text + "','" + txtSreg.Text+ "','" + txtLicence.Text + "')";
                    con.Open();
                    cmd = new SqlCommand(SaveQuery, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Added Successfully", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
