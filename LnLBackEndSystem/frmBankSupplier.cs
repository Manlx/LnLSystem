//Manuel A NUnes 34551875
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using BankObjAndUtil;
using NSDataModule;
using SupplierAndUtils;
using SupplierBankUtils;

namespace LnLBackEndSystem
{
    public partial class frmBankSupplier : Form
    {
        public static Form Creator;
        public frmBankSupplier()
        {
            InitializeComponent();
        }
        private List<BankObj> BankList = new List<BankObj>();
        private List<SupplierObj> SupplierList = new List<SupplierObj>();
        private List<SupplierBankObj> SupplierBankList = new List<SupplierBankObj>();
        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            if (cbbSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Supplier");
                cbbSupplier.Focus();
                return;
            }
            if (cbbBanks.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Bank");
                cbbBanks.Focus();
                return;
            }
            foreach (TextBox x in pnlBankingInfo.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(x.Text))
                {
                    MessageBox.Show("This field is required");
                    x.Focus();
                    return;
                }
            }
            SupplierBankObj Temp = new SupplierBankObj();
            Temp.Bank = BankList[cbbBanks.SelectedIndex];
            Temp.Supplier = SupplierList[cbbSupplier.SelectedIndex];
            Temp.BankBranch = EdtBankBranch.Text;
            Temp.AccountNumber = edtBankNumber.Text;
            SupplierBankList.Add(Temp);
            BankList.RemoveAt(cbbBanks.SelectedIndex);
            UpdateBankList();
        }
        public void UpdateBankList()
        {
            const int Spacing = -20;
            lstBankInfo.Items.Clear();
            lstBankInfo.Items.Add($"{"Bank",Spacing}{"Account Number",Spacing}{"Branch Number",Spacing}");
            foreach (SupplierBankObj x in SupplierBankList)
                lstBankInfo.Items.Add($"{x.Bank.BankName,Spacing}{x.AccountNumber,Spacing}{x.BankBranch,Spacing}");
        }
        private void cbbBankUpdate()
        {
            cbbBanks.Text = "";
            cbbBanks.Items.Clear();
            foreach (BankObj x in BankList)
                cbbBanks.Items.Add(x.BankName);
        }
        private void cbbSupplierUpdate()
        {
            SupplierList = new List<SupplierObj>();
            string[] IDs = DataModule.GetValues(0, "SELECT SupplierID FROM tblSupplier ");
            foreach (string x in IDs)
            {
                SupplierObj Temp = new SupplierObj();
                Temp.LoadFromDB(x);
                SupplierList.Add(Temp);
            }
            foreach (SupplierObj x in SupplierList)
                cbbSupplier.Items.Add(x.Name);
        }
        private void frmBankSupplier_Load(object sender, EventArgs e)
        {
            BankList = new List<BankObj>();
            string[] IDs = DataModule.GetValues(0, "SELECT BANKID FROM tblBank ");
            foreach (string x in IDs)
            {
                BankObj Temp = new BankObj();
                Temp.LoadFromDB(x);
                BankList.Add(Temp);
            }
            cbbBankUpdate();
            cbbSupplierUpdate();
        }

        private void frmBankSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void cbbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Only update one supplier at a time.");
            lstBankInfo.Items.Clear();
            SupplierBankList = new List<SupplierBankObj>();
            edtBankNumber.Text = "";
            EdtBankBranch.Text = "";
            if (cbbSupplier.SelectedIndex >= 0)
            {
                BankList = new List<BankObj>();
                string[] BankIDS = DataModule.GetValues(0, "SELECT BankID FROM tblBank ORDER BY BankName ASC");
                foreach (string x in BankIDS)
                {
                    BankObj Temp = new BankObj();
                    Temp.LoadFromDB(x);
                    BankList.Add(Temp);
                }
                string[] IDs = DataModule.GetValues(0,$"SELECT BankID FROM tblSupplierBank WHERE SupplierID = {SupplierList[cbbSupplier.SelectedIndex].SupplierID}");
                foreach (string x in IDs)
                {
                    SupplierBankObj Temp = new SupplierBankObj();
                    int Index = SearchBank(x);
                    Temp.LoadFromDB(BankList[Index], SupplierList[cbbSupplier.SelectedIndex]) ;
                    SupplierBankList.Add(Temp);
                    BankList.RemoveAt(Index);
                }
                cbbBankUpdate();
                UpdateBankList();
            }
        }
        private int SearchBank(string BankIn)
        {
            int x = 0;
            bool bLooking = true;
            while (bLooking && x < BankList.Count)
                if (bLooking = BankList[x].BankID != BankIn)
                    x++;
            if (bLooking)
                return -1;
            return x;
        }
        private BankObj SearchBank(BankObj BankIn)
        {
            int x = 0;
            bool bLooking = true;
            while (bLooking && x < BankList.Count)
                if (bLooking = !BankList[x].Equals(BankIn))
                    x++;
            if (bLooking)
                return null;
            return BankList[x];
        }
        private void btnRemoveInfo_Click(object sender, EventArgs e)
        {
            int Index = lstBankInfo.SelectedIndex - 1;
            if (Index < 0)
            {
                MessageBox.Show("Please Select a Bank to Remove");
                lstBankInfo.Focus();
                return;
            }
            BankList.Add(SupplierBankList[Index].Bank);
            SupplierBankList.RemoveAt(Index);
            UpdateBankList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbbSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Supplier");
                cbbSupplier.Focus();
                return;
            }
            if (DataModule.ExecuteSQL($"DELETE FROM tblSupplierBank WHERE SupplierID = {SupplierList[cbbSupplier.SelectedIndex]}")<0)
            {
                foreach (SupplierBankObj x in SupplierBankList)
                    x.InsertSelf();
                MessageBox.Show("Updated Successfull");
            }

        }
    }
}
