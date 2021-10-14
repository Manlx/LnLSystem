//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmHRAdmin : Form
    {
        public static Form Creator;
        public frmHRAdmin()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaffManagement.Creator = this;
            frmStaffManagement Temp = new frmStaffManagement();
            this.Hide();
            Temp.Show();
        }

        private void btnStaffBank_Click(object sender, EventArgs e)
        {

        }

        private void frmHRAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
