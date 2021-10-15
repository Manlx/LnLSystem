//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockAndUtils;
using SupplierAndUtils;
using NSDataModule;
using PaymentObjAndUtil;
using System.IO;
using System.Diagnostics;

namespace LnLBackEndSystem
{
    
    public partial class frmSupplierOrder : Form
    {
        public static Form Creator;
        public frmSupplierOrder()
        {
            InitializeComponent();
        }
        private List<SupplierObj> listSuppliers = new List<SupplierObj>();
        private List<PaymentMethodObj> ListPayment = new List<PaymentMethodObj>();
        private void frmSupplierOrder_Load(object sender, EventArgs e)
        {
            string[] SupplierIDs = DataModule.GetValues(0, "SELECT SupplierID FROM tblSupplier");
            foreach (string x in SupplierIDs)
            {
                SupplierObj Temp = new SupplierObj();
                Temp.LoadFromDB(x);
                listSuppliers.Add(Temp);
            }
            lstSuppliers.Items.Clear();
            foreach(SupplierObj x in listSuppliers)
                lstSuppliers.Items.Add($"{x.Name,-20} {x.WarehouseContactName}");
            string[] PaymentID = DataModule.GetValues(0, $"SELECT PaymentID from tblPaymentMethod");
            foreach (string x in PaymentID)
            {
                PaymentMethodObj Temp = new PaymentMethodObj();
                Temp.LoadFromDB(x);
                ListPayment.Add(Temp);
            }
            lstPayment.Items.Clear();
            foreach(PaymentMethodObj x in ListPayment)
                lstPayment.Items.Add(x.Description);
        }

        private void frmSupplierOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        
        List<StockObj> ListStock = new List<StockObj>();
        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuppliers.SelectedIndex < 0)
                return;
            string[] StockID = DataModule.GetValues(0,$"SELECT StockID FROM tblSupplierStock WHERE SupplierID = {listSuppliers[lstSuppliers.SelectedIndex].SupplierID}");
            ListStock = new List<StockObj>();
            foreach (string x in StockID)
            {
                StockObj Temp = new StockObj();
                Temp.LoadFromDB(x);
                ListStock.Add(Temp);
            }
            lstProducts.Items.Clear();
            foreach(StockObj x in ListStock)
                lstProducts.Items.Add($"{x.StockName,-20} {x.CostPrice}");
        }
        List<StockAndCount> StockOrder = new List<StockAndCount>();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (lstProducts.SelectedIndex < 0)
                return;
            bool Looking = true;
            int x = 0;
            StockAndCount Temp = new StockAndCount(ListStock[lstProducts.SelectedIndex],1);
            while (Looking && x < StockOrder.Count)
                if (Looking = !StockOrder[x].Equals(Temp))
                    x++;
            if (Looking)
                StockOrder.Add(Temp);
            else
                StockOrder[x].Count += (Temp.Count);
            lstOrder.Items.Clear();
            foreach (StockAndCount y in StockOrder)
                lstOrder.Items.Add($"{y.Stock.StockName,-50} x {y.Count}");
        }
        private class StockAndCount
        {
            public StockAndCount() { }
            public StockAndCount (StockObj Stock, int Count)
            {
                this.Stock = Stock;
                this.Count = Count;
            }
            public bool Equals(StockAndCount Other)
            {
                return Stock == Other.Stock;
            }
            public StockObj Stock;
            public int Count;
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex >= 0)
                if (int.TryParse(edtAmount.Text, out int Value))
                    StockOrder[lstOrder.SelectedIndex].Count += Value;
            UpdateListbox();
        }
        private void UpdateListbox()
        {
            int temp = lstOrder.SelectedIndex;
            lstOrder.Items.Clear();
            foreach (StockAndCount y in StockOrder)
                lstOrder.Items.Add($"{y.Stock.StockName,-50} x {y.Count}");
            if (temp < lstOrder.SelectedIndex)
            lstOrder.SelectedIndex = temp;
        }
        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex >= 0)
                if (int.TryParse(edtAmount.Text, out int Value))
                    if (Value >= StockOrder[lstOrder.SelectedIndex].Count)
                        StockOrder.RemoveAt(lstOrder.SelectedIndex);
                    else
                        StockOrder[lstOrder.SelectedIndex].Count -= Value;
            UpdateListbox();
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex <0)
            {
                MessageBox.Show("Empty Order");
                return;
            }
            if (lstPayment.SelectedIndex <0)
            {
                MessageBox.Show("Please select a payment method");
                return;
            }
            string fileName = "Stock " + DateTime.Now.ToString("MM-dd-yyyy HH-mm") + ".csv";
            try
            {
                if (File.Exists(fileName))
                {
                    MessageBox.Show("File already exists");
                    if (MessageBox.Show("Delete file?", "Want to remove Existing File", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        File.Delete(fileName);
                    else
                        return;
                }
                StreamWriter OutFile = new StreamWriter(fileName);
                OutFile.WriteLine($"Supplier,Contact Information");
                OutFile.WriteLine($"{listSuppliers[lstSuppliers.SelectedIndex].Name},{listSuppliers[lstSuppliers.SelectedIndex].WarehouseContactName}");
                OutFile.WriteLine($"Selected payment method, {ListPayment[lstPayment.SelectedIndex].Description}");
                OutFile.WriteLine($"==========,==========");
                OutFile.WriteLine($"Stock Name,Count");
                foreach (StockAndCount x in StockOrder)
                    OutFile.WriteLine($"{x.Stock.StockName,-20}, {x.Count} ");
                OutFile.Close();
                MessageBox.Show("Stock report has been generated with name: " + fileName);
                ProcessStartInfo StartInfo = new ProcessStartInfo();
                StartInfo.Arguments = fileName;
                StartInfo.FileName = "explorer.exe";
                Process.Start(StartInfo);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
