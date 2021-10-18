//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmAccountantLogin : Form
    {
        public static Form Creator;
        public frmAccountantLogin()
        {
            InitializeComponent();
        }

        private void btnAccountantReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accountant_Reports.Creator = this;
            Accountant_Reports Temp = new Accountant_Reports();
            Temp.Show();
        }

        private void frmAccountantLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void btnBankManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBankPage.Creator = this;
            frmBankPage Temp = new frmBankPage();
            Temp.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplierPage.Creator = this;
            frmSupplierPage Temp = new frmSupplierPage();
            Temp.Show();
        }
    }
}
