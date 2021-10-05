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
    public partial class Admin_signup : Form
    {
        public Admin_signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (cbFulltimeMember.Checked && cbLicence.Checked)
                sql = "INSERT INTO tblStaff VALUES('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtCellphone.Text + "', '" + 1 + "', '" + 1 + cbRank.SelectedIndex + 1 + "', '" + "')";
            else if (cbFulltimeMember.Checked)
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
    }
}
