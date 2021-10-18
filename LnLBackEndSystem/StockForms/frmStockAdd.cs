//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StockAndUtils;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmStockAdd : Form
    {
        public static Form Creator;
        public frmStockAdd()
        {
            InitializeComponent();
        }

        private void frmStockAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            foreach (TextBox x in Controls.OfType<TextBox>())
                if (String.IsNullOrEmpty(x.Text) )
                {
                    MessageBox.Show("Required Field");
                    x.Focus();
                    return;
                }
            foreach (TextBox x in Controls.OfType<TextBox>())
                if (x.Name != "EdtName" && !int.TryParse(x.Text,out int myInt))
                {
                    MessageBox.Show("Field must be Integer");
                    x.Focus();
                    return;
                }
            StockObj Temp = new StockObj() {CostPrice = EdtCostPrice.Text,CountInBar = EdtCountInBar.Text,CountInWareHouse = EdtCountInWarehouse.Text,
                ProfitMargin = EdtProfitMargin.Text,StockName = EdtName.Text,DateAcquired = $"{DateTime.Now:yyyy-MM-dd}" };
            string[] IDs = DataModule.GetValues(0,$"SELECT StockID FROM tblStock WHERE StockName LIKE '%{Temp.StockName}%'");
            if (IDs.Length > 0)
            {
                lstSimular.Items.Clear();
                List<StockObj> StockList = new List<StockObj>();
                foreach (string x in IDs)
                {
                    StockObj LookAlike = new StockObj();
                    LookAlike.LoadFromDB(x);
                    lstSimular.Items.Add(LookAlike.StockName);
                }
                if (MessageBox.Show($"There were {lstSimular.Items.Count} item(s) found with a simular name. Do you want to Continue?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
            }
                
            if (Temp.InsertSelf())
                MessageBox.Show("Insert Successfully");
            else
                MessageBox.Show("Failure Occured");
        }
    }
}
