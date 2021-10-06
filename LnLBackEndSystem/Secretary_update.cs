using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (cbFulltime.Checked && cbLicence.Checked)
                sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , CellNumber='" + txtCell.Text + "' , HasLicense='" + 1 + "' , IsFullTimeMember='" + 1 + "' , RankID='"+  cbRank.SelectedIndex + 1 + "', '" + "'";
            else if (cbFulltime.Checked)
                sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , CellNumber='" + txtCell.Text + "' , HasLicense='" + 1 + "' , IsFullTimeMember='" + 0 + "' , RankID='"+ cbRank.SelectedIndex + 1 + "', '" + "'";
            else if (cbLicence.Checked)
                sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , CellNumber='" + txtCell.Text + "' , HasLicense='" + 0 + "' , IsFullTimeMember='" + 1 + "' , RankID='"+ cbRank.SelectedIndex + 1 + "', '" + "'";
            else
                sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , CellNumber='" + txtCell.Text + "' , HasLicense='" + 0 + "' , IsFullTimeMember='" + 0 + "' , RankID='" + cbRank.SelectedIndex + 1 + "', '" + "'";

            int sucessful = DataModule.ExecuteSQL(sql);
            DataModule.LoadTable(ref ((Secretary_form)creator).dbView, "SELECT * FROM tblStaff");
            if (sucessful == 1)
                MessageBox.Show("Updated sucessfully");
            else
                MessageBox.Show("Error was encountered");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_password.password = this;
            Forgot_password frmForget = new Forgot_password();
            frmForget.Show();
            this.Hide();
        }

        private string[] TempID;
        private void Secretary_update_Load(object sender, EventArgs e)
        {
            string[] temp = DataModule.GetValues<string>(0, "SELECT Description FROM tblStaffRank ; ");
            TempID = DataModule.GetValues(0, "SELECT RANKID FROM tblStaffRank;");
            for (int x = 0; x < temp.Length; x++)
                cbRank.Items.Add(temp[x]);
        }
    }
}
