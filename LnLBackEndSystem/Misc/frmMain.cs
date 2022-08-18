//Manuel A Nunes 34551875 Carla Pretorius
using System;
using System.Windows.Forms;
using NSDataModule;
using CypherLib;
using StaffObjAndUtils;
using System.Net;

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
            AdminLogin.Creator = this;
            AdminLogin frmAdmin = new AdminLogin();           
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
            Accountant_Reports.Creator = this;
            Accountant_Reports frmAccountant = new Accountant_Reports();
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
            this.Hide();
            switch (int.Parse(StaffMem.RankID))
            {
                case 1:
                    frmBarpersonLogin.Creator = this;
                    frmBarpersonLogin BarLogin = new frmBarpersonLogin();
                    BarLogin.Show();
                    break;
                case 2:
                    frmHRAdminLogin.Creator = this;
                    frmHRAdminLogin Temp = new frmHRAdminLogin();
                    Temp.Show();
                    break;
                case 6:
                case 7:
                    frmSecretaryLogin.Creator = this;
                    frmSecretaryLogin SecLogin = new frmSecretaryLogin();
                    SecLogin.Show();
                    break;
                case 4:
                case 3:
                    frmAccountantLogin.Creator = this;
                    frmAccountantLogin AccountLog = new frmAccountantLogin();
                    AccountLog.Show();
                    break;
                case 8:
                case 5:
                    Warehouse_Restock.Creator = this;
                    Warehouse_Restock WareLog = new Warehouse_Restock();
                    WareLog.Show();
                    break;
                case 10:
                    AdminLogin.Creator = this;
                    AdminLogin AdLog = new AdminLogin();
                    AdLog.Show();
                    break;
                case 9:
                case 11:
                    frmCEOLogin.Creator = this;
                    frmCEOLogin CEO = new frmCEOLogin();
                    CEO.Show();
                    break;
                default:
                    this.Show();
                    MessageBox.Show("Login has encountered an issue. Contact administrator");
                    return;
            }
            
        }

        private void btnCEO_Click(object sender, EventArgs e)
        {
            frmCEOLogin.Creator = this;
            frmCEOLogin CEO = new frmCEOLogin();
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            panel2.Visible = !CheckForInternetConnection();
        }
        private static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
