//Brendan Viljoen 32737742
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
    public partial class Warehouse_Restock : Form
    {
        public static Form Creator;
        public Warehouse_Restock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgViewWarehouse, "SELECT StockName,DateAcquired,CountInBar,CountInWareHouse FROM tblStock");
            //DataModule.LoadTable(ref dgViewWarehouse, "SELECT CountInWareHouse-CountInBar FROM tblStock WHERE CountInBar<20");

            
        }

        private void btnBarRestock_Click(object sender, EventArgs e)
        {
            //string sql = "UPDATE tblStock SET CountInBar=30,CountInWarehouse=CountInWarehouse-30+CountInBar WHERE CountInWareHouse>50";
            string sql = "UPDATE tblStock SET CountInBar=30,CountInWareHouse=CountInWareHouse-30+CountInBar WHERE (CountInWareHouse>=50) AND (CountInBar<20)";
            int sucessful = DataModule.ExecuteSQL(sql);
            if (sucessful == 1)
                MessageBox.Show("Updated sucessfully");
            else
                MessageBox.Show("Restock Unnecesary");

            DataModule.LoadTable(ref dgViewWarehouse, "SELECT StockName,DateAcquired,CountInBar,CountInWareHouse FROM tblStock");

        }

        private void btnWarehouseRestock_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tblStock SET CountInWareHouse=100 WHERE CountInWareHouse<50";
            int sucessful = DataModule.ExecuteSQL(sql);
            if (sucessful == 1)
                MessageBox.Show("Updated sucessfully");
            else
                MessageBox.Show("Restock Unnecesary");

            DataModule.LoadTable(ref dgViewWarehouse, "SELECT StockName,DateAcquired,CountInBar,CountInWareHouse FROM tblStock");
        }

        private void linktoHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Warehouse_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Creator.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
