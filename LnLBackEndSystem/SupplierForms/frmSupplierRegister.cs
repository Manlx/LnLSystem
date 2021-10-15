//Manuel A Nunes 34551875
using System;
using System.Linq;
using System.Windows.Forms;
using SupplierAndUtils;

using System.Collections.Generic;
using SupplierBankUtils;

namespace LnLBackEndSystem
{
    public partial class frmSupplierRegister : Form
    {
        public static Form Creator;
        public frmSupplierRegister()
        {
            InitializeComponent();
        }
        private List<SupplierBankObj> BankSupplier = new List<SupplierBankObj>();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach(TextBox x in pnlSupplierInfo.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(x.Text))
                {
                    MessageBox.Show("This field is required");
                    x.Focus();
                    return;
                }
            }
            SupplierObj Value = new SupplierObj();
            Value.Name = EdtName.Text;
            Value.Balance = "0";
            Value.PhoneNumber = EdtPhoneNumber.Text;
            Value.Website = EdtWebsite.Text;
            Value.WarehouseContactName = EdtWarehouseContactname.Text;
            Value.InsertSelf();
            MessageBox.Show("Supplier Registered");
        }

        private void frmSupplierRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
