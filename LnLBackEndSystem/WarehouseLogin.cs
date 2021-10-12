//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class WarehouseLogin : Form
    {
        public static Form Creator;
        public WarehouseLogin()
        {
            InitializeComponent();
        }

        private void WarehouseLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            Warehouse_Restock.Creator = this;
            Warehouse_Restock Temp = new Warehouse_Restock();
            this.Hide();
            Temp.Show();
        }

        private void btnOrderSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierOrder.Creator = this;
            frmSupplierOrder Temp = new frmSupplierOrder();
            this.Hide();
            Temp.Show();
        }
    }
}
