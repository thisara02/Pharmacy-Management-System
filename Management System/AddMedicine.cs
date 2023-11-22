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
    public partial class FrmAddMedicine : Form
    {
        public FrmAddMedicine()
        {
            InitializeComponent();
        }

        public DataSet Dset = new DataSet();
        public SqlDataAdapter sqlda = new SqlDataAdapter();
        public SqlCommand cmd = new SqlCommand();
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\asust\OneDrive\Desktop\C# Final Project\dbPMS\dbPMS.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            txtMName.Text = "";
            txtMType.Text = "";
            dtpExp.ResetText();
            dtpMFD.ResetText();
            txtMCategory.Text = "";
            txtMRP.Text = "";
            txtMName.Focus();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmDashBoard objdash = new FrmDashBoard();
            this.Hide();
            objdash.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMName.Text == "" || txtMType.Text == "" || txtMCategory.Text == "" || txtMRP.Text == "" || dtpExp.Value == DateTime.Today || dtpMFD.Value==DateTime.Today)
            {
                MessageBox.Show("Please fill in the required fields Correctly", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string SaveQuery = "INSERT INTO Medicine(name,type,category,exp_date,mfd,mrp) " +
                        "VALUES('" + txtMName.Text + "','" + txtMType.Text + "','" + txtMCategory.Text + "','" + dtpExp.Text + "','" + dtpMFD.Text + "','" + txtMRP.Text + "')";
                    con.Open();
                    cmd = new SqlCommand(SaveQuery, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Medicine Added Successfully", "Add Supplier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
