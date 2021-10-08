//M Tolmay 33784507
using System;
using System.Windows.Forms;
using NSDataModule;
using BookingUtil;
using System.Collections.Generic;

namespace LnLBackEndSystem
{
    public partial class Update_Booking : Form
    {
        public static Form update_booking;

        public string[] LocationID;
        public string[] EventTypes;
        public Update_Booking()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Booking_Load(object sender, EventArgs e)
        {
            lstBook = new List<BookingObject>();
            gpbOptions.Enabled = false;
            cbType.Items.Clear();
            string[] temp = DataModule.GetValues<string>(0, "SELECT Description FROM tblEventType ; ");
            for (int x = 0; x < temp.Length; x++)
                cbType.Items.Add(temp[x]);
            EventTypes = DataModule.GetValues(0, "SELECT EventType FROM tblEventType ; ");
            clsRequirements.Items.Clear();
            string[] Values = DataModule.GetValues(0, "SHOW COLUMNS FROM tblLocation WHERE Type = 'Bit(1)'");
            foreach (string item in Values)
                clsRequirements.Items.Add(item);
            clsRequirements_Click(clsRequirements, new EventArgs());
        }

        private void Update_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            update_booking.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstBooking.SelectedIndex < 0)
            {
                MessageBox.Show("Select a booking to change");
                return;
            }
            lstBook[lstBooking.SelectedIndex].TimeOfBooking = $"{DTPTime.Value:HH:mm}";
            lstBook[lstBooking.SelectedIndex].DateOfBooking = $"{DTPTime.Value:yyyy-MM-dd}";
            if (cbType.SelectedIndex >= 0)
                lstBook[lstBooking.SelectedIndex].EventType = $"{EventTypes[cbType.SelectedIndex]}";
            if (cbType.SelectedIndex >= 0)
                lstBook[lstBooking.SelectedIndex].EventType = EventTypes[cbType.SelectedIndex];
            if (lstVenues.SelectedIndex >= 0)
                lstBook[lstBooking.SelectedIndex].Location = LocationID[lstVenues.SelectedIndex];

            if (lstBook[lstBooking.SelectedIndex].UpdateSelfInEvent())
            {
                MessageBox.Show("Booking added sucessfully");
                if (!frmClientLogin.LastClient.DoesExist())
                {
                    MessageBox.Show("No Client Selected");
                    return;
                }
                lstBooking.Items.Clear();
                string[] Bookings = DataModule.GetValues(0, $"SELECT EventID FROM tblEvent WHERE ClientID = {frmClientLogin.LastClient.ClientID}");
                foreach (string x in Bookings)
                {
                    lstBook.Add(new BookingObject());
                    lstBook[lstBook.Count - 1].LoadFromDB(x);
                    lstBooking.Items.Add(lstBook[lstBook.Count - 1].toString());
                }
                gpbOptions.Enabled = true;
            }
            else
                MessageBox.Show("Error was encountered");
        }

        private void clsRequirements_Click(object sender, EventArgs e)
        {
            string WHERE = "WHERE ";
            for (int x = 0; x < clsRequirements.Items.Count; x++)
                if (clsRequirements.GetItemChecked(x))
                    WHERE += $" ({clsRequirements.Items[x]} = 1) AND ";
            if (WHERE.Length > 0)
                WHERE = WHERE.Remove(WHERE.Length - 5, 4);
            //MessageBox.Show(WHERE);
            if (WHERE.Length <= 6)
                WHERE = "";
            string[] Values = DataModule.GetValues(0, $"SELECT Description FROM tblLocation {WHERE}");
            LocationID = DataModule.GetValues(0, $"SELECT LocationID FROM tblLocation {WHERE}");
            lstVenues.Items.Clear();
            foreach (string x in Values)
                lstVenues.Items.Add(x);
        }

        List<BookingObject> lstBook;
        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            
            frmClientLogin.Creator = this;
            frmClientLogin ClienTog = new frmClientLogin();
            ClienTog.ShowDialog();
            if (!frmClientLogin.LastClient.DoesExist())
            {
                MessageBox.Show("No Client Selected");
                return;
            }
            string[] Bookings = DataModule.GetValues(0, $"SELECT EventID FROM tblEvent WHERE ClientID = {frmClientLogin.LastClient.ClientID}");
            foreach(string x in Bookings)
            {
                lstBook.Add(new BookingObject());
                lstBook[lstBook.Count - 1].LoadFromDB(x);
                lstBooking.Items.Add(lstBook[lstBook.Count - 1].toString());
            }
            gpbOptions.Enabled = true;
        }
        private void gpbOptions_Enter(object sender, EventArgs e)
        {

        }
    }
 
}

