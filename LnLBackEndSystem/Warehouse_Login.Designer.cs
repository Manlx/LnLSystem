﻿
namespace LnLBackEndSystem
{
    partial class Warehouse_Login
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
            this.dgViewWarehouse = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linktoHome = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBarRestock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWarehouseRestock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewWarehouse
            // 
            this.dgViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewWarehouse.Location = new System.Drawing.Point(15, 105);
            this.dgViewWarehouse.Name = "dgViewWarehouse";
            this.dgViewWarehouse.Size = new System.Drawing.Size(512, 279);
            this.dgViewWarehouse.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(199, 64);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click \'Generate\' to create and view the stock report.";
            // 
            // linktoHome
            // 
            this.linktoHome.AutoSize = true;
            this.linktoHome.Location = new System.Drawing.Point(21, 516);
            this.linktoHome.Name = "linktoHome";
            this.linktoHome.Size = new System.Drawing.Size(119, 13);
            this.linktoHome.TabIndex = 11;
            this.linktoHome.TabStop = true;
            this.linktoHome.Text = "Return to Home Screen";
            this.linktoHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linktoHome_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Restock bar";
            // 
            // btnBarRestock
            // 
            this.btnBarRestock.Location = new System.Drawing.Point(24, 423);
            this.btnBarRestock.Name = "btnBarRestock";
            this.btnBarRestock.Size = new System.Drawing.Size(75, 23);
            this.btnBarRestock.TabIndex = 13;
            this.btnBarRestock.Text = "Restock";
            this.btnBarRestock.UseVisualStyleBackColor = true;
            this.btnBarRestock.Click += new System.EventHandler(this.btnBarRestock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Restock warehouse";
            // 
            // btnWarehouseRestock
            // 
            this.btnWarehouseRestock.Location = new System.Drawing.Point(24, 475);
            this.btnWarehouseRestock.Name = "btnWarehouseRestock";
            this.btnWarehouseRestock.Size = new System.Drawing.Size(75, 23);
            this.btnWarehouseRestock.TabIndex = 15;
            this.btnWarehouseRestock.Text = "Restock";
            this.btnWarehouseRestock.UseVisualStyleBackColor = true;
            this.btnWarehouseRestock.Click += new System.EventHandler(this.btnWarehouseRestock_Click);
            // 
            // Warehouse_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 537);
            this.Controls.Add(this.btnWarehouseRestock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBarRestock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linktoHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgViewWarehouse);
            this.Name = "Warehouse_Login";
            this.Text = "Warehouse_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Warehouse_Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewWarehouse;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linktoHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBarRestock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWarehouseRestock;
    }
}