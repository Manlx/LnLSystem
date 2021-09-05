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
    public partial class frmMain : Form
    {
        public static frmSplash FormOwner;
        frmDataManagement DataBaseManagement = new frmDataManagement();
        public frmMain()
        {
            InitializeComponent();
            frmSQLConsole.frmOwner = this;
            frmDataManagement.Creator = this;
        }

        private void frmDataBaseMaintenance_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormOwner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSQLConsole myCons = new frmSQLConsole();
            this.Hide();
            myCons.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseManagement.Show();
            this.Hide();
        }
    }
}
