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
    public partial class frmAccountantLogin : Form
    {
        public static Form Creator;
        public frmAccountantLogin()
        {
            InitializeComponent();
        }

        private void btnAccountantReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accountant_Reports.Creator = this;
            Accountant_Reports Temp = new Accountant_Reports();
            Temp.Show();
        }

        private void frmAccountantLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
