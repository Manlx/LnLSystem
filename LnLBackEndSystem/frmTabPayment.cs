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
            
            if (!Tab_login.isValidLogin)
            {
                MessageBox.Show("Invalid TabLogin");
                return;
            }

            string Balance = DataModule.GetValue(0, $"SELECT Balance FROM tblTab WHERE TabID = {Tab_login.ID}");
            string CurrentCutOff = DataModule.GetValue(0, $"SELECT CutOffValue FROM tblTab WHERE TabID = {Tab_login.ID}");
            
            double BalanceAmount = double.Parse(Balance), AmountDue = BalanceAmount - Amount,CutCurrent = Double.Parse(CurrentCutOff);
            bool QualForIncrease = BalanceAmount >= (CutCurrent * 50 / 100) && Amount >= BalanceAmount;
            if (AmountDue <= 0)
            {
                MessageBox.Show($"Tab will be balanced to {0:C}, as we do not allow debit tabs.");
                if (QualForIncrease)
                {
                    MessageBox.Show("As a reward we will be increasing your Cut off Value");
                    if (DataModule.ExecuteSQL($"UPDATE tblTab SET CutOffValue = {Double.Parse(CurrentCutOff) + 100:F2} WHERE TabID = {Tab_login.ID}") <= 0)
                        MessageBox.Show("Error Encountered while upgrading your account");
                }
                    
                MessageBox.Show($"Please give the following amount in change: {0 - AmountDue:C2}");
                AmountDue = 0;
            }
            Clipboard.SetText($"UPDATE tblTab SET Balance = {AmountDue:F2} WHERE TabID = {Tab_login.ID}");
            if (DataModule.ExecuteSQL($"UPDATE tblTab SET Balance = {AmountDue:F2} WHERE TabID = {Tab_login.ID} ") <= 0)
            {
                MessageBox.Show("Error was occured please try again");
                return;
            }
            MessageBox.Show("Thank you for balancing your Tab");
            UpdateLabels();
        }

        private void frmTabPayment_Load(object sender, EventArgs e)
        {
            EdtAmount.Focus();
            Tab_login.Creator = this;
            Tab_login TabL = new Tab_login();
            TabL.ShowDialog();
            if (!Tab_login.isValidLogin)
                this.Close();
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            if (String.IsNullOrEmpty(Tab_login.ID))
                return;
            string Balance = $"{int.Parse(DataModule.GetValue(0, $"SELECT Balance FROM tblTab WHERE TabID = {Tab_login.ID}")):F2}";
            if (String.IsNullOrEmpty(Balance))
                return;
            lblBalance.Text = $"{Balance:C2}";
            btnSubmitTotal.Enabled = Double.Parse(Balance) > 0;
            lblCutOffValue.Text = $"{int.Parse(DataModule.GetValue(0, $"SELECT CutOffValue FROM tblTab WHERE TabID = {Tab_login.ID}")):C2}";
        }
    }
}
