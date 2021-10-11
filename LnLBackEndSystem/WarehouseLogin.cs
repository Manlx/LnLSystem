//Manuel A Nunes 34551875
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
    }
}
