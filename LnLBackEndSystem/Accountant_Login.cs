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
    public partial class Accountant_Login : Form
    {
        public static Form accountant;
        public Accountant_Login()
        {
            InitializeComponent();
        }

        private void linkToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Accountant_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            accountant.Show();
        }
    }
}
