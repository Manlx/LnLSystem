//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BankObjAndUtil;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmBankAdd : Form
    {
        public static Form Creator;
        public frmBankAdd()
        {
            InitializeComponent();
        }

        private void frmBankAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        bool HasShown = false;
        private void BtnRegisterBank_Click(object sender, EventArgs e)
        {
            if (edtBank.Text == "")
            {
                MessageBox.Show("Please Enter a bank Name");
                edtBank.Focus();
                return;
            }
            string[] Banks = DataModule.GetValues(0, $"SELECT BankName FROM tblBank WHERE BankName LIKE '%{edtBank.Text}%'");

            if (Banks.Length > 0 && !HasShown)
            {
                lstBank.Items.Clear();
                foreach (string x in Banks)
                    lstBank.Items.Add(x);
                HasShown = true;
                if (MessageBox.Show("Bank with Simular name Detected. Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            }

            BankObj Temp = new BankObj();
            Temp.BankName = edtBank.Text;
            if (Temp.InsertSelf())
                MessageBox.Show("Has Registerd Successfully");
            else
                MessageBox.Show("Registration Has Failed");

            HasShown = false;
        }
    }
}
