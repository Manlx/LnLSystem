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
    public partial class frmDataBaseMaintenance : Form
    {
        public static frmSplash FormOwner;
        public frmDataBaseMaintenance()
        {
            InitializeComponent();
            frmSQLConsole.frmOwner = this;
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
    }
}
