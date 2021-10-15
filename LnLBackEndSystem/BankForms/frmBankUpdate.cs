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
    public partial class frmBankUpdate : Form
    {
        public static Form Creator;
        public frmBankUpdate()
        {
            InitializeComponent();
        }

        private void frmBankUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
