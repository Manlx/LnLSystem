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
    public partial class Secratary_Booking_Management : Form
    {
        public static Form booking;
        public Secratary_Booking_Management()
        {
            InitializeComponent();
        }
        private void UpdateCheckListBox()
        {
            string[][] tblBookings = DataModule.GetValues("SELECT BookingID,DATE_FORMAT(DateOfBooking,'%d-%m-%Y'),TimeOfBooking,tblLocation.Description,tblClient.Name,tblClient.Surname,tblClient.IsBlackList,tblEventType.Description " +
                            "FROM tblBooking " +
                            "INNER JOIN tblLocation " +
                            "ON tblBooking.Location = tblLocation.LocationID " +
                            "INNER JOIN tblClient " +
                            "ON tblBooking.ClientID = tblClient.ClientID " +
                            "INNER JOIN tblEventType " +
                            "ON tblBooking.EventType = tblEventType.EventType ", new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });
            cbBookings.Items.Clear();
            foreach (string[] Row in tblBookings)
            {
                cbBookings.Items.Add($"{Row[0],-5}{Row[1],-11}{Row[2],-15}{Row[3],-20}{Row[4],-15}{Row[5],-15}{Row[6],-3}{Row[7],-15}");
            }
        }
        private void Secratary_Booking_Management_Load(object sender, EventArgs e)
        {

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            UpdateCheckListBox();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Secratary_Booking_Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            booking.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Booking.update_booking = this;
            Update_Booking frmUpdate = new Update_Booking();
            frmUpdate.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Booking.delete_booking = this;
            Delete_Booking frmDelete = new Delete_Booking();
            frmDelete.Show();
            this.Hide();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            MessageBox.Show("Booking approved");
        }
    }
}
