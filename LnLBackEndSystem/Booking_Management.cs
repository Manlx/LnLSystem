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
