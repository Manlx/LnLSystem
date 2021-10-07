//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;
using CypherLib;
using ClientAndUtils;

namespace LnLBackEndSystem
{
    public partial class frmClientLogin : Form
    {
        public static Form Creator;
        public static ClientObj LastClient;
        public static bool CorrectUser;
        public frmClientLogin()
        {
            InitializeComponent();
            LastClient = new ClientObj();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (edtPassword.Text == "")
            {
                MessageBox.Show("Enter password");
                return;
            }
            if(!int.TryParse(edtID.Text,out int Value))
            {
                MessageBox.Show("ID is not valid");
                edtID.Focus();
            }

            LastClient.LoadFromDB($"{Value}");
            if (!LastClient.IsValid())
            {
                MessageBox.Show("Failed to Load Client Error 000-000-002");
                return;
            }
            if (CorrectUser = LastClient.Password == Cypher.Encrypt(edtPassword.Text))
            {
                MessageBox.Show($"User: {LastClient.Name} logged in.");
                this.Close();
            }
            else
                MessageBox.Show("Failed to login with current credentials");
        }

        private void frmClientLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
