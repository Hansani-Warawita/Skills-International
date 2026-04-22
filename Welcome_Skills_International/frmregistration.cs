using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Welcome_Skills_International
{
    public partial class frmregistration : Form
    {
        public frmregistration()
        {
            InitializeComponent();
        }

        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Student;Integrated Security=True");
        string stregno, gen;
        private void frmregistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1Studentreg_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbReg.Visible = false;
            txtRegno.Visible = true;
            txtRegno.Text = "";

            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpDOB.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobilePhone.Text = "";
            txtHomePhone.Text = "";
            txtPName.Text = "";
            txtNIC.Text = "";
            txtContactNo.Text = "";
            txtRegno.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            stregno = cmbReg.SelectedItem.ToString();
            DialogResult reDel = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "DELETE !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(reDel == DialogResult.Yes)
            {
                try
                {
                    String queDel = "DELETE FROM Registration WHERE regNo='" + stregno + "'";
                    Conn.Open();
                    cmd = new SqlCommand(queDel, Conn);
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Record Deleted Successfully", "DELETE STUDENT !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbReg.Visible = false;
                    txtRegno.Visible = true;
                    txtRegno.Text = "";
                    cmbReg.SelectedIndex = 0;
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    dtpDOB.Text = "";
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtMobilePhone.Text = "";
                    txtHomePhone.Text = "";
                    txtPName.Text = "";
                    txtNIC.Text = "";
                    txtContactNo.Text = "";
                    txtRegno.Focus();
                }
                catch(Exception DelErr)
                {
                    MessageBox.Show("Error while Delete..." + Environment.NewLine + DelErr);

                }
            }
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resEx == DialogResult.Yes)
            {

                Application.Exit();
            }
              
        }

        private void lblSI_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == true) { gen = "Male"; }
            else if (rbFemale.Checked == true) { gen = "Female"; }
            stregno = cmbReg.SelectedItem.ToString();
            try
            {
                String queUp = "UPDATE Registration SET firstName='" + txtFirstName.Text + "',lastName='" + txtLastName.Text+ "',dateOfBirth='" + dtpDOB.Text + "',gender='" + gen + "',Saddress='" + txtAddress.Text + "',email='" + txtEmail.Text + "',mobilePhone='" + txtMobilePhone.Text + "',homePhone='" + txtHomePhone.Text + "',parentName='" + txtPName.Text + "',nic='" + txtNIC.Text + "',contactNo='" + txtContactNo.Text + "' WHERE regNo='" + stregno + "'";
                Conn.Open();
                cmd = new SqlCommand(queUp, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("Record Updated Successfully", "Update Student !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbReg.Visible = false;
                txtRegno.Visible = true;
                txtRegno.Text = "";
                cmbReg.SelectedIndex = 0;
                txtFirstName.Text = "";
                txtLastName.Text = "";
                dtpDOB.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtMobilePhone.Text = "";
                txtHomePhone.Text = "";
                txtPName.Text = "";
                txtNIC.Text = "";
                txtContactNo.Text = "";
                txtRegno.Focus();
            }
            catch (Exception upErr)
            {
                MessageBox.Show("Error while Update ..." + Environment.NewLine + upErr);
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == true) { gen = "Male"; }
            else if (rbFemale.Checked == true) { gen = "Female"; }
            stregno = txtRegno.Text;
            try
            {
                string quechek = "SELECT *FROM Registration WHERE regNo='" + stregno + "' ";
                Conn.Open();
                sqlDa = new SqlDataAdapter(quechek, Conn);
                DataTable Dtx = new DataTable();
                sqlDa.Fill(Dtx);
                if (Dtx.Rows.Count > 0)
                {
                    MessageBox.Show("Student Registration No:" + stregno + " is already in the Database", "DUPLICATE !",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRegno.Text = "";
                    txtRegno.Focus();
                }
                else
                {
                    string quereg = "INSERT INTO Registration VALUES('" + txtRegno.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + dtpDOB.Text + "','" + gen + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtMobilePhone.Text + "','" + txtHomePhone.Text + "','" + txtPName.Text + "','" + txtNIC.Text + "','" + txtContactNo.Text + "')";
                    cmd = new SqlCommand(quereg, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Succesfully", "Register Student !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cmbReg.Visible = false;
                    txtRegno.Visible = true;
                    txtRegno.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    dtpDOB.Text = "";
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtMobilePhone.Text = "";
                    txtHomePhone.Text = "";
                    txtPName.Text = "";
                    txtNIC.Text = "";
                    txtContactNo.Text = "";
                    txtRegno.Focus();
                }
                Conn.Close();
            }
            catch (Exception RejErr)
            {
                MessageBox.Show("Error While Register ..." + Environment.NewLine + RejErr);
            }
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReg.SelectedIndex > 0)
            {
                stregno = cmbReg.SelectedItem.ToString();
                try
                {
                    string queSel = "SELECT * FROM Registration WHERE regNo='" + stregno + "' ";
                    Conn.Open();
                    cmd = new SqlCommand(queSel, Conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    while (R.Read())
                    {
                        txtFirstName.Text = R.GetValue(1).ToString();
                        txtLastName.Text = R.GetValue(2).ToString();
                        dtpDOB.Text = R.GetValue(3).ToString();
                        gen = R.GetValue(4).ToString();
                        if (gen.Equals("Male")) { rbMale.Checked = true; }
                        else if (gen.Equals("Female")) { rbFemale.Checked = true; }
                        txtAddress.Text = R.GetValue(5).ToString();
                        txtEmail.Text = R.GetValue(6).ToString();
                        txtMobilePhone.Text = R.GetValue(7).ToString();
                        txtHomePhone.Text = R.GetValue(8).ToString();
                        txtPName.Text = R.GetValue(9).ToString();
                        txtNIC.Text = R.GetValue(10).ToString();
                        txtContactNo.Text = R.GetValue(11).ToString();
                    }
                    Conn.Close();
                }
                catch (Exception SelErr)
                {
                    MessageBox.Show("Error while Selecting..." + Environment.NewLine + SelErr);
                }
            }
            else
            {
                txtRegno.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                dtpDOB.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtMobilePhone.Text = "";
                txtHomePhone.Text = "";
                txtPName.Text = "";
                txtNIC.Text = "";
                txtContactNo.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbReg.Visible = true;
            txtRegno.Visible = false;
            try
            {
                string queGetregNo = "SELECT regNo FROM Registration ";
                Conn.Open();
                sqlDa = new SqlDataAdapter(queGetregNo, Conn);
                DataTable Dtm = new DataTable();
                sqlDa.Fill(Dtm);
                Conn.Close();
                cmbReg.Items.Clear();
                cmbReg.Items.Add("--SELECT--");
                foreach (DataRow row in Dtm.Rows)
                {
                    cmbReg.Items.Add(row["regNo"]);
                }
                cmbReg.SelectedIndex = 0;
            }
            catch (Exception searchErr)
            {
                MessageBox.Show("Error while Searching..." + Environment.NewLine + searchErr);
            }
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtRegno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
