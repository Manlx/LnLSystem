//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmLocationPage : Form
    {
        public static Form Creator;
        public frmLocationPage()
        {
            InitializeComponent();
        }

        private void frmLocationPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void BtnAddLocation_Click(object sender, EventArgs e)
        {
            frmLocationAdd.Creator = this;
            this.Hide();
            frmLocationAdd Temp = new frmLocationAdd();
            Temp.Show();
        }

        private void BtnRemoveLocation_Click(object sender, EventArgs e)
        {
            frmLocationRemove.Creator = this;
            this.Hide();
            frmLocationRemove Temp = new frmLocationRemove();
            Temp.Show();
        }

        private void BtnUpdateLocation_Click(object sender, EventArgs e)
        {
            frmLocationUpdate.Creator = this;
            this.Hide();
            frmLocationUpdate Temp = new frmLocationUpdate();
            Temp.Show();
        }
    }
}
