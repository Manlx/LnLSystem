﻿//M Tolmay 33784507
using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class Booking_Management : Form
    {
        public static Form make_booking;

        public string[] LocationID;
        public string[] EventTypes;
        public Booking_Management()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstVenues.SelectedIndex <0)
            {
                MessageBox.Show("Select a Location please");
                return;
            }
            string sql = $"INSERT INTO tblEvent (DateOfBooking,TimeOfBooking,LocationID,ClientID,EventType) VALUES(" +
                $"'{cldDate.SelectionStart:yyyy-MM-dd}', '{txtTime.Text}',{LocationID[lstVenues.SelectedIndex]}" +
                $",{txtClientID.Text},{EventTypes[cbType.SelectedIndex]})";
            int sucessful = DataModule.ExecuteSQL(sql);
            Clipboard.SetText(sql);
            if (sucessful == 1)
                MessageBox.Show("Booking added sucessfully");
            else
                MessageBox.Show("Error was encountered");
        }

        private void Booking_Management_Load(object sender, EventArgs e)
        {
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Booking_Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            make_booking.Show();
        }

        private void clsRequirements_Click(object sender, EventArgs e)
        {
            string WHERE = "WHERE ";
            for (int x = 0; x < clsRequirements.Items.Count; x++)
                if (clsRequirements.GetItemChecked(x))
                    WHERE += $" ({clsRequirements.Items[x]} = 1) AND ";
            if (WHERE.Length > 0)
                WHERE = WHERE.Remove(WHERE.Length-5, 4);
            if (WHERE.Length <= 6)
                WHERE = "";
            string[] Values = DataModule.GetValues(0,$"SELECT Description FROM tblLocation {WHERE}");
            LocationID = DataModule.GetValues(0, $"SELECT LocationID FROM tblLocation {WHERE}");
            lstVenues.Items.Clear();
            foreach (string x in Values)
                lstVenues.Items.Add(x);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstVenues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHeadings_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void cldDate_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFacilities_Click(object sender, EventArgs e)
        {

        }

        private void clsRequirements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
