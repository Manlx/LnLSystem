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
using CypherLib;

namespace LnLBackEndSystem
{
    public partial class Forgot_password : Form
    {
        public static Form password;
        public Forgot_password()
        {
            InitializeComponent();
        }

        private void Forgot_password_Load(object sender, EventArgs e)
        {
            cbRank.Items.Clear();
            string[] temp = DataModule.GetValues<string>(0, "SELECT Description FROM tblStaffRank ; ");
            for (int x = 0; x < temp.Length; x++)
                cbRank.Items.Add(temp[x]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forgot_password_FormClosing(object sender, FormClosingEventArgs e)
        {
            password.Show();
        }

        private void cbRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string sql = "";
            string password = txtPass.Text;

            if (txtPass.Text == txtConfirm_pass.Text)
            {
                   sql = "UPDATE tblStaff SET Name ='" + txtName.Text + "' , Surname='" + txtSurname.Text + "' , RankID='" + cbRank.SelectedIndex + "', EncryptedPassword'" + Cypher.Encrypt(txtPass.Text) + "'";
            }
            else
                MessageBox.Show("Passwords do not match");
        }
    }
}
