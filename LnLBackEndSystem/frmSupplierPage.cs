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

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierRemove.Creator = this;
            frmSupplierRemove Temp = new frmSupplierRemove();
            this.Hide();
            Temp.Show();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierUpdate.Creator = this;
            frmSupplierUpdate Temp = new frmSupplierUpdate();
            this.Hide();
            Temp.Show();
        }
    }
}
