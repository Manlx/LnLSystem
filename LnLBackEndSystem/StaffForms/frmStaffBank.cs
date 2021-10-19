//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using NSDataModule;
using BankObjAndUtil;
using StaffBankObjUtil;
using StaffObjAndUtils;

namespace LnLBackEndSystem
{
    public partial class frmStaffBank : Form
    {
        public static Form Creator;
        public frmStaffBank()
        {
            InitializeComponent();
        }
        private List<BankObj> BankList = new List<BankObj>();
        private List<StaffObj> StaffList = new List<StaffObj>();
        private List<StaffBankObj> StaffBankList = new List<StaffBankObj>();
        public void UpdateBankList()
        {
            const int Spacing = -20;
            lstBankInfo.Items.Clear();
            lstBankInfo.Items.Add($"{"Bank",Spacing}{"Account Number",Spacing}{"Branch Number",Spacing}");
            foreach (StaffBankObj x in StaffBankList)
                lstBankInfo.Items.Add($"{x.Bank.BankName,Spacing}{x.AccountNumber,Spacing}{x.BranchNumber,Spacing}");
        }
        private void cbbBankUpdate()
        {
            cbbBanks.Text = "";
            cbbBanks.Items.Clear();
            foreach (BankObj x in BankList)
                cbbBanks.Items.Add(x.BankName);
        }
        private void cbbStaffUpdate()
        {
            StaffList = new List<StaffObj>();
            string[] IDs = DataModule.GetValues(0, "SELECT StaffID FROM tblStaff ");
            foreach (string x in IDs)
            {
                StaffObj Temp = new StaffObj();
                Temp.LoadFromDB(x);
                StaffList.Add(Temp);
            }
            foreach (StaffObj x in StaffList)
                cbbSupplier.Items.Add(x.Name);
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbbSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Supplier");
                cbbSupplier.Focus();
                return;
            }
            if (DataModule.ExecuteSQL($"DELETE FROM tblStaffBank WHERE StaffID = {StaffList[cbbSupplier.SelectedIndex]}") < 0)
            {
                foreach (StaffBankObj x in StaffBankList)
                    x.InsertSelf();
                MessageBox.Show("Updated Successfull");
            }
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
            BankList.Add(StaffBankList[Index].Bank);
            StaffBankList.RemoveAt(Index);
            UpdateBankList();
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            if (cbbSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Staff Member");
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
            StaffBankObj Temp = new StaffBankObj();
            Temp.Bank = BankList[cbbBanks.SelectedIndex];
            Temp.Staff = StaffList[cbbSupplier.SelectedIndex];
            Temp.BranchNumber = EdtBankBranch.Text;
            Temp.AccountNumber = edtBankNumber.Text;
            StaffBankList.Add(Temp);
            BankList.RemoveAt(cbbBanks.SelectedIndex);
            UpdateBankList();
        }

        private void frmStaffBankManagement_Load(object sender, EventArgs e)
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
            cbbStaffUpdate();
        }

        private void frmStaffBank_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void cbbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Only update one supplier at a time.");
            lstBankInfo.Items.Clear();
            StaffBankList = new List<StaffBankObj>();
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
                string[] IDs = DataModule.GetValues(0, $"SELECT BankID FROM tblStaffBank WHERE StaffID = {StaffList[cbbSupplier.SelectedIndex].StaffID}");
                foreach (string x in IDs)
                {
                    StaffBankObj Temp = new StaffBankObj();
                    int Index = SearchBank(x);
                    Temp.LoadFromDB(StaffList[cbbSupplier.SelectedIndex], BankList[Index]);
                    StaffBankList.Add(Temp);
                    BankList.RemoveAt(Index);
                }
                cbbBankUpdate();
                UpdateBankList();
            }
        }
    }
}
