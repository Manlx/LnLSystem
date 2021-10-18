//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using StockAndUtils;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmStockRemove : Form
    {
        public static Form Creator;
        public frmStockRemove()
        {
            InitializeComponent();
        }

        private void frmStockRemove_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        List<StockObj> StockList = new List<StockObj>();
        public void UpdateStockList()
        {
            StockList = new List<StockObj>();
            string[] IDs = DataModule.GetValues(0,$"SELECT StockID FROM tblStock");
            lstStock.Items.Clear();
            foreach (string x in IDs)
            {
                StockObj Temp = new StockObj();
                Temp.LoadFromDB(x);
                StockList.Add(Temp);
                lstStock.Items.Add(Temp.StockName);
            }
        }
        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {
            if (lstStock.SelectedIndex <0)
            {
                MessageBox.Show("Select a Record");
                lstStock.Focus();
                return;
            }
            if (MessageBox.Show("Are you sure? ", "Continue?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (StockList[lstStock.SelectedIndex].DeleteSelf())
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Error");
            UpdateStockList();
        }

        private void frmStockRemove_Load(object sender, EventArgs e)
        {
            UpdateStockList();
        }
    }
}
