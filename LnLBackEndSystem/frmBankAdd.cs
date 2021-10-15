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
    public partial class frmBankAdd : Form
    {
        public static Form Creator;
        public frmBankAdd()
        {
            InitializeComponent();
        }

        private void frmBankAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
