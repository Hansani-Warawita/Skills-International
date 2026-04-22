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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6503LH0U;Initial Catalog=Student;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, Do you really want to Exit...?", "EXIT !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cheBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cheBoxPassword.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = default(char);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Un, Pw;
                Un = txtUserName.Text;
                Pw = txtPassword.Text;
                if (Un == "" || Pw == "")
                {
                    MessageBox.Show("User name or Password cannot be Blank !", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                }
                else
                {
                    string quelog = "SELECT * FROM Logins WHERE usename='" + Un + "'AND password='" + Pw + "'";
                    conn.Open();
                    sqlDa = new SqlDataAdapter(quelog, conn);
                    DataTable Dt = new DataTable();
                    sqlDa.Fill(Dt);
                    if (Dt.Rows.Count > 0)
                    {
                        MessageBox.Show("You have successfully Logged in !", "LOGIN SUCCESS !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMenu frm = new frmMenu();
                        frm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtUserName.Focus();
                    }
                    conn.Close();
                }

            }
            catch(Exception LogErr)
            {
                MessageBox.Show("Error While Login..." + Environment.NewLine + LogErr);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
