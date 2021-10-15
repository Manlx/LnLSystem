//Madelein Tolmay 33784507 Manuel A Nunes 34551875
using System;
using System.Windows.Forms;
using NSDataModule;
using CypherLib;
using StaffObjAndUtils;
namespace LnLBackEndSystem
{
    public partial class Secretary_insert : Form
    {
        public static Form creator;

        public Secretary_insert()
        {
            InitializeComponent();
        }

        private void Secretary_insert_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Manuel A Nunes 34551875 Adjusted the SQL to work
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Fill in Name");
                txtName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Please Fill in Surname");
                txtSurname.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCellphone.Text))
            {
                MessageBox.Show("Please Fill in Cellphone Number");
                txtCellphone.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Fill in Password");
                txtPassword.Focus();
                return;
            }
            StaffObj NewStaff = new StaffObj() { CellNumber = txtCellphone.Text,
                EncryptedPassword= Cypher.Encrypt(txtPassword.Text),HasLicense=cbLicence.Checked,
                IsFullTimeMember = cbFulltime.Checked,Name = txtName.Text,RankID = TempID[cbRank.SelectedIndex],SurName = txtSurname.Text };
            bool wasSuccess = NewStaff.InsertSelf();

            if (wasSuccess)
            {
                MessageBox.Show("Added sucessfully");
                MessageBox.Show($"Staff ID: {DataModule.GetValue(0,$"SELECT StaffID FROM tblStaff WHERE (Surname = '{NewStaff.SurName}')AND (Name = '{NewStaff.Name}') AND (CellNumber = '{NewStaff.CellNumber}') ")}");
            }    
                
            else
                MessageBox.Show("Error was encountered");

        }
        private string[] TempID;
        private void Secretary_insert_Load(object sender, EventArgs e)
        {
            string[] temp = DataModule.GetValues<string>(0, "SELECT Description FROM tblStaffRank ; ");
            TempID = DataModule.GetValues(0, "SELECT RANKID FROM tblStaffRank;");
            for (int x = 0; x < temp.Length; x++)
                cbRank.Items.Add(temp[x]);
        }
    }
}
