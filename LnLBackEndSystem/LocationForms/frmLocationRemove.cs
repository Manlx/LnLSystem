//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LocationObjUtils;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmLocationRemove : Form
    {
        public static Form Creator;
        public frmLocationRemove()
        {
            InitializeComponent();
        }

        private void frmLocationRemove_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        List<LocationObj> lstLoc = new List<LocationObj>();
        private void UpdateLocationlist()
        {
            lstLoc = new List<LocationObj>();
            string[] IDs = DataModule.GetValues(0,"SELECT LocationID From tblLocation");           
            foreach(string x in IDs)
            {
                LocationObj Temp = new LocationObj();
                Temp.LoadFromDB(x);
                lstLoc.Add(Temp);
            }
        }
        private void UpdateLstLocs()
        {
            lstLocations.Items.Clear();
            foreach (LocationObj X in lstLoc)
                lstLocations.Items.Add(X.Description);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLocations.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Location To Remove");
                lstLocations.Focus();
                return;
            }
            if (MessageBox.Show("Are you sure you want to remove?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (lstLoc[lstLocations.SelectedIndex].DeleteSelf())
                    MessageBox.Show("Removed Successfully");
                else
                    MessageBox.Show("Removed failed Successfully");
            UpdateLocationlist();
            UpdateLstLocs();
        }

        private void frmLocationRemove_Load(object sender, EventArgs e)
        {
            UpdateLocationlist();
            UpdateLstLocs();
        }
    }
}
