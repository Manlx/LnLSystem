//M Tolmay 33784507 Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NSDataModule;
using StaffObjAndUtils;
namespace LnLBackEndSystem
{
    public partial class Secretary_delete : Form
    {
        public static Form creator;
        public Secretary_delete()
        {
            InitializeComponent();
        }

        private void Secretary_delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStaff.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Staff member");
                lstStaff.Focus();
                return;
            }    
            if(StaffList[lstStaff.SelectedIndex].DeleteSelf())
            {
                MessageBox.Show("Deleted sucessfully");
                Secretary_delete_Load(this,new EventArgs());
            }
            else
                MessageBox.Show("Error was encountered");
        }
        List<StaffObj> StaffList;
        private void Secretary_delete_Load(object sender, EventArgs e)
        {
            lstStaff.Items.Clear();
            string[] IDS = DataModule.GetValues(0, "SELECT StaffID FROM tblStaff");
            StaffList = new List<StaffObj>();
            for (int x= 0;x < IDS.Length;x++)
            {
                StaffList.Add(new StaffObj());
                StaffList[x].LoadFromDB(IDS[x]);
                lstStaff.Items.Add($"{StaffList[x].Name,-15} {StaffList[x].SurName,-15} {StaffList[x].CellNumber,-15}");
            }
                
        }
    }
}
