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
    public partial class frmDatabaseManagement : Form
    {
        public static Form Creator;
        public frmDatabaseManagement()
        {
            InitializeComponent();
            int btnW = 450 / 2, btnH =450 / 2;
            foreach(Button x in Controls)
            {
                x.Height = btnH;
                x.Width = btnW;
            }
            btnInsert.Top = 0;
            btnInsert.Left = 0;
            btnUpdate.Top = 0;
            btnUpdate.Left = btnInsert.Width + 1;
            btnDelete.Top = btnInsert.Height + 1;
            btnDelete.Left = 0;
            btnView.Left = btnDelete.Width + 1;
            btnView.Top = btnUpdate.Height + 1;
        }

        private void frmDatabaseManagement_Load(object sender, EventArgs e)
        {

        }

        private void frmDatabaseManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
    }
}
