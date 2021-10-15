//Manuel A Nunes 34551875 Carla Pretorius 36184950
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            frmMain DbEditor = new frmMain();
            this.Hide();
            tmrSplash.Enabled = false;
            DbEditor.Show();
        }
        private static bool HasShow = false;
        private void frmSplash_Load(object sender, EventArgs e)
        {
            imgBack.Width = this.Width;
            imgBack.Height = this.Height;
            tmrSplash.Enabled = true;
            tmrSplash.Interval = 1000;
            frmMain.FormOwner = this;
            //if (DataModule.OpenConnection())
            //    MessageBox.Show("Success");
            //else
            //    MessageBox.Show("eish");
        }
        private void frmSplash_Activated(object sender, EventArgs e)
        {
            if (HasShow)
                Application.Exit();
            HasShow = true;
        }
    }
}
