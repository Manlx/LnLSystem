﻿//M Tolmay 33784507
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
            DataModule.LoadTable(ref dgViewAcc, "SELECT StockName,CountInBar,CountInWareHouse FROM tblStock");
        }

        private void viewHighTab_Click(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgViewAcc, "SELECT ClientID,Balance FROM tblTab WHERE Balance>=500");
        }

        private void viewOldStock_Click(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgViewAcc, $"SELECT StockName,CountInBar,CountInWareHouse FROM tblStock WHERE DateAcquired < '{DateTime.Today.AddDays(-90):yyyy-MM-dd}'");
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
    }
}
