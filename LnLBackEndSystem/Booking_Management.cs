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
using NSTableAndUtil;

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
            int Location = 0;
            string sql = "";

            /*if (cbBar.Checked && cbKitchen.Checked && cbSwimmingPool.Checked && cbMusic.Checked)
                Location = 1;
            if (cbOutdoors.Checked && cbBar.Checked && cbLake.Checked && cbSwimmingPool.Checked)
                Location = 2;
            if (cbOutdoors.Checked && cbBar.Checked && cbLake.Checked)
                Location = 3;
            if (cbOutdoors.Checked && cbBar.Checked && cbKitchen.Checked && cbLake.Checked && cbMusic.Checked)
                Location = 4;
            if (cbOutdoors.Checked)
                Location = 5;
            if (cbOutdoors.Checked && cbBar.Checked && cbKitchen.Checked && cbMusic.Checked)
                Location = 6;
            if (cbBar.Checked && cbKitchen.Checked)
                Location = 7;
            if (cbOutdoors.Checked && cbBar.Checked)
                Location = 8;*/

            sql = $"INSERT INTO tblEvent (DateOfBooking,TimeOfBooking,LocationID,ClientID,EventType) VALUES('" + cldDate.SelectionRange.Start.ToShortDateString() + "', '" + txtTime.Text + "', '" + Location + "', '" + 0 + "', '" + 0 + cbType.SelectedIndex + 1 + "', '" + "')";
            if (lstVenues.SelectedIndex <0)
            {
                MessageBox.Show("Select a Location please");
                return;
            }
            sql = $"INSERT INTO tblEvent (DateOfBooking,TimeOfBooking,LocationID,ClientID,EventType) VALUES(" +
                $"'{cldDate.SelectionStart.ToString("yyyy-MM-dd")}', '{txtTime.Text}',{LocationID[lstVenues.SelectedIndex]}" +
                $",{txtClientID.Text},{EventTypes[cbType.SelectedIndex]})";
            int sucessful = DataModule.ExecuteSQL(sql);
            Clipboard.SetText(sql);
            if (sucessful == 1)
                MessageBox.Show("Booking added sucessfully");
            else
                MessageBox.Show("Error was encountered");
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                    WHERE += $" ({clsRequirements.Items[x].ToString()} = 1) AND ";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblHeadings_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
