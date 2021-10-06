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
    public partial class Admin_form : Form
    {
        public static Form admin;
        public Admin_form()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDataManagement.Creator = this;
            frmDataManagement DataBaseManagement = new frmDataManagement();
            DataBaseManagement.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Show();
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Accountant_Login.accountant = this;
            Accountant_Login AccountantLogin = new Accountant_Login();
            AccountantLogin.Show();
            this.Hide();
        }
    }
}
