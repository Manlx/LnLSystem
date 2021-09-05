﻿using System;
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
            
            cbbTable.Items.Clear();
            string[] temp = DataModule.GetValues<string>(0, "SHOW TABLES; ");
            for (int x = 0; x < temp.Length; x++)
                cbbTable.Items.Add(temp[x]);
        }

        private void frmDataManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LastOpened != null)
                LastOpened.Close();
            Creator.Show();
        }
        Form LastOpened = null;
        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LastOpened != null)
                LastOpened.Close();
            frmMaintainces.Creator = this;
            frmMaintainces.TableName = cbbTable.Text;
            frmMaintainces Maintance = new frmMaintainces();
            Maintance.MdiParent = this;
            Maintance.Show();
            Maintance.Top = 0;
            Maintance.Left = 0;
            LastOpened = Maintance;
        }
    }
}
