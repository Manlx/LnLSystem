using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class Secretary_form : Form
    {
        public static Form creator;
        public Secretary_form()
        {
            InitializeComponent();
        }

        private void Secretary_login_Load(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dbView, "SELECT * FROM tblStaff");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void Secretary_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
