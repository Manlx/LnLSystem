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
    public partial class frmConsoleSettings : Form
    {
        public frmConsoleSettings()
        {
            InitializeComponent();
        }

        private void frmConsoleSettings_Load(object sender, EventArgs e)
        {
            ttHints.SetToolTip(chkClearOnLoad,"If the window is open and closed and open again will it remember the data previously entered");
            ttHints.SetToolTip(btnApply, "Applies changes to storage");
            ttHints.SetToolTip(chkClearSQLAfterExecution, "After SQL is executed it will clear.");
            ttHints.SetToolTip(chkClearAfterSuccessOnly,"Only clear input area after SQL executed successfully");
        }
    }
}
