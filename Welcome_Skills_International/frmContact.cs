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
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {

        }

        private void lblContactus_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();

        }

        private void linkLabel1exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, Do you really want to Exit...?", "EXIT !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resEx==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
