//M Tolmay 33784507
using System;
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

            if (txtPass.Text == txtConfirm_pass.Text)
            {
                   sql = "UPDATE tblStaff SET EncryptedPassword'" + Cypher.Encrypt(txtPass.Text) + "' WHERE Name ='" + txtName.Text + "' AND Surname = '" + txtSurname.Text + "' AND RankID = '" + cbRank.SelectedIndex + 1 + "'";
                   MessageBox.Show("Password updated sucessfully");
            }
            else
                MessageBox.Show("Passwords do not match");
          
           
        }

    }
}
