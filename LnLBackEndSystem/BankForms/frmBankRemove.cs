//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NSDataModule;
using BankObjAndUtil;

namespace LnLBackEndSystem
{
    public partial class frmBankRemove : Form
    {
        public static Form Creator;
        public frmBankRemove()
        {
            InitializeComponent();
        }

        private void frmBankRemove_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        private List<BankObj> Banks;
        private void RefreshComps()
        {
            string[] Ids = DataModule.GetValues(0, $"SELECT BankID FROM tblBank");
            Banks = new List<BankObj>();
            foreach (string x in Ids)
            {
                Banks.Add(new BankObj());
                Banks[Banks.Count - 1].LoadFromDB(x);
            }
            lstBanks.Items.Clear();
            foreach (BankObj x in Banks)
                lstBanks.Items.Add(x.BankName);
        }
        private void frmBankRemove_Load(object sender, EventArgs e)
        {
            RefreshComps();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBanks.SelectedIndex < 0)
            {
                MessageBox.Show("Bank not selected");
                lstBanks.Focus();
                return;
            }
            if (Banks[lstBanks.SelectedIndex].DeleteSelf())
                MessageBox.Show("Bank Removed Successfully");
            else
                MessageBox.Show("Failed!");
            RefreshComps();
        }
    }
}
