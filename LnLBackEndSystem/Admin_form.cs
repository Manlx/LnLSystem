//M Tolmay 33784507
using System;
using System.Windows.Forms;



namespace LnLBackEndSystem
{
    public partial class Admin_form : Form
    {
        public static Form Creator;
        public Admin_form()
        {
            InitializeComponent();
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
            Creator.Show();
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Accountant_Login.Creator = this;
            Accountant_Login AccountantLogin = new Accountant_Login();
            AccountantLogin.Show();
            this.Hide();
        }

        private void btnSQLConsole_Click(object sender, EventArgs e)
        {
            frmSQLConsole.frmOwner = this;
            frmSQLConsole Console = new frmSQLConsole();
            this.Hide();
            Console.Show();
        }

        private void btnImgManager_Click(object sender, EventArgs e)
        {
            frmImageManager.Creator = this;
            frmImageManager imgMan = new frmImageManager();
            imgMan.Show();
            this.Hide();
        }
    }
}
