//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmBankSupplierPage : Form
    {
        public static Form Creator;
        public frmBankSupplierPage()
        {
            InitializeComponent();
        }

        private void btnSupBank_Click(object sender, EventArgs e)
        {
            frmBankSupplier.Creator = this;
            frmBankSupplier Temp = new frmBankSupplier();
            Temp.Hide();
            Temp.Show();
        }

        private void frmBankSupplierPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
