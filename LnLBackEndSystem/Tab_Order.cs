﻿using System;
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
    public partial class Tab_Order : Form
    {
        public static Form tabOrder;
        public Tab_Order()
        {
            InitializeComponent();
        }

        private void btnMakeTabPurchase_Click(object sender, EventArgs e)
        {
            Guest_form.guest = this;
            Guest_form frmGuestForm = new Guest_form();
            frmGuestForm.Show();
            this.Hide();
        }

        private void linkToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Tab_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            tabOrder.Show();
        }
    }
}
