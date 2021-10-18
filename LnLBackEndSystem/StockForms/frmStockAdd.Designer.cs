
namespace LnLBackEndSystem
{
    partial class frmStockAdd
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
            this.EdtName = new System.Windows.Forms.TextBox();
            this.EdtCostPrice = new System.Windows.Forms.TextBox();
            this.EdtProfitMargin = new System.Windows.Forms.TextBox();
            this.EdtCountInWarehouse = new System.Windows.Forms.TextBox();
            this.EdtCountInBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddStock = new System.Windows.Forms.Button();
            this.lstSimular = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EdtName
            // 
            this.EdtName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtName.ForeColor = System.Drawing.Color.White;
            this.EdtName.Location = new System.Drawing.Point(222, 22);
            this.EdtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtName.Name = "EdtName";
            this.EdtName.Size = new System.Drawing.Size(239, 33);
            this.EdtName.TabIndex = 0;
            // 
            // EdtCostPrice
            // 
            this.EdtCostPrice.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtCostPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtCostPrice.ForeColor = System.Drawing.Color.White;
            this.EdtCostPrice.Location = new System.Drawing.Point(222, 63);
            this.EdtCostPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtCostPrice.Name = "EdtCostPrice";
            this.EdtCostPrice.Size = new System.Drawing.Size(239, 33);
            this.EdtCostPrice.TabIndex = 1;
            // 
            // EdtProfitMargin
            // 
            this.EdtProfitMargin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtProfitMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtProfitMargin.ForeColor = System.Drawing.Color.White;
            this.EdtProfitMargin.Location = new System.Drawing.Point(222, 104);
            this.EdtProfitMargin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtProfitMargin.Name = "EdtProfitMargin";
            this.EdtProfitMargin.Size = new System.Drawing.Size(239, 33);
            this.EdtProfitMargin.TabIndex = 2;
            // 
            // EdtCountInWarehouse
            // 
            this.EdtCountInWarehouse.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtCountInWarehouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtCountInWarehouse.ForeColor = System.Drawing.Color.White;
            this.EdtCountInWarehouse.Location = new System.Drawing.Point(222, 186);
            this.EdtCountInWarehouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtCountInWarehouse.Name = "EdtCountInWarehouse";
            this.EdtCountInWarehouse.Size = new System.Drawing.Size(239, 33);
            this.EdtCountInWarehouse.TabIndex = 4;
            // 
            // EdtCountInBar
            // 
            this.EdtCountInBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtCountInBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtCountInBar.ForeColor = System.Drawing.Color.White;
            this.EdtCountInBar.Location = new System.Drawing.Point(222, 145);
            this.EdtCountInBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtCountInBar.Name = "EdtCountInBar";
            this.EdtCountInBar.Size = new System.Drawing.Size(239, 33);
            this.EdtCountInBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stock Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cost Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profit Margin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Count In Bar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Count In Warehouse:";
            // 
            // BtnAddStock
            // 
            this.BtnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnAddStock.FlatAppearance.BorderSize = 0;
            this.BtnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStock.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnAddStock.Location = new System.Drawing.Point(149, 341);
            this.BtnAddStock.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnAddStock.Name = "BtnAddStock";
            this.BtnAddStock.Size = new System.Drawing.Size(182, 82);
            this.BtnAddStock.TabIndex = 5;
            this.BtnAddStock.Text = "&Register Stock";
            this.BtnAddStock.UseVisualStyleBackColor = false;
            this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // lstSimular
            // 
            this.lstSimular.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstSimular.ForeColor = System.Drawing.Color.White;
            this.lstSimular.FormattingEnabled = true;
            this.lstSimular.ItemHeight = 25;
            this.lstSimular.Location = new System.Drawing.Point(20, 252);
            this.lstSimular.Name = "lstSimular";
            this.lstSimular.Size = new System.Drawing.Size(441, 79);
            this.lstSimular.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Simular:";
            // 
            // frmStockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(481, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstSimular);
            this.Controls.Add(this.BtnAddStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdtCountInWarehouse);
            this.Controls.Add(this.EdtCountInBar);
            this.Controls.Add(this.EdtProfitMargin);
            this.Controls.Add(this.EdtCostPrice);
            this.Controls.Add(this.EdtName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStockAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdtName;
        private System.Windows.Forms.TextBox EdtCostPrice;
        private System.Windows.Forms.TextBox EdtProfitMargin;
        private System.Windows.Forms.TextBox EdtCountInWarehouse;
        private System.Windows.Forms.TextBox EdtCountInBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddStock;
        private System.Windows.Forms.ListBox lstSimular;
        private System.Windows.Forms.Label label6;
    }
}