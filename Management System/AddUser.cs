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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }
        public DataSet Dset = new DataSet();
        public SqlDataAdapter sqlda = new SqlDataAdapter();
        public SqlCommand cmd = new SqlCommand();
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\asust\OneDrive\Desktop\C# Final Project\dbPMS\dbPMS.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            txtNewUser.Text = "";
            txtPw.Text = "";
            txtConfirm.Text = "";
            txtAdmin.Text = "";
            txtNewUser.Focus();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {           
             FrmLogin objlog = new FrmLogin();
             this.Hide();
             objlog.Show();        
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text == "" || txtPw.Text == "" || txtConfirm.Text == "" || txtAdmin.Text == "")
            { 
                MessageBox.Show("Please fill in the required fields", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (txtAdmin.Text == "Admin@123" && txtPw.Text==txtConfirm.Text)
                    {
                        string SaveQuery = "INSERT INTO USers(username,password) " +
                            "VALUES('" + txtNewUser.Text + "','" + txtPw.Text + "')";
                        con.Open();
                        cmd = new SqlCommand(SaveQuery, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Registered Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Insert Correct Admin Password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAdmin.Text = "";
                        txtAdmin.Focus();
                    }
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

        private void btnClear2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
