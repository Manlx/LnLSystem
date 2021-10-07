//M Tolmay 33784507
using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class Secretary_form : Form
    {
        public static Form Creator;
    
        public Secretary_form()
        {
            InitializeComponent();
        }

        private void Secretary_login_Load(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dbView, "SELECT * FROM tblStaff");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Secretary_insert.creator = this;
            Secretary_insert frmInsert = new Secretary_insert();
            frmInsert.Show();
            this.Hide();
        }

        private void Secretary_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Creator.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Secretary_update.creator = this;
            Secretary_update frmUpdate = new Secretary_update();
            frmUpdate.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Secretary_delete.creator = this;
            Secretary_delete frmDelete = new Secretary_delete();
            frmDelete.Show();
            this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Secratary_Booking_Management.booking = this;
            Secratary_Booking_Management frmBooking = new Secratary_Booking_Management();
            frmBooking.Show();
            this.Hide();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Accountant_Login.Creator = this;

            Accountant_Login AccountantLogin = new Accountant_Login();
            AccountantLogin.Show();
            this.Hide();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            Booking_Management.Creator = this;
            Booking_Management frmBookMan = new Booking_Management();
            frmBookMan.Show();
            this.Hide();
        }
    }
}
