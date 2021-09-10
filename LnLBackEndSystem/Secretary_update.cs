using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class Secretary_update : Form
    {
        public static Form creator;
        public Secretary_update()
        {
            InitializeComponent();
        }

        private void Secretary_update_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_password.password = this;
            Forgot_password frmForget = new Forgot_password();
            frmForget.Show();
            this.Hide();
        }
    }
}
