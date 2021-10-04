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
    public partial class Booking_Management : Form
    {
        public static Form make_booking;
        public Booking_Management()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

            sql = "INSERT INTO tblEvent VALUES('" + monthCalendar1.SelectionRange.Start.ToShortDateString() + "', '" + txtTime.Text + "', '" + Location + "', '" + 0 + "', '" + 0 + cbType.SelectedIndex + 1 + "', '" + "')";
            int sucessful = DataModule.ExecuteSQL(sql);
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Booking_Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            make_booking.Show();
        }
    }
}
