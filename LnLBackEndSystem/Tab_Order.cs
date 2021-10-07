//Manuel A Nunes 34551875 Brendan 32737742
using System;
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

        private void linkToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Tab_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            tabOrder.Show();
        }

        private void btnSubmitTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
