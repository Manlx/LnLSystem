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
    }
}
