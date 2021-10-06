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
    public partial class tabPurchase : Form
    {
        public static Form tabPurch;
        public tabPurchase()
        {
            InitializeComponent();
        }

        private void tabPurchase_Load(object sender, EventArgs e)
        {

        }

        private void linkTabOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tab_Order.tabOrder = this;
            Tab_Order frmTabOrder = new Tab_Order();
            frmTabOrder.Show();
            this.Hide();
        }

        private void tabPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            tabPurch.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
