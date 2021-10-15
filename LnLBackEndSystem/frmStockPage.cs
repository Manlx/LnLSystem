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
    public partial class frmStockPage : Form
    {
        public static Form Creator;
        public frmStockPage()
        {
            InitializeComponent();
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            frmStockAdd.Creator = this;
            frmStockAdd Temp = new frmStockAdd();
            this.Hide();
            Temp.Show();
        }

        private void frmStockPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {
            frmStockRemove.Creator = this;
            frmStockRemove Temp = new frmStockRemove();
            this.Hide();
            Temp.Show();
        }

        private void BtnUpdateStock_Click(object sender, EventArgs e)
        {
            frmStockUpdate.Creator = this;
            frmStockUpdate Temp = new frmStockUpdate();
            this.Hide();
            Temp.Show();
        }
    }
}
