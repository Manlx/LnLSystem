//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NSDataModule;
using LocationObjUtils;

namespace LnLBackEndSystem
{
    public partial class frmLocationUpdate : Form
    {
        public static Form Creator;
        public frmLocationUpdate()
        {
            InitializeComponent();
        }

        private void frmLocationUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        List<LocationObj> lstLoc = new List<LocationObj>();
        private void UpdateLocationlist()
        {
            lstLoc = new List<LocationObj>();
            string[] IDs = DataModule.GetValues(0, "SELECT LocationID From tblLocation");
            foreach (string x in IDs)
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
        private void frmLocationUpdate_Load(object sender, EventArgs e)
        {
            UpdateLocationlist();
            UpdateLstLocs();
        }
        private bool StrBitToBool(string x)
        {
            return x.Equals("1");
        }
        private void UpdateComps(LocationObj X)
        {
            EdtDescription.Text = X.Description;
            chkHasBarAccess.Checked = StrBitToBool(X.HasBarAccess);
            chkHasKitchenAcces.Checked = StrBitToBool(X.HasKitchenAccess);
            chkHasLakeAccess.Checked = StrBitToBool(X.HasLakeAccess);
            chkHasMusicAccess.Checked = StrBitToBool(X.HasMusicSetup);
            chkHasStage.Checked = StrBitToBool(X.HasStage);
            chkIsOutdoors.Checked = StrBitToBool(X.IsOutdoors);
            chkSwimmingPool.Checked = StrBitToBool(X.HasSwimmingPool);
        }
        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLocations.SelectedIndex >= 0)
                UpdateComps(lstLoc[lstLocations.SelectedIndex]);  
        }
        private static string BoolToBit(bool Value)
        {
            return (Value) ? "1" : "0";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EdtDescription.Text))
            {
                MessageBox.Show("Please enter a discription");
                EdtDescription.Focus();
                return;
            }
            lstLoc[lstLocations.SelectedIndex].Description = EdtDescription.Text;
            lstLoc[lstLocations.SelectedIndex].HasBarAccess = BoolToBit(chkHasBarAccess.Checked);
            lstLoc[lstLocations.SelectedIndex].HasKitchenAccess = BoolToBit(chkHasKitchenAcces.Checked);
            lstLoc[lstLocations.SelectedIndex].HasLakeAccess = BoolToBit(chkHasLakeAccess.Checked);
            lstLoc[lstLocations.SelectedIndex].HasMusicSetup = BoolToBit(chkHasMusicAccess.Checked);
            lstLoc[lstLocations.SelectedIndex].HasStage = BoolToBit(chkHasStage.Checked);
            lstLoc[lstLocations.SelectedIndex].HasSwimmingPool = BoolToBit(chkSwimmingPool.Checked);
            lstLoc[lstLocations.SelectedIndex].IsOutdoors = BoolToBit(chkIsOutdoors.Checked);
            if (lstLoc[lstLocations.SelectedIndex].UpdateSelf())
                MessageBox.Show("Update Successfull");
            else
                MessageBox.Show("Update Failed");
            UpdateLocationlist();
            UpdateLstLocs();
        }
    }
}
