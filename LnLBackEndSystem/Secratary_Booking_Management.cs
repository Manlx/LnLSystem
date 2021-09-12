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
    public partial class Secratary_Booking_Management : Form
    {
        public static Form booking;
        public Secratary_Booking_Management()
        {
            InitializeComponent();
        }

        private void Secratary_Booking_Management_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Secratary_Booking_Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            booking.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Booking.update_booking = this;
            Update_Booking frmUpdate = new Update_Booking();
            frmUpdate.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Booking.delete_booking = this;
            Delete_Booking frmDelete = new Delete_Booking();
            frmDelete.Show();
            this.Hide();
        }
    }
}
