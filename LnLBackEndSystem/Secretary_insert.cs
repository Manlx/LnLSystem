//Madelein Tolmay 33784507
using System;
using System.Windows.Forms;
using NSDataModule;
using CypherLib;
using NSTableAndUtil;
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
            string sql = "";
            sql = $"INSERT INTO tblStaff (Name,Surname,CellNumber,HasLicense,IsFullTimeMember,RankID,EncryptedPassword) " +
                $"VALUES('{txtName.Text}','{txtSurname.Text}','{txtCellphone.Text}',{Utilities.BoolToBit(cbLicence.Checked)}," +
                $"{Utilities.BoolToBit(cbFulltime.Checked)},{TempID[cbRank.SelectedIndex]},'{Cypher.Encrypt( txtPassword.Text)}');";
            //if (cbFulltime.Checked && cbLicence.Checked)
            //    sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 1 + "', '" +  1 + cbRank.SelectedIndex + 1 + "', '" + "')";
            //else if (cbFulltime.Checked)
            //    sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 1 + "', '" + 0 + cbRank.SelectedIndex + 1 + "', '" + "')";
            //else if (cbLicence.Checked)
            //    sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 0 + "', '" + 1 + cbRank.SelectedIndex + 1 + "', '" + "')";
            //else
            //    sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 0 + "', '" + 0 + cbRank.SelectedIndex + 1 + "', '" + "')";
            int sucessful = DataModule.ExecuteSQL(sql);
            DataModule.LoadTable(ref ((Secretary_form)creator).dbView, "SELECT * FROM tblStaff");
            if (sucessful == 1)
                MessageBox.Show("Added sucessfully");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
