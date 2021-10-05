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
    public partial class frmMain : Form
    {
        public static frmSplash FormOwner;
        
        public frmMain()
        {
            InitializeComponent();
            frmSQLConsole.frmOwner = this;
            frmDataManagement.Creator = this;
        }

        private void frmDataBaseMaintenance_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormOwner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSQLConsole myCons = new frmSQLConsole();
            this.Hide();
            myCons.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDataManagement DataBaseManagement = new frmDataManagement();
            DataBaseManagement.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secretary_form.creator = this;
            Secretary_form frmSecretary = new Secretary_form();
            frmSecretary.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_form.admin = this;
            Admin_form frmAdmin = new Admin_form();           
            frmAdmin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Guest_form.guest = this;
            Guest_form frmGuest = new Guest_form();
            frmGuest.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Warehouse_Login.warehouse = this;
            Warehouse_Login frmWarehouse = new Warehouse_Login();
            frmWarehouse.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabPurchase.tabPurch = this;
            tabPurchase frmTabPurch = new tabPurchase();
            frmTabPurch.Show();
            this.Hide();
        }
        

        private void btnRequestStock_Click(object sender, EventArgs e)
        {
            frmRequestStock.Creator = this;
            frmRequestStock stockfrm = new frmRequestStock();
            stockfrm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmImageManager.Creator = this;
            frmImageManager frmImage = new frmImageManager();
            frmImage.Show();
            this.Hide();
        }

        private void btnStockOrder_Click(object sender, EventArgs e)
        {
            frmStockPurchase.Creator = this;
            frmStockPurchase frmPurchase = new frmStockPurchase();
            frmPurchase.Show();
            this.Hide();
        }
    }
}
