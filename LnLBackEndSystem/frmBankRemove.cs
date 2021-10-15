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
    public partial class frmBankRemove : Form
    {
        public static Form Creator;
        public frmBankRemove()
        {
            InitializeComponent();
        }

        private void frmBankRemove_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
