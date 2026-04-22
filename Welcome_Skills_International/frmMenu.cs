using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welcome_Skills_International
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnRegistraion_Click(object sender, EventArgs e)
        {
            frmregistration frm = new frmregistration();
            frm.Show();
            this.Hide();
        }

        private void btContactus_Click(object sender, EventArgs e)
        {
            frmContact frm = new frmContact();
            frm.Show();
            this.Hide();




        }

        private void btn2Exit_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure you want to Exit ???", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBoxRegistration_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
             
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();//show login form
            this.Hide();//hide menu form
        }
    }
}
