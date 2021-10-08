//M Tolmay 33784507
using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class Secretary_delete : Form
    {
        public static Form creator;
        public Secretary_delete()
        {
            InitializeComponent();
        }

        private void Secretary_delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.Show();
        }

        private void Secretary_delete_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {     
            string sql = "DELETE FROM tblStaff WHERE Name ='" + txtName.Text + "' AND EncryptedPassword = '" + txtPassword.Text + "'";

            DataGridView Temp = ((Secretary_form)creator).dbView;
            int sucessful = DataModule.ExecuteSQL(sql);
            DataModule.LoadTable(ref Temp, "SELECT * FROM tblStaff");
            if (sucessful == 1)
                MessageBox.Show("Deleted sucessfully");
            else
                MessageBox.Show("Error was encountered");
        }
    }
}
