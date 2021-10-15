// M Tolmay 33784507
using System;
using System.Windows.Forms;
using NSDataModule;
using StaffObjAndUtils;
using CypherLib;

namespace LnLBackEndSystem
{
    public partial class Secretary_update : Form
    {
        public static Form creator;
        public Secretary_update()
        {
            InitializeComponent();
        }

        private void Secretary_update_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmStaffLogin.Creator = this;
            frmStaffLogin StaffLog = new frmStaffLogin();
            StaffLog.ShowDialog();
            if (!frmStaffLogin.LastStaff.IsValid())
            {
                MessageBox.Show("No user Selected");
                return;
            }
            if (txtCell.Text != "")
                frmStaffLogin.LastStaff.CellNumber = txtCell.Text;
            if (txtName.Text != "")
                frmStaffLogin.LastStaff.Name = txtName.Text;
            if (txtPassword.Text != "")
                frmStaffLogin.LastStaff.EncryptedPassword = Cypher.Encrypt(txtPassword.Text);
            if (txtSurname.Text != "")
                frmStaffLogin.LastStaff.SurName = txtSurname.Text;
            if (cbRank.SelectedIndex >= 0)
            {
                string[] Ranks = DataModule.GetValues(0, "SELECT RankID FROM tblStaffRank ;");
                frmStaffLogin.LastStaff.RankID = Ranks[cbRank.SelectedIndex];
            }
            frmStaffLogin.LastStaff.IsFullTimeMember = cbFulltime.Checked;
            frmStaffLogin.LastStaff.HasLicense = cbLicence.Checked;
            if (frmStaffLogin.LastStaff.UpdateSelf())
                MessageBox.Show("Updated sucessfully");
            else
                MessageBox.Show("Error was encountered");
        }
        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_password.password = this;
            Forgot_password frmForget = new Forgot_password();
            frmForget.Show();
            this.Hide();
        }

        private void Secretary_update_Load(object sender, EventArgs e)
        {
            string[] temp = DataModule.GetValues<string>(0, "SELECT Description FROM tblStaffRank ; ");
            for (int x = 0; x < temp.Length; x++)
                cbRank.Items.Add(temp[x]);
        }
    }
}
