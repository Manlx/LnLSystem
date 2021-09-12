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
    public partial class Guest_form : Form
    {
        public static Form guest;
        public Guest_form()
        {
            InitializeComponent();
        }

        private void Guest_form_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guest_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            guest.Show();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            Booking_Management.make_booking = this;
            Booking_Management frmMakeBooking = new Booking_Management();
            frmMakeBooking.Show();
            this.Hide();
        }
    }
}
