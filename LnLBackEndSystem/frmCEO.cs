﻿//Carla Pretorius 36184950
using System;
using System.Windows.Forms;

namespace LnLBackEndSystem
{
    public partial class frmCEO : Form
    {
        public static Form Creator;
        public frmCEO()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin_form.Creator = this;
            Admin_form Admin = new Admin_form();
            Admin.Show();
            this.Hide();
        }

        private void NavigateToAccountant_Click(object sender, EventArgs e)
        {
            frmAccountantLogin.Creator = this;
            frmAccountantLogin AccLog = new frmAccountantLogin();
            AccLog.Show();
            this.Hide();
        }

        private void btnNavidateToSecretary_Click(object sender, EventArgs e)
        {
            frmSecretaryLogin.Creator = this;
            frmSecretaryLogin SecForm = new frmSecretaryLogin();
            SecForm.Show();
            this.Hide();
        }

        private void btnNavigateBartender_Click(object sender, EventArgs e)
        {
            frmBarpersonLogin.Creator = this;
            frmBarpersonLogin BarLog = new frmBarpersonLogin();
            BarLog.Show();
            this.Hide();
        }

        private void frmCEO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseLogin.Creator = this;
            WarehouseLogin WarLog = new WarehouseLogin();
            this.Hide();
            WarLog.Show();
            
        }
    }
}
