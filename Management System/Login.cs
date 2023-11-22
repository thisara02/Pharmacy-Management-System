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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\asust\OneDrive\Desktop\C# Final Project\dbPMS\dbPMS.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, pw;

            username = txtUsername.Text;
            pw = txtPassword.Text;

            try
            {
                string query = "SELECT * FROM Users WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pw))
                {
                    MessageBox.Show("Please enter both username and password.", "Error");
                    return;
                }

                if (dt.Rows.Count > 0)
                {
                    FrmLoading objload = new FrmLoading();
                    this.Hide();
                    objload.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login credintials,please check Username and Password and try again", "Invalid Login Deatils", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error Found!" + error, "Login Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure, Do You Really want to Exit...?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linklabelAddNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddUser objuser = new FrmAddUser();
            this.Hide();
            objuser.Show();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
