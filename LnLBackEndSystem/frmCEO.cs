//Carla Pretorius 36184950
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmCEO : Form
    {
        public static Form Creator;
        public frmCEO()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin_form.Creator = this;
            Admin_form Admin = new Admin_form();
            Admin.Show();
            this.Hide();
        }

        private void NavigateToAccountant_Click(object sender, EventArgs e)
        {
            Accountant_Login.Creator = this;
            Accountant_Login AccLog = new Accountant_Login();
            AccLog.Show();
            this.Hide();
        }

        private void btnNavidateToSecretary_Click(object sender, EventArgs e)
        {
            Secretary_form.Creator = this;
            Secretary_form SecForm = new Secretary_form();
            SecForm.Show();
            this.Hide();
        }

        private void btnNavigateBartender_Click(object sender, EventArgs e)
        {
            frmBarpersonLogin.Creator = this;
            frmBarpersonLogin BarLog = new frmBarpersonLogin();
            BarLog.Show();
            this.Show();
        }
    }
}
