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
            string sql = "";
            if (cbFulltime.Checked && cbLicence.Checked)
                sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 1 + "', '" +  1 + cbRank.SelectedIndex + 1 + "', '" + "')";
            else if (cbFulltime.Checked)
                sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 1 + "', '" + 0 + cbRank.SelectedIndex + 1 + "', '" + "')";
            else if (cbLicence.Checked)
                sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 0 + "', '" + 1 + cbRank.SelectedIndex + 1 + "', '" + "')";
            else
                sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 0 + "', '" + 0 + cbRank.SelectedIndex + 1 + "', '" + "')";

            int sucessful = DataModule.ExecuteSQL(sql);
            if (sucessful == 1)
                MessageBox.Show("Added sucessfully");
            else
                MessageBox.Show("Error was encountered");


        }

        private void Secretary_insert_Load(object sender, EventArgs e)
        {
            string[] temp = DataModule.GetValues<string>(0, "SELECT Description FROM tblStaffRank ; ");
            for (int x = 0; x < temp.Length; x++)
                cbRank.Items.Add(temp[x]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
