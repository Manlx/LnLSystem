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
    public partial class Secretary_form : Form
    {
        public static Form creator;
    
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
            creator.Show();
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
            Accountant_Login.accountant = this;

            Accountant_Login AccountantLogin = new Accountant_Login();
            AccountantLogin.Show();
            this.Hide();
        }
    }
}
