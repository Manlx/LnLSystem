//Manuel A Nunes 34551875
using System.Windows.Forms;

namespace LnLBackEndSystem
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
            memOutput.Text = Text;
        }
    }
}
