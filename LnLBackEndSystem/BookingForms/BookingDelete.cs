//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;
using NSDataModule;
using BookingUtil;
using System.Collections.Generic;

namespace LnLBackEndSystem
{
    public partial class BookingDelete : Form
    {
        public static Form delete_booking;
        public BookingDelete()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            delete_booking.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBookings.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a booking to remove");
                return;
            }
            if (lstBooking[lstBookings.SelectedIndex].DeleteSelfFromEvents())
            {
                MessageBox.Show("Success");
                lstBookings.Items.Clear();
                lstBooking = new List<BookingObject>();
                string[] IDs = DataModule.GetValues(0, $"SELECT EventID FROM tblEvent WHERE (DateOfBooking > '{cldTime.SelectionStart:yyyy-MM-dd}') AND ('{cldTime.SelectionEnd:yyyy-MM-dd}' > DateOfBooking)");
                foreach (string x in IDs)
                {
                    lstBooking.Add(new BookingObject());
                    lstBooking[lstBooking.Count - 1].LoadFromDB(x);
                    lstBookings.Items.Add(lstBooking[lstBooking.Count - 1].toString());
                }
            }
                
            else
                MessageBox.Show("Failure");
        }
        List<BookingObject> lstBooking;
        private void cldTime_DateSelected(object sender, DateRangeEventArgs e)
        {
            lstBookings.Items.Clear();
            lstBooking = new List<BookingObject>();
            string[] IDs = DataModule.GetValues(0, $"SELECT EventID FROM tblEvent WHERE (DateOfBooking > '{cldTime.SelectionStart:yyyy-MM-dd}') AND ('{cldTime.SelectionEnd:yyyy-MM-dd}' > DateOfBooking)");
            foreach (string x in IDs)
            {
                lstBooking.Add(new BookingObject());
                lstBooking[lstBooking.Count - 1].LoadFromDB(x);
                lstBookings.Items.Add(lstBooking[lstBooking.Count - 1].toString());
            }
        }

        private void Delete_Booking_Load(object sender, EventArgs e)
        {
            lstBooking = new List<BookingObject>();
        }
    }
}
