//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmStaffManagement : Form
    {
        public static Form Creator;
        public frmStaffManagement()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Secretary_delete.creator = this;
            Secretary_delete frmDelete = new Secretary_delete();
            frmDelete.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Secretary_update.creator = this;
            Secretary_update frmUpdate = new Secretary_update();
            frmUpdate.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Secretary_insert.creator = this;
            Secretary_insert frmInsert = new Secretary_insert();
            frmInsert.Show();
            this.Hide();
        }

        private void frmStaffManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
