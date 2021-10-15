//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;
using CypherLib;
using StaffObjAndUtils;

namespace LnLBackEndSystem
{
    public partial class frmStaffLogin : Form
    {
        public static Form Creator;
        public static StaffObj LastStaff;
        public static bool isValid;
        public frmStaffLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (edtPassword.Text == "")
            {
                MessageBox.Show("Enter password");
                return;
            }
            if (!int.TryParse(edtID.Text, out int Value))
            {
                MessageBox.Show("Invalid Value for ID");
                edtID.Focus();
                return;
            }
            LastStaff.LoadFromDB($"{Value}");
            if (isValid = LastStaff.EncryptedPassword == Cypher.Encrypt(edtPassword.Text))
            {
                MessageBox.Show($"Successfully logged in: {LastStaff.Name}");
                this.Close();
            }
            else
                MessageBox.Show($"Could not log in staff Member");
        }

        private void frmStaffLogin_Load(object sender, EventArgs e)
        {
            LastStaff = new StaffObj();
        }
    }
}
