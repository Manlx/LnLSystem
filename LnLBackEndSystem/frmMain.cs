//Manuel A Nunes 34551875 Carla Pretorius
using System;
using System.Windows.Forms;
using NSDataModule;
using CypherLib;
using StaffObjAndUtils;

namespace LnLBackEndSystem
{
    public partial class frmMain : Form
    {
        public static frmSplash FormOwner;
        
        public frmMain()
        {
            InitializeComponent();
            
            frmDataManagement.Creator = this;
        }

        private void frmDataBaseMaintenance_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormOwner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSQLConsole.frmOwner = this;
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
            Secretary_form.Creator = this;
            Secretary_form frmSecretary = new Secretary_form();
            frmSecretary.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_form.Creator = this;
            Admin_form frmAdmin = new Admin_form();           
            frmAdmin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Warehouse_Restock.Creator = this;
            Warehouse_Restock frmWarehouse = new Warehouse_Restock();
            frmWarehouse.Show();
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

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            frmStockReport.Creator = this;
            frmStockReport frmStockreport = new frmStockReport();
            frmStockreport.Show();
            this.Hide();
        }

        private void btnStockOrder_Click(object sender, EventArgs e)
        {
            frmStockPurchase.Creator = this;
            frmStockPurchase frmPurchase = new frmStockPurchase();
            frmPurchase.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Accountant_Login.Creator = this;
            Accountant_Login frmAccountant = new Accountant_Login();
            frmAccountant.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(edtUser.Text, out int ID) )
            {
                MessageBox.Show("Please enter a valid user ID");
                edtUser.Focus();
                return;
            }
            StaffObj StaffMem = new StaffObj();
            StaffMem.LoadFromDB($"{ID}");
            if (StaffMem.EncryptedPassword != Cypher.Encrypt(edtPassword.Text) )
            {
                MessageBox.Show("Credentials are inncorrect");
                return;
            }
            switch(int.Parse(StaffMem.RankID))
            {
                case 1:
                    frmBarpersonLogin.Creator = this;
                    frmBarpersonLogin BarLogin = new frmBarpersonLogin();
                    BarLogin.Show();
                    break;
                case 6:
                case 7:
                case 2:
                    frmSecretaryLogin.Creator = this;
                    frmSecretaryLogin SecLogin = new frmSecretaryLogin();
                    SecLogin.Show();
                    break;
                case 4:
                case 3:
                    Accountant_Login.Creator = this;
                    Accountant_Login AccountLog = new Accountant_Login();
                    AccountLog.Show();
                    break;
                case 8:
                case 5:
                    Warehouse_Restock.Creator = this;
                    Warehouse_Restock WareLog = new Warehouse_Restock();
                    WareLog.Show();
                    break;

                case 11:
                    frmCEO.Creator = this;
                    frmCEO CEO = new frmCEO();
                    CEO.Show();
                    break;
                default:
                    MessageBox.Show("Login has encountered an issue. Contact administrator");
                    return;
            }
            this.Hide();
        }

        private void btnCEO_Click(object sender, EventArgs e)
        {
            frmCEO.Creator = this;
            frmCEO CEO = new frmCEO();
            this.Hide();
            CEO.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmClientRecoverPass.Creator = this;
            frmClientRecoverPass Temp = new frmClientRecoverPass();
            Temp.Show();
            this.Hide();
        }
    }
}
