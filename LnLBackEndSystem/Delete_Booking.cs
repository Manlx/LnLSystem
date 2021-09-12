using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            delete_booking.Show();
        }
    }
}
