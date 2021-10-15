//M Tolmay 33784507 Manuel A Nunes 34551875
using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class BookingAdd : Form
    {
        public static Form Creator;

        public string[] LocationID;
        public string[] EventTypes;
        public BookingAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstVenues.SelectedIndex <0)
            {
                MessageBox.Show("Select a Location please");
                lstVenues.Focus();
                return;
            }
            if (DTPDate.Value < DateTime.Now)
            {
                MessageBox.Show("Please Select a proper time");
                DTPDate.Focus();
                return;
            }
            if (cbType.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select an Event Type");
                cbType.Focus();
                return;
            }    
            if (!HasSelectedClient)
            {
                MessageBox.Show("Select a user");
                btnClient.PerformClick();
                return;
            }
            string sql = $"INSERT INTO tblEvent (DateOfBooking,TimeOfBooking,LocationID,ClientID,EventType) VALUES(" +
                $"'{DTPDate.Value:yyyy-MM-dd}', '{DTPTime.Value:HH:mm}',{LocationID[lstVenues.SelectedIndex]}" +
                $",{frmClientLogin.LastClient.ClientID},{EventTypes[cbType.SelectedIndex]})";
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
            Creator.Show();
        }

        private void clsRequirements_Click(object sender, EventArgs e)
        {
            string WHERE = "WHERE ";
            for (int x = 0; x < clsRequirements.Items.Count; x++)
                if (clsRequirements.GetItemChecked(x))
                    WHERE += $" ({clsRequirements.Items[x]} = 1) AND ";
            if (WHERE.Length > 0)
                WHERE = WHERE.Remove(WHERE.Length-5, 4);
            //MessageBox.Show(WHERE);
            if (WHERE.Length <= 6)
                WHERE = "";
            string[] Values = DataModule.GetValues(0,$"SELECT Description FROM tblLocation {WHERE}");
            LocationID = DataModule.GetValues(0, $"SELECT LocationID FROM tblLocation {WHERE}");
            lstVenues.Items.Clear();
            foreach (string x in Values)
                lstVenues.Items.Add(x);
        }
        bool HasSelectedClient = false;
        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClientLogin.Creator = this;
            frmClientLogin ClientLog = new frmClientLogin();
            ClientLog.ShowDialog();
            HasSelectedClient = frmClientLogin.LastClient.DoesExist();
        }
    }
}
