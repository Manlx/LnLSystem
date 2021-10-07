// M Tolmay 33784507
using System;
using System.Windows.Forms;
using NSDataModule;

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
            string sql;

            if (cbFulltime.Checked && cbLicence.Checked)
                sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , CellNumber='" + txtCell.Text + "' , HasLicense='" + 1 + "' , IsFullTimeMember='" + 1 + "' , RankID='"+  cbRank.SelectedIndex + 1 + "', '" + "'";
            else if (cbFulltime.Checked)
                sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , CellNumber='" + txtCell.Text + "' , HasLicense='" + 1 + "' , IsFullTimeMember='" + 0 + "' , RankID='"+ cbRank.SelectedIndex + 1 + "', '" + "'";
            else if (cbLicence.Checked)
                sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , CellNumber='" + txtCell.Text + "' , HasLicense='" + 0 + "' , IsFullTimeMember='" + 1 + "' , RankID='"+ cbRank.SelectedIndex + 1 + "', '" + "'";
            else
                sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , CellNumber='" + txtCell.Text + "' , HasLicense='" + 0 + "' , IsFullTimeMember='" + 0 + "' , RankID='" + cbRank.SelectedIndex + 1 + "', '" + "'";

            int sucessful = DataModule.ExecuteSQL(sql);
            DataGridView Temp = ((Secretary_form)creator).dbView;
            DataModule.LoadTable(ref Temp, "SELECT * FROM tblStaff");
            if (sucessful == 1)
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
