//Carla Pretorius 36184950
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmBarpersonLogin : Form
    {
        public static Form Creator;
        public frmBarpersonLogin()
        {
            InitializeComponent();
        }

        private void btnImageManage_Click(object sender, EventArgs e)
        {
            frmImageManager.Creator = this;
            frmImageManager imgMan = new frmImageManager();
            imgMan.Show();
            this.Hide();
        }

        private void btnRequestStock_Click(object sender, EventArgs e)
        {
            frmRequestStock.Creator = this;
            frmRequestStock ReqStock = new frmRequestStock();
            ReqStock.Show();
            this.Hide();
        }

        private void btnPointOfSale_Click(object sender, EventArgs e)
        {
            frmStockPurchase.Creator = this;
            frmStockPurchase stockPur = new frmStockPurchase();
            stockPur.Show();
            this.Hide();
        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            frmStockReport.Creator = this;
            frmStockReport stockReport = new frmStockReport();
            stockReport.Show();
            this.Hide();
        }

        private void frmBarpersonLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
