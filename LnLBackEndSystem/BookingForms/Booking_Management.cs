//M Tolmay 33784507 Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NSDataModule;
using BookingUtil;

namespace LnLBackEndSystem
{
    public partial class Booking_Management : Form
    {
        public static Form booking;
        public Booking_Management()
        {
            InitializeComponent();
        }
        public List<BookingObject> AllBookings;
        public List<BookingObject> lstBookingscon;
        public void InsertAllBookings()
        {
            AllBookings = new List<BookingObject>();
            string[][] Table = DataModule.GetValues("SELECT BookingID,DateOfBooking,TimeOfBooking," +
                "Location,ClientID,EventType FROM tblBooking", new int[] {0,1,2,3,4,5 });
            foreach (string[] Row in Table)
                AllBookings.Add(new BookingObject(Row[0],Row[1],Row[2],Row[3],Row[4],Row[5]));
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
                cbBookings.Items.Add($"{Row[0],-5}{Row[1],-11}{Row[2],-15}{Row[3],-20}{Row[4],-15}{Row[5],-15}{Row[6],-3}{Row[7],-15}");
            
        }
        private void Secratary_Booking_Management_Load(object sender, EventArgs e)
        {
            UpdateCheckListBox();
            lstBookingscon = new List<BookingObject>();
            InsertAllBookings();
        }
        private void Secratary_Booking_Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            booking.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookingUpdate.update_booking = this;
            BookingUpdate frmUpdate = new BookingUpdate();
            frmUpdate.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BookingDelete.delete_booking = this;
            BookingDelete frmDelete = new BookingDelete();
            frmDelete.Show();
            this.Hide();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            lstBookingscon = new List<BookingObject>();
            for (int x = 0; x < cbBookings.Items.Count; x++)
            {
                if (cbBookings.GetItemChecked(x))
                    lstBookingscon.Add(AllBookings[x]);
            }
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            foreach(BookingObject x in lstBookingscon)
            {
                string[] SQLs = x.MoveToEventTable();
                if (DataModule.ExecuteSQL(SQLs[1]) == 1) 
                    DataModule.ExecuteSQL(SQLs[0]);
                else
                {
                    MessageBox.Show("Error was encountered");
                    return;
                }
            }
            UpdateCheckListBox();
            InsertAllBookings();
            MessageBox.Show("Booking approved");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
