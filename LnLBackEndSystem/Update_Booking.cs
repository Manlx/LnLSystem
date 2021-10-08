//M Tolmay 33784507
using System;
using System.Windows.Forms;
using NSDataModule;

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

            string sql;
            if (lstVenues.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Location please");
                return;
            }
            MessageBox.Show(cldDate.SelectionStart.ToShortDateString());
            sql = $"UPDATE tblEvent (DateOfBooking,TimeOfBooking,LocationID,ClientID,EventType) VALUES(" +
                $"'{cldDate.SelectionStart:yyyy-MM-dd}', '{txtTime.Text}',{LocationID[lstVenues.SelectedIndex]}" +
                $",{txtClientID.Text},{EventTypes[cbType.SelectedIndex]}) WHERE ClientID = txtClientID.text";
            int sucessful = DataModule.ExecuteSQL(sql);
            Clipboard.SetText(sql);
            if (sucessful == 1)
                MessageBox.Show("Booking added sucessfully");
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
    }
 
    }

