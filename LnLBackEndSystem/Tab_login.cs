//Brendan 32737742
using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class Tab_login : Form
    {
        public bool isValidLogin = false;
        public static Form Creator;

        public static Form tab;
        public Tab_login()
        {
            InitializeComponent();
        }

        private void Tab_login_Load(object sender, EventArgs e)
        {

        }

        private void linkToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnSubmitTab_Click(object sender, EventArgs e)
        {
            string tabID = txtTabID.Text;
            string tabPin = txtTabPIN.Text;

            string sqlTabID = "";
            string sqlTabPin = "";

            sqlTabID = $"SELECT TabID FROM tblTab WHERE TabID = {tabID}";
            sqlTabPin = $"SELECT TabPin FROM tblTab WHERE TabID = {tabID}";
            string FetchedID = DataModule.GetValue(0, sqlTabID);
            if (FetchedID != "")
            {
                string FetchPass = DataModule.GetValue(0, sqlTabPin);
                if (FetchPass != "")
                {
                    isValidLogin = FetchPass == tabPin;
                }
                else
                {
                    MessageBox.Show("PIN Invalid");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
            MessageBox.Show($"Login Valid: {isValidLogin}");
            if (isValidLogin)
                this.Close();
        }

        private void Tab_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
