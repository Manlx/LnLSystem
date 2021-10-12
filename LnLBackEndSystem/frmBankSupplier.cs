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
            Temp.LoadFromDB(BankList[cbbBanks.SelectedIndex], SupplierList[cbbSupplier.SelectedIndex]) ;
        }
        
        private void frmBankSupplier_Load(object sender, EventArgs e)
        {
            string[] IDs = DataModule.GetValues(0, "SELECT BANKID WHERE FROM tblBank");
            foreach (string x in IDs)
            {
                BankObj Temp = new BankObj();
                Temp.LoadFromDB(x);
                BankList.Add(Temp);
            }
            foreach (BankObj x in BankList)
                cbbBanks.Items.Add(x.BankName);

            IDs = DataModule.GetValues(0, "SELECT BANKID WHERE FROM tblBank");
            foreach (string x in IDs)
            {
                SupplierObj Temp = new SupplierObj();
                Temp.LoadFromDB(x);
                SupplierList.Add(Temp);
            }
            foreach (SupplierObj x in SupplierList)
                cbbSupplier.Items.Add(x.Name);
        }

        private void frmBankSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
