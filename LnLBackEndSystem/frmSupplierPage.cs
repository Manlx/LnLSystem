//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmSupplierPage : Form
    {
        public static Form Creator;
        public frmSupplierPage()
        {
            InitializeComponent();
        }

        private void frmSupplierPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierRegister.Creator = this;
            frmSupplierRegister Temp = new frmSupplierRegister();
            this.Hide();
            Temp.Show();

        }
    }
}
