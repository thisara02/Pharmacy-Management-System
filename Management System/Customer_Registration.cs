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
    public partial class FrmCustomer_Registration : Form
    {
        public FrmCustomer_Registration()
        {
            InitializeComponent();
        }

        string gender;

        public DataSet Dset = new DataSet();
        public SqlDataAdapter sqlda = new SqlDataAdapter();
        public SqlCommand cmd = new SqlCommand();
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\asust\OneDrive\Desktop\C# Final Project\dbPMS\dbPMS.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            txtName.Text = "";
            txtNIC.Text = "";
            txtAge.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Text = "";
            txtContact.Text = "";
            txtAllergy.Text = "";
            txtAdditional.Text = "";
            txtName.Focus();
        }

        private void LoadIDs()
        {
            try
            {
                string query = "SELECT customer_id FROM Customers ORDER BY customer_id";
                con.Open();
                sqlda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                sqlda.Fill(dt);
                con.Close();

                cmbID.Items.Clear();
                cmbID.Items.Add("-SELECT-");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbID.Items.Add(dr["customer_id"]);
                }
                cmbID.SelectedIndex = 0;
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

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            FrmDashBoard objdash=new FrmDashBoard();
            this.Hide();
            objdash.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtNIC.Text == "" || txtAge.Text == "" || txtAddress.Text == "" || txtContact.Text == "" || txtAllergy.Text == ""
      || txtAdditional.Text == "")
            {
                MessageBox.Show("Please fill in the required fields", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (rbMale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else if (rbFemale.Checked == true)
                    {
                        gender = "Female";
                    }

                    string SaveQuery = "INSERT INTO Customers(name,nic,age,gender,address,contact,allergy,additional) " +
                        "VALUES('" + txtName.Text + "','" + txtNIC.Text + "','" + txtAge.Text + "','" + gender + "','" + txtAddress.Text + "','" + txtContact.Text +
                        "','" + txtAllergy.Text + "','" + txtAdditional.Text + "')";
                    con.Open();
                    cmd = new SqlCommand(SaveQuery, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully", "Add New Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtNIC.Text == "" || txtAge.Text == "" || txtAddress.Text == "" || txtContact.Text == "" || txtAllergy.Text == ""
      || txtAdditional.Text == "")
            {
                MessageBox.Show("Please fill in the required fields", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                try
                {
                    if (rbMale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else if (rbFemale.Checked == true)
                    {
                        gender = "Female";
                    }

                    string UpdateQuery = "UPDATE Customers SET name='" + txtName.Text + "',nic='" + txtNIC.Text + "',age='" + txtAge.Text +
                        "',gender='" + gender + "',address='" + txtAddress.Text + "',contact='" + txtContact.Text + "',allergy='" + txtAllergy.Text + "',additional='" +
                        txtAdditional.Text + "' WHERE customer_id='" + cmbID.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(UpdateQuery, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully", "Update Medicine", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure,Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (cmbID.Text == "")
                {
                    MessageBox.Show("Please Select a Medicine to Delete..?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbID.Focus();
                }
                if (cmbID.Text == "-SELECT-")
                {
                    MessageBox.Show("Please Select a Medicine to Delete..?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbID.Focus();
                }

                try
                {
                    string DeleteQuery = "DELETE FROM Customers WHERE customer_id='" + cmbID.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(DeleteQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully", "Delete MEdicine", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                    LoadIDs();
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
            else
            {
                Clear();
            }
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbID.SelectedIndex > 0)
                {
                    string getDetails = "SELECT * FROM Customers WHERE customer_id='" + cmbID.SelectedItem + "'";
                    con.Open();
                    cmd = new SqlCommand(getDetails, con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        txtName.Text = r.GetValue(1).ToString();
                        txtNIC.Text = r.GetValue(2).ToString();
                        txtAge.Text = r.GetValue(3).ToString();
                        if (r.GetValue(4).ToString() == "Male")
                        {
                            rbMale.Checked = true;
                            rbFemale.Checked = false;
                        }
                        else
                        {
                            rbMale.Checked = false;
                            rbFemale.Checked = true;
                        }
                        txtAddress.Text = r.GetValue(5).ToString();
                        txtContact.Text = r.GetValue(6).ToString();
                        txtAllergy.Text = r.GetValue(7).ToString();
                        txtAdditional.Text = r.GetValue(8).ToString();
                    }
                    con.Close();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Clear();
            cmbID.Visible = true;
            lblID.Visible = true;
            btnClose.Visible = true;
            btnSearch.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnClear.Visible = false;
            btnRegister.Visible = false;
            cmbID.Focus();
            LoadIDs();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Clear();
            cmbID.Visible = false;
            lblID.Visible = false;
            btnClose.Visible = false;
            btnSearch.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnClear.Visible = true;
            btnRegister.Visible = true;
            txtName.Focus();
        }

        private void FrmCustomer_Registration_Load(object sender, EventArgs e)
        {
            cmbID.Visible = false;
            lblID.Visible = false;
            btnClose.Visible = false;
            btnSearch.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnClear.Visible = true;
            btnRegister.Visible = true;
        }
    }
}
