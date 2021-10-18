//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using StockAndUtils;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmStockUpdate : Form
    {
        public static Form Creator;
        public frmStockUpdate()
        {
            InitializeComponent();
        }

        private void frmStockUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        List<StockObj> StockList = new List<StockObj>();
        public void UpdateStockList()
        {
            StockList = new List<StockObj>();
            string[] IDs = DataModule.GetValues(0, $"SELECT StockID FROM tblStock");
            lstStock.Items.Clear();
            foreach (string x in IDs)
            {
                StockObj Temp = new StockObj();
                Temp.LoadFromDB(x);
                StockList.Add(Temp);
                lstStock.Items.Add(Temp.StockName);
            }
        }
        private void frmStockUpdate_Load(object sender, EventArgs e)
        {
            UpdateStockList();
        }
        private void LoadComps(StockObj Temp)
        {
            EdtName.Text = Temp.StockName;
            EdtCostPrice.Text = Temp.CostPrice;
            EdtCountInBar.Text = Temp.CountInBar;
            EdtCountInWarehouse.Text = Temp.CountInWareHouse;
            EdtProfitMargin.Text = Temp.ProfitMargin; 
        }

        private void lstStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStock.SelectedIndex >= 0)
                LoadComps(StockList[lstStock.SelectedIndex]);
        }

        private void BtnUpdateStock_Click(object sender, EventArgs e)
        {
            foreach (TextBox x in Controls.OfType<TextBox>())
                if (String.IsNullOrEmpty(x.Text))
                {
                    MessageBox.Show("Required Field");
                    x.Focus();
                    return;
                }
            foreach (TextBox x in Controls.OfType<TextBox>())
                if (x.Name != "EdtName" && !int.TryParse(x.Text, out int myInt))
                {
                    MessageBox.Show("Field must be Integer");
                    x.Focus();
                    return;
                }
            if (lstStock.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a stock record");
                lstStock.Focus();
                return;
            }
            StockList[lstStock.SelectedIndex].StockName = EdtName.Text;
            StockList[lstStock.SelectedIndex].ProfitMargin = EdtProfitMargin.Text;
            StockList[lstStock.SelectedIndex].CostPrice = EdtCostPrice.Text;
            StockList[lstStock.SelectedIndex].CountInBar = EdtCountInBar.Text;
            StockList[lstStock.SelectedIndex].CountInWareHouse = EdtCountInWarehouse.Text;
            if (StockList[lstStock.SelectedIndex].UpdateSelf())
                MessageBox.Show("Updated Successfully");
            else
                MessageBox.Show("Failure Occured");
            
            int Value = lstStock.SelectedIndex;
            UpdateStockList();
            if (Value < lstStock.Items.Count)
                lstStock.SelectedIndex = Value;
        }
    }
}
