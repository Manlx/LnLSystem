//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NSDataModule;
using SupplierAndUtils;
namespace LnLBackEndSystem
{
    public partial class frmSupplierUpdate : Form
    {
        public static Form Creator;
        private List<SupplierObj> SupplierList = new List<SupplierObj>();
        public frmSupplierUpdate()
        {
            InitializeComponent();
        }
        private void UpdateComps(SupplierObj Supplier)
        {
            edtName.Text = Supplier.Name;
            edtContactName.Text = Supplier.WarehouseContactName;
            edtPhoneNumber.Text = Supplier.PhoneNumber;
            edtWebsite.Text = Supplier.Website;
        }
        private void frmSupplierUpdate_Load(object sender, EventArgs e)
        {
            string[] IDs = DataModule.GetValues(0, "SELECT SupplierID FROM tblSupplier");
            foreach(string x in IDs)
            {
                SupplierObj Temp = new SupplierObj();
                Temp.LoadFromDB(x);
                SupplierList.Add(Temp);
            }
            lstSuppliers.Items.Clear();
            foreach (SupplierObj x in SupplierList)
                lstSuppliers.Items.Add(x.Name);
        }

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuppliers.SelectedIndex >= 0)
                UpdateComps(SupplierList[lstSuppliers.SelectedIndex]);
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            foreach(TextBox x in this.Controls.OfType<TextBox>())
            {
                if (x.Text == "")
                {
                    MessageBox.Show("Please Enter this value.");
                    x.Focus();
                    return;
                }
            }
            SupplierList[lstSuppliers.SelectedIndex].Name = edtName.Text;
            SupplierList[lstSuppliers.SelectedIndex].PhoneNumber = edtPhoneNumber.Text;
            SupplierList[lstSuppliers.SelectedIndex].WarehouseContactName = edtContactName.Text;
            SupplierList[lstSuppliers.SelectedIndex].Website = edtWebsite.Text;
            if (SupplierList[lstSuppliers.SelectedIndex].UpdateSelf())
                MessageBox.Show("Update Successfully");
            else
                MessageBox.Show("Update Failed");
        }
    }
}
