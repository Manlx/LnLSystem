
namespace LnLBackEndSystem
{
    partial class Accountant_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgViewAcc = new System.Windows.Forms.DataGridView();
            this.viewHighTab = new System.Windows.Forms.Button();
            this.viewOldStock = new System.Windows.Forms.Button();
            this.viewIncomplete = new System.Windows.Forms.Button();
            this.viewUpcomingBookings = new System.Windows.Forms.Button();
            this.viewStockBalance = new System.Windows.Forms.Button();
            this.viewTotalPrice = new System.Windows.Forms.Button();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.linkToHome = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartStock = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtEndStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewAcc
            // 
            this.dgViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewAcc.Location = new System.Drawing.Point(24, 162);
            this.dgViewAcc.Name = "dgViewAcc";
            this.dgViewAcc.Size = new System.Drawing.Size(539, 377);
            this.dgViewAcc.TabIndex = 1;
            // 
            // viewHighTab
            // 
            this.viewHighTab.Location = new System.Drawing.Point(24, 41);
            this.viewHighTab.Name = "viewHighTab";
            this.viewHighTab.Size = new System.Drawing.Size(140, 23);
            this.viewHighTab.TabIndex = 2;
            this.viewHighTab.Text = "View High Balance Tabs";
            this.viewHighTab.UseVisualStyleBackColor = true;
            this.viewHighTab.Click += new System.EventHandler(this.viewHighTab_Click);
            // 
            // viewOldStock
            // 
            this.viewOldStock.Location = new System.Drawing.Point(24, 70);
            this.viewOldStock.Name = "viewOldStock";
            this.viewOldStock.Size = new System.Drawing.Size(140, 23);
            this.viewOldStock.TabIndex = 3;
            this.viewOldStock.Text = "View Old Stock";
            this.viewOldStock.UseVisualStyleBackColor = true;
            this.viewOldStock.Click += new System.EventHandler(this.viewOldStock_Click);
            // 
            // viewIncomplete
            // 
            this.viewIncomplete.Location = new System.Drawing.Point(24, 99);
            this.viewIncomplete.Name = "viewIncomplete";
            this.viewIncomplete.Size = new System.Drawing.Size(140, 23);
            this.viewIncomplete.TabIndex = 4;
            this.viewIncomplete.Text = "View Incomplete Orders";
            this.viewIncomplete.UseVisualStyleBackColor = true;
            this.viewIncomplete.Click += new System.EventHandler(this.viewIncomplete_Click);
            // 
            // viewUpcomingBookings
            // 
            this.viewUpcomingBookings.Location = new System.Drawing.Point(24, 128);
            this.viewUpcomingBookings.Name = "viewUpcomingBookings";
            this.viewUpcomingBookings.Size = new System.Drawing.Size(140, 23);
            this.viewUpcomingBookings.TabIndex = 5;
            this.viewUpcomingBookings.Text = "View Upcoming Bookings";
            this.viewUpcomingBookings.UseVisualStyleBackColor = true;
            this.viewUpcomingBookings.Click += new System.EventHandler(this.viewUpcomingBookings_Click);
            // 
            // viewStockBalance
            // 
            this.viewStockBalance.Location = new System.Drawing.Point(24, 12);
            this.viewStockBalance.Name = "viewStockBalance";
            this.viewStockBalance.Size = new System.Drawing.Size(140, 23);
            this.viewStockBalance.TabIndex = 6;
            this.viewStockBalance.Text = "View Stock Balance";
            this.viewStockBalance.UseVisualStyleBackColor = true;
            this.viewStockBalance.Click += new System.EventHandler(this.viewStockBalance_Click);
            // 
            // viewTotalPrice
            // 
            this.viewTotalPrice.Location = new System.Drawing.Point(24, 545);
            this.viewTotalPrice.Name = "viewTotalPrice";
            this.viewTotalPrice.Size = new System.Drawing.Size(140, 23);
            this.viewTotalPrice.TabIndex = 7;
            this.viewTotalPrice.Text = "View Stock Total Price";
            this.viewTotalPrice.UseVisualStyleBackColor = true;
            this.viewTotalPrice.Click += new System.EventHandler(this.viewTotalPrice_Click);
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Location = new System.Drawing.Point(170, 550);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(75, 13);
            this.lblStockPrice.TabIndex = 8;
            this.lblStockPrice.Text = "STOCKPRICE";
            // 
            // linkToHome
            // 
            this.linkToHome.AutoSize = true;
            this.linkToHome.Location = new System.Drawing.Point(12, 593);
            this.linkToHome.Name = "linkToHome";
            this.linkToHome.Size = new System.Drawing.Size(119, 13);
            this.linkToHome.TabIndex = 9;
            this.linkToHome.TabStop = true;
            this.linkToHome.Text = "Return to Home Screen";
            this.linkToHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToHome_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter stock range you would like to view";
            // 
            // txtStartStock
            // 
            this.txtStartStock.Location = new System.Drawing.Point(459, 43);
            this.txtStartStock.Name = "txtStartStock";
            this.txtStartStock.Size = new System.Drawing.Size(100, 20);
            this.txtStartStock.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(379, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "More than";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(379, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Less than";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtEndStock
            // 
            this.txtEndStock.Location = new System.Drawing.Point(459, 88);
            this.txtEndStock.Name = "txtEndStock";
            this.txtEndStock.Size = new System.Drawing.Size(100, 20);
            this.txtEndStock.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // Accountant_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEndStock);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtStartStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkToHome);
            this.Controls.Add(this.lblStockPrice);
            this.Controls.Add(this.viewTotalPrice);
            this.Controls.Add(this.viewStockBalance);
            this.Controls.Add(this.viewUpcomingBookings);
            this.Controls.Add(this.viewIncomplete);
            this.Controls.Add(this.viewOldStock);
            this.Controls.Add(this.viewHighTab);
            this.Controls.Add(this.dgViewAcc);
            this.Name = "Accountant_Login";
            this.Text = "Accountant_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accountant_Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgViewAcc;
        private System.Windows.Forms.Button viewHighTab;
        private System.Windows.Forms.Button viewOldStock;
        private System.Windows.Forms.Button viewIncomplete;
        private System.Windows.Forms.Button viewUpcomingBookings;
        private System.Windows.Forms.Button viewStockBalance;
        private System.Windows.Forms.Button viewTotalPrice;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.LinkLabel linkToHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartStock;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtEndStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}