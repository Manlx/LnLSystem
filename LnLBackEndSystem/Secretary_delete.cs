﻿using System;
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
    public partial class Secretary_delete : Form
    {
        public static Form creator;
        public Secretary_delete()
        {
            InitializeComponent();
        }

        private void Secretary_delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.Show();
        }

        private void Secretary_delete_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
