//Manuel A Nunes 348551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SupplierAndUtils;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmSupplierRemove : Form
    {
        public static Form Creator;
        public frmSupplierRemove()
        {
            InitializeComponent();
        }
        private List<SupplierObj> SupplierList = new List<SupplierObj>();
        private void frmSupplierRemove_Load(object sender, EventArgs e)
        {
            string[] IDs = DataModule.GetValues(0,$"SELECT SupplierID FROM tblSupplier");
            foreach (string x in IDs)
            {
                SupplierObj Temp = new SupplierObj();
                Temp.LoadFromDB(x);
                SupplierList.Add(Temp);
            }
            lstSuppliers.Items.Clear();
            foreach (SupplierObj x in SupplierList)
                lstSuppliers.Items.Add(x.Name);
        }
        public void lstSupplierUpdate()
        {
            lstSuppliers.Items.Clear();
            foreach (SupplierObj x in SupplierList)
                lstSuppliers.Items.Add(x.Name);
        }

        private void frmSupplierRemove_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lstSuppliers.SelectedIndex >=0)
            {
                if (SupplierList[lstSuppliers.SelectedIndex].DeleteSelf())
                    MessageBox.Show("Supplier Delete");
                SupplierList.RemoveAt(lstSuppliers.SelectedIndex);
                lstSupplierUpdate();
                return;
            }
            MessageBox.Show("Please Select the Supplier");
            lstSuppliers.Focus();
        }
    }
}
