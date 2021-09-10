
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.linkToHome = new System.Windows.Forms.LinkLabel();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View High Balance Tabs";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Old Stock";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "View Incomplete Orders";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "View Upcoming Bookings";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(213, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "View Stock Balance";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(213, 545);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "View Stock Total Price";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Location = new System.Drawing.Point(253, 571);
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
            // 
            // Accountant_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 615);
            this.Controls.Add(this.linkToHome);
            this.Controls.Add(this.lblStockPrice);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgViewAcc);
            this.Name = "Accountant_Login";
            this.Text = "Accountant_Login";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgViewAcc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.LinkLabel linkToHome;
    }
}