// Brendan Viljoen 32737742
using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class Accountant_Login : Form
    {
        public static Form Creator;
        public Accountant_Login()
        {
            InitializeComponent();
        }

        private void linkToHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Accountant_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Creator.Show();
        }

        private void viewStockBalance_Click(object sender, EventArgs e)
        {

            try
            {


                if (cbMoreThan.Checked && cbLessThan.Checked)
                {
                    int startVal = int.Parse(txtStartStock.Text);
                    int endVal = int.Parse(txtEndStock.Text);
                    DataModule.LoadTable(ref dgViewAcc, "SELECT StockName,CountInBar,CountInWareHouse FROM tblStock WHERE CountInBar >'" + startVal + "' AND CountInBar < '" + endVal + "'");
                }
                else if (cbMoreThan.Checked)
                {
                    int startVal = int.Parse(txtStartStock.Text);
                    DataModule.LoadTable(ref dgViewAcc, "SELECT StockName,CountInBar,CountInWareHouse FROM tblStock WHERE CountInBar >'" + startVal + "'");
                }
                else if (cbLessThan.Checked)
                {
                    int endVal = int.Parse(txtEndStock.Text);
                    DataModule.LoadTable(ref dgViewAcc, "SELECT StockName,CountInBar,CountInWareHouse FROM tblStock WHERE CountInBar <'" + endVal + "'");
                }
                else
                {
                    DataModule.LoadTable(ref dgViewAcc, "SELECT StockName,CountInBar,CountInWareHouse FROM tblStock");
                }
                //DataModule.LoadTable(ref dgViewAcc, "SELECT StockName,CountInBar,CountInWareHouse FROM tblStock");
            }
            catch
            {
                MessageBox.Show("Enter value in  the provided textbox.");
            }
        }

        private void viewHighTab_Click(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgViewAcc, "SELECT ClientID,Balance FROM tblTab WHERE Balance>=500");
        }

        private void viewOldStock_Click(object sender, EventArgs e)
        {
            if(cbMoreThan.Checked&&cbLessThan.Checked)
            {
                int startVal = int.Parse(txtStartStock.Text);
                int endVal = int.Parse(txtEndStock.Text);
                DataModule.LoadTable(ref dgViewAcc, $"SELECT StockName,CountInBar,CountInWareHouse FROM tblStock WHERE DateAcquired < '{DateTime.Today.AddDays(-90):yyyy-MM-dd}' AND CountInBar >'" + startVal + "' AND CountInBar < '" + endVal + "'");
            }
            else if(cbMoreThan.Checked)
            {
                int startVal = int.Parse(txtStartStock.Text);
                DataModule.LoadTable(ref dgViewAcc, $"SELECT StockName,CountInBar,CountInWareHouse FROM tblStock WHERE DateAcquired < '{DateTime.Today.AddDays(-90):yyyy-MM-dd}' AND CountInBar >'" + startVal + "'");
            }
            else if(cbLessThan.Checked)
            {
                int endVal = int.Parse(txtEndStock.Text);
                DataModule.LoadTable(ref dgViewAcc, $"SELECT StockName,CountInBar,CountInWareHouse FROM tblStock WHERE DateAcquired < '{DateTime.Today.AddDays(-90):yyyy-MM-dd}' AND CountInBar < '" + endVal + "'");
            }
            else
            {
                DataModule.LoadTable(ref dgViewAcc, $"SELECT StockName,CountInBar,CountInWareHouse FROM tblStock WHERE DateAcquired < '{DateTime.Today.AddDays(-90):yyyy-MM-dd}'");
            }
            
        }

        private void viewUpcomingBookings_Click(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgViewAcc, "SELECT * FROM tblBooking");
        }

        private void viewIncomplete_Click(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgViewAcc, $"SELECT * FROM tblOrder WHERE TransactionID IS NULL");
        }

        private void viewTotalPrice_Click(object sender, EventArgs e)
        {
            string price = DataModule.GetValue(0,$"SELECT SUM((ProfitMargin*CountInBar)+(ProfitMargin*CountInWareHouse))FROM tblStock");
                //DataModule.LoadTable(ref dgViewAcc, $"SELECT SUM((ProfitMargin*CountInBar)+(ProfitMargin*CountInWareHouse))FROM tblStock").ToString();
               
            lblStockPrice.Text = "R " + price;
        }

        private void Accountant_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
