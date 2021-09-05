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
    public partial class frmDataManagement : Form
    {
        public static Form Creator;
        public frmDataManagement()
        {
            InitializeComponent();
            cmbTable.Items.Clear();
            string[] temp = DataModule.GetValues<string>(0, "SHOW TABLES; ");
            for (int x = 0; x < temp.Length; x++)
                cmbTable.Items.Add(temp[x]);
        }

        private void frmDataManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Creator.Show();
        }
        Form LastOpened;
        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LastOpened != null)
                LastOpened.Close();
            frmMaintainces test = new frmMaintainces();
            test.MdiParent = this;
            test.Show();
            test.Top = 0;
            test.Left = 0;
            LastOpened = test;
        }

        private void frmDataManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
