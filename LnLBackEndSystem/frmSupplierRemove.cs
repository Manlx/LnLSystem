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
            string[] IDs = DataModule.GetValues(0,$"SELECT SupplierID FROM tblSuppliers");
            foreach (string x in IDs)
            {
                SupplierObj Temp = new SupplierObj();
                Temp.LoadFromDB(x);
                SupplierList.Add(Temp);
            }
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
            if (lstSuppliers.SelectedIndex <0)
            {
                SupplierList[lstSuppliers.SelectedIndex].DeleteSelf();
                SupplierList.RemoveAt(lstSuppliers.SelectedIndex);
                lstSupplierUpdate();
            }
        }
    }
}
