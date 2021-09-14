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
    public partial class Update_Booking : Form
    {
        public static Form update_booking;
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

        }

        private void Update_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            update_booking.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Location = 0;
            string sql = "";

            if (cbBar.Checked && cbKitchen.Checked && cbSwimmingPool.Checked && cbMusic.Checked)
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
                Location = 8;
               
            sql = "UPDATE tblEvent SET DateOfBooking = '" + monthCalendar1.SelectionRange.Start.ToShortDateString() + "' , TimeOfBooking = '" + txtTime.Text + "' , LocationID = '" + Location + "' , EventType = '" + cbType.SelectedIndex + 1 + "'";
            int sucessful = DataModule.ExecuteSQL(sql);
            if (sucessful == 1)
                MessageBox.Show("Updated sucessfully");
            else
                MessageBox.Show("Error was encountered");
        }
    }
}
