//Manuel A Nunes 34551875 Brendan 32737742
using System;
using System.Windows.Forms;
using TabObjAndUtil;

namespace LnLBackEndSystem
{
    public partial class frmTabPayment : Form
    {
        public static Form Creator;
        public static TabObj CurrentTab;
        public frmTabPayment()
        {
            InitializeComponent();
            CurrentTab = new TabObj();
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
            frmStaffLogin.Creator = this;
            frmStaffLogin PayConf = new frmStaffLogin();
            PayConf.ShowDialog();

            if (!frmStaffLogin.isValid)
            {
                MessageBox.Show("Invalid Information");
                return;
            }
            if (CurrentTab.AdjustBalance(Amount, out bool QualForIncrease,out double ChangeAmount))
            {
                MessageBox.Show($"Payed Tab Successfully. Change Amount: {ChangeAmount:C2}");
                if (QualForIncrease)
                    MessageBox.Show("Your account has been rewarded with a higher Cut off Value");
            }
            else
                MessageBox.Show("Error was encountered 000-000-003");
            UpdateLabels();
        }

        private void frmTabPayment_Load(object sender, EventArgs e)
        {
            frmClientLogin.Creator = this;
            frmClientLogin TabL = new frmClientLogin();
            TabL.ShowDialog();
            if (!frmClientLogin.CorrectUser)
                this.Close();
            CurrentTab.LoadFromDB(frmClientLogin.LastClient.ClientID);
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            lblBalance.Text = $"{CurrentTab.Balance:C2}";
            lblCutOffValue.Text = $"{CurrentTab.CutOffValue:C2}";
        }
    }
}
