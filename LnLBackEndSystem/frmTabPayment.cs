//Manuel A Nunes 34551875 Brendan 32737742
using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmTabPayment : Form
    {
        public static Form Creator;
        public frmTabPayment()
        {
            InitializeComponent();
        }

        private void linkToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Tab_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Creator.Show();
        }

        private void btnSubmitTotal_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(EdtAmount.Text, out double Amount))
            {
                MessageBox.Show("Invalid Value");
                EdtAmount.Focus();
                return;
            }
            frmPayConfirm.Creator = this;
            frmPayConfirm PayConf = new frmPayConfirm();
            PayConf.ShowDialog();
            if (!frmPayConfirm.isVerified)
            {
                MessageBox.Show("Invalid Information");
                return;
            }
            Tab_login.Creator = this;
            Tab_login TabL = new Tab_login();
            TabL.ShowDialog();
            if (!Tab_login.isValidLogin)
            {
                MessageBox.Show("Invalid TabLogin");
                return;
            }
            string Balance = DataModule.GetValue(0, $"SELECT Balance FROM tblTab WHERE TabID = {Tab_login.ID}");
            double BalanceAmount = double.Parse(Balance), AmountDue = BalanceAmount - Amount;
            if (AmountDue < 0)
            {
                MessageBox.Show($"Tab will be balanced to {0:C}, as we do not allow debit tabs.");
                MessageBox.Show($"Please give the following change {}");
            }
            if (DataModule.ExecuteSQL($"UPDATE tblTab Balance = {-Amount:2C} SET WHERE TabID = {Tab_login.ID} ") > 0)
            {
            }
            else
            {

            }
                
        }
    }
}
