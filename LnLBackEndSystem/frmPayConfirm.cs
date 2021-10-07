//Manuel A Nunes 34551875 2021-05-06
using System;
using System.Windows.Forms;
using NSDataModule;
using CypherLib;

namespace LnLBackEndSystem
{
    public partial class frmPayConfirm : Form
    {
        public static Form Creator;
        public frmPayConfirm()
        {
            InitializeComponent();
        }
        public static bool isVerified;
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (edtPassword.Text == String.Empty)
            {
                MessageBox.Show("Please enter a password");
                edtPassword.Focus();
            }
            if (edtStaffID.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Staff ID");
                edtStaffID.Focus();
            }
            string Password = DataModule.GetValue<string>(0,$"SELECT EncryptedPassword from tblStaff WHERE StaffID = {edtStaffID.Text}");
            isVerified = edtPassword.Text == Cypher.Decrypt(Password);
            if (isVerified)
            {
                MessageBox.Show("Thank you for your payment");
                this.Close();
            }
            else
                MessageBox.Show("Invalid Credentials");
        }

        private void frmPayConfirm_Load(object sender, EventArgs e)
        {
            isVerified = false;
            edtStaffID.Focus();
        }
    }
}
