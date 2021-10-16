//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NSDataModule;
using BankObjAndUtil;

namespace LnLBackEndSystem
{
    public partial class frmBankUpdate : Form
    {
        public static Form Creator;
        public frmBankUpdate()
        {
            InitializeComponent();
        }

        private void frmBankUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        List<BankObj> Banks;
        private void RefreshValues()
        {
            Banks = new List<BankObj>();
            string[] Ids = DataModule.GetValues(0,$"SELECT BankID FROM tblBank");
            foreach (string x in Ids)
            {
                Banks.Add(new BankObj());
                Banks[Banks.Count - 1].LoadFromDB(x);
            }
            lstBank.Items.Clear();
            foreach (BankObj x in Banks)
                lstBank.Items.Add(x.BankName);
            if (lstBank.Items.Count >0)
                lstBank.SelectedIndex = 0;
        }
        private void frmBankUpdate_Load(object sender, EventArgs e)
        {
            RefreshValues();
        }

        private void lstBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBank.SelectedIndex < 0)
                return;
            edtBank.Text = Banks[lstBank.SelectedIndex].BankName;
        }

        private void BtnUpdateBank_Click(object sender, EventArgs e)
        {
            if (lstBank.SelectedIndex < 0)
            {
                MessageBox.Show("Select bank to update");
                lstBank.Focus();
                return;
            }
            Banks[lstBank.SelectedIndex].BankName = edtBank.Text;
            if (Banks[lstBank.SelectedIndex].UpdateSelf())
                MessageBox.Show("Updated Bank");
            else
                MessageBox.Show("Failure to update");
            RefreshValues();
        }
    }
}
