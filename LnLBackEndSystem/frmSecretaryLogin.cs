//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmSecretaryLogin : Form
    {
        public static Form Creator;
        public frmSecretaryLogin()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaffManagement.Creator = this;
            frmStaffManagement Temp = new frmStaffManagement();
            this.Hide();
            Temp.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierPage.Creator = this;
            frmSupplierPage Temp = new frmSupplierPage();
            this.Hide();
            Temp.Show();
        }

        private void btnBankSupplier_Click(object sender, EventArgs e)
        {
            frmBankSupplier.Creator = this;
            frmBankSupplier Temp = new frmBankSupplier();
            this.Hide();
            Temp.Show();
        }

        private void frmSecretaryLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void BtnBankManagement_Click(object sender, EventArgs e)
        {
            frmBankPage.Creator = this;
            frmBankPage Temp = new frmBankPage();
            this.Hide();
            Temp.Show();
        }
    }
}
