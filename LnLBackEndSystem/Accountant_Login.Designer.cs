
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            this.dgViewAcc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgViewAcc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewAcc.EnableHeadersVisualStyles = false;
            this.dgViewAcc.Location = new System.Drawing.Point(28, 212);
            this.dgViewAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgViewAcc.Name = "dgViewAcc";
            this.dgViewAcc.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewAcc.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            this.dgViewAcc.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgViewAcc.Size = new System.Drawing.Size(551, 375);
            this.dgViewAcc.TabIndex = 1;
            // 
            // viewHighTab
            // 
            this.viewHighTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewHighTab.FlatAppearance.BorderSize = 0;
            this.viewHighTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewHighTab.Location = new System.Drawing.Point(28, 54);
            this.viewHighTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewHighTab.Name = "viewHighTab";
            this.viewHighTab.Size = new System.Drawing.Size(163, 30);
            this.viewHighTab.TabIndex = 2;
            this.viewHighTab.Text = "View High Balance Tabs";
            this.viewHighTab.UseVisualStyleBackColor = false;
            this.viewHighTab.Click += new System.EventHandler(this.viewHighTab_Click);
            // 
            // viewOldStock
            // 
            this.viewOldStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewOldStock.FlatAppearance.BorderSize = 0;
            this.viewOldStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOldStock.Location = new System.Drawing.Point(28, 92);
            this.viewOldStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewOldStock.Name = "viewOldStock";
            this.viewOldStock.Size = new System.Drawing.Size(163, 30);
            this.viewOldStock.TabIndex = 3;
            this.viewOldStock.Text = "View Old Stock";
            this.viewOldStock.UseVisualStyleBackColor = false;
            this.viewOldStock.Click += new System.EventHandler(this.viewOldStock_Click);
            // 
            // viewIncomplete
            // 
            this.viewIncomplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewIncomplete.FlatAppearance.BorderSize = 0;
            this.viewIncomplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewIncomplete.Location = new System.Drawing.Point(28, 129);
            this.viewIncomplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewIncomplete.Name = "viewIncomplete";
            this.viewIncomplete.Size = new System.Drawing.Size(163, 30);
            this.viewIncomplete.TabIndex = 4;
            this.viewIncomplete.Text = "View Incomplete Orders";
            this.viewIncomplete.UseVisualStyleBackColor = false;
            this.viewIncomplete.Click += new System.EventHandler(this.viewIncomplete_Click);
            // 
            // viewUpcomingBookings
            // 
            this.viewUpcomingBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewUpcomingBookings.FlatAppearance.BorderSize = 0;
            this.viewUpcomingBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUpcomingBookings.Location = new System.Drawing.Point(28, 167);
            this.viewUpcomingBookings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewUpcomingBookings.Name = "viewUpcomingBookings";
            this.viewUpcomingBookings.Size = new System.Drawing.Size(163, 30);
            this.viewUpcomingBookings.TabIndex = 5;
            this.viewUpcomingBookings.Text = "View Upcoming Bookings";
            this.viewUpcomingBookings.UseVisualStyleBackColor = false;
            this.viewUpcomingBookings.Click += new System.EventHandler(this.viewUpcomingBookings_Click);
            // 
            // viewStockBalance
            // 
            this.viewStockBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewStockBalance.FlatAppearance.BorderSize = 0;
            this.viewStockBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewStockBalance.Location = new System.Drawing.Point(28, 16);
            this.viewStockBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewStockBalance.Name = "viewStockBalance";
            this.viewStockBalance.Size = new System.Drawing.Size(163, 30);
            this.viewStockBalance.TabIndex = 6;
            this.viewStockBalance.Text = "View Stock Balance";
            this.viewStockBalance.UseVisualStyleBackColor = false;
            this.viewStockBalance.Click += new System.EventHandler(this.viewStockBalance_Click);
            // 
            // viewTotalPrice
            // 
            this.viewTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.viewTotalPrice.FlatAppearance.BorderSize = 0;
            this.viewTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTotalPrice.Location = new System.Drawing.Point(28, 595);
            this.viewTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewTotalPrice.Name = "viewTotalPrice";
            this.viewTotalPrice.Size = new System.Drawing.Size(163, 30);
            this.viewTotalPrice.TabIndex = 7;
            this.viewTotalPrice.Text = "View Stock Total Price";
            this.viewTotalPrice.UseVisualStyleBackColor = false;
            this.viewTotalPrice.Click += new System.EventHandler(this.viewTotalPrice_Click);
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Location = new System.Drawing.Point(198, 601);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(80, 17);
            this.lblStockPrice.TabIndex = 8;
            this.lblStockPrice.Text = "STOCKPRICE";
            // 
            // linkToHome
            // 
            this.linkToHome.AutoSize = true;
            this.linkToHome.LinkColor = System.Drawing.Color.PowderBlue;
            this.linkToHome.Location = new System.Drawing.Point(25, 645);
            this.linkToHome.Name = "linkToHome";
            this.linkToHome.Size = new System.Drawing.Size(144, 17);
            this.linkToHome.TabIndex = 9;
            this.linkToHome.TabStop = true;
            this.linkToHome.Text = "Return to Home Screen";
            this.linkToHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToHome_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter stock range you would like to view";
            // 
            // txtStartStock
            // 
            this.txtStartStock.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStartStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartStock.ForeColor = System.Drawing.Color.White;
            this.txtStartStock.Location = new System.Drawing.Point(451, 63);
            this.txtStartStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStartStock.Name = "txtStartStock";
            this.txtStartStock.Size = new System.Drawing.Size(117, 18);
            this.txtStartStock.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(358, 66);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "More than";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(358, 125);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 21);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Less than";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtEndStock
            // 
            this.txtEndStock.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEndStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndStock.ForeColor = System.Drawing.Color.White;
            this.txtEndStock.Location = new System.Drawing.Point(451, 122);
            this.txtEndStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndStock.Name = "txtEndStock";
            this.txtEndStock.Size = new System.Drawing.Size(117, 18);
            this.txtEndStock.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // Accountant_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(606, 670);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Accountant_Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accountant Login";
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