//Manuel A Nunes 34551875
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
    public partial class frmBankPage : Form
    {
        public static Form Creator;
        public frmBankPage()
        {
            InitializeComponent();
        }

        private void btnBankAdd_Click(object sender, EventArgs e)
        {
            frmBankAdd.Creator = this;
            frmBankAdd Temp = new frmBankAdd();
            this.Hide();
            Temp.Show();
        }

        private void btnRemoveBank_Click(object sender, EventArgs e)
        {
            frmBankRemove.Creator = this;
            frmBankRemove Temp = new frmBankRemove();
            this.Hide();
            Temp.Show();
        }

        private void btnUploadBank_Click(object sender, EventArgs e)
        {
            frmBankUpdate.Creator = this;
            frmBankUpdate Temp = new frmBankUpdate();
            this.Hide();
            Temp.Show();
        }

        private void frmBankPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
