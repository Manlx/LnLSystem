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
    public partial class Delete_Booking : Form
    {
        public static Form delete_booking;
        public Delete_Booking()
        {
            InitializeComponent();
        }

        private void Delete_Booking_Load(object sender, EventArgs e)
        {
            string[] temp = DataModule.GetValues<string>(0, "SELECT Description FROM tblEventType ; ");
            for (int x = 0; x < temp.Length; x++)
               cbType.Items.Add(temp[x]);
         

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            delete_booking.Show();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string sql = "DELETE FROM tblBooking WHERE Date ='" + monthCalendar1.SelectionRange.Start.ToShortDateString() + "' AND Time = '" + txtTime.Text + "' AND Type = '" + cbType.SelectedIndex + 1 + "'";

            int sucessful = DataModule.ExecuteSQL(sql);
            if (sucessful == 1)
                MessageBox.Show("Deleted sucessfully");
            else
                MessageBox.Show("Error was encountered");
        }
    }
}
