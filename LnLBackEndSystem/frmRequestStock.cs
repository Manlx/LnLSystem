//Carla Pretorius 36184950
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NSDataModule;
using System.IO;

namespace LnLBackEndSystem
{
    public partial class frmRequestStock : Form
    {
        public static Form Creator;
        public frmRequestStock()
        {
            InitializeComponent();
        }
        private List<List<string>> DataToSave;
        private void addToList_Click(object sender, EventArgs e)
        {

            bool bValid = true;
            if (!(int.TryParse(txtQuantity.Text, out int quantity)))
            {
                errorQuantity.SetError(txtQuantity, "Quantity must be an integer.");
                bValid = false;
            }
            string stockName = cmbStock.Text;
            if (bValid)
            {
                //lstStockRequest.Items.Add($"{stockName} x {quantity}");
                List<string> temp = new List<string>();
                temp.Add(stockName);
                temp.Add(quantity.ToString());

                bool notFound = true;
                int x = 0;
                while (notFound && x < DataToSave.Count)
                {//Looks through the list and increments the values if already present, if not found adds
                    notFound = (DataToSave[x][0] != stockName);
                    if (!notFound)
                        DataToSave[x][1] = (int.Parse(DataToSave[x][1]) + quantity).ToString();
                    else
                        x++;
                }
                if (notFound)
                    DataToSave.Add(temp);

                DataToSaveToListbox();
            }
        }
        public void DataToSaveToListbox()
        {
            lstStockRequest.Items.Clear();
            foreach (List<string> x in DataToSave)
                lstStockRequest.Items.Add($"{x[0]} x {x[1]}");
        }
        public void SaveToTextFile()
        {
            string fileName = "Stock report_" + DateTime.Now.ToString("MM-dd-yyyy HH-mm") + ".csv";
            try
            {
                if (File.Exists(fileName))
                    MessageBox.Show("File already exists");

                StreamWriter OutFile = new StreamWriter(fileName);
                foreach (List<string> x in DataToSave)
                {
                    OutFile.WriteLine($"{x[0]},{x[1]}");
                }
                OutFile.Close();
                MessageBox.Show("Stock report has been generated with name: " + fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void frmRequestStock_Load(object sender, EventArgs e)
        {
            String[] items = DataModule.GetValues(0, "SELECT stockName from tblStock ORDER BY stockName ASC");
            DataToSave = new List<List<string>>();
            cmbStock.Items.Clear();
            foreach (String x in items)
            {
                cmbStock.Items.Add(x);
            }
        }

        private void frmRequestStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveToTextFile();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataToSave.RemoveAt(lstStockRequest.SelectedIndex);
                DataToSaveToListbox();
            }
            catch
            {
                MessageBox.Show("No item selected");
            }
        }

    }
}
