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

namespace LnLBackEndSystem.Misc
{
    public partial class frmHelp : Form
    {
        public static Form Creator;
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        public void LoadText(string Text)
        {
            textBox1.Text = Text;
        }
    }
}
