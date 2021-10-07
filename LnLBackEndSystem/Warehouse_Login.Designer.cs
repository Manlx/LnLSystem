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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgViewWarehouse = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.linktoHome = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBarRestock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWarehouseRestock = new System.Windows.Forms.Button();
            this.ttGenerate = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewWarehouse
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgViewWarehouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgViewWarehouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewWarehouse.EnableHeadersVisualStyles = false;
            this.dgViewWarehouse.Location = new System.Drawing.Point(23, 61);
            this.dgViewWarehouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgViewWarehouse.Name = "dgViewWarehouse";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewWarehouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgViewWarehouse.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgViewWarehouse.Size = new System.Drawing.Size(568, 339);
            this.dgViewWarehouse.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Location = new System.Drawing.Point(235, 14);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(112, 37);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate";
            this.ttGenerate.SetToolTip(this.btnGenerateReport, "Generates Table");
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // linktoHome
            // 
            this.linktoHome.AutoSize = true;
            this.linktoHome.LinkColor = System.Drawing.Color.LightBlue;
            this.linktoHome.Location = new System.Drawing.Point(19, 542);
            this.linktoHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linktoHome.Name = "linktoHome";
            this.linktoHome.Size = new System.Drawing.Size(182, 21);
            this.linktoHome.TabIndex = 11;
            this.linktoHome.TabStop = true;
            this.linktoHome.Text = "Return to Home Screen";
            this.linktoHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linktoHome_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Restock bar";
            // 
            // btnBarRestock
            // 
            this.btnBarRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBarRestock.FlatAppearance.BorderSize = 0;
            this.btnBarRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarRestock.Location = new System.Drawing.Point(23, 432);
            this.btnBarRestock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBarRestock.Name = "btnBarRestock";
            this.btnBarRestock.Size = new System.Drawing.Size(112, 37);
            this.btnBarRestock.TabIndex = 13;
            this.btnBarRestock.Text = "Restock";
            this.btnBarRestock.UseVisualStyleBackColor = false;
            this.btnBarRestock.Click += new System.EventHandler(this.btnBarRestock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 474);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Restock warehouse";
            // 
            // btnWarehouseRestock
            // 
            this.btnWarehouseRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnWarehouseRestock.FlatAppearance.BorderSize = 0;
            this.btnWarehouseRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouseRestock.Location = new System.Drawing.Point(23, 500);
            this.btnWarehouseRestock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWarehouseRestock.Name = "btnWarehouseRestock";
            this.btnWarehouseRestock.Size = new System.Drawing.Size(112, 37);
            this.btnWarehouseRestock.TabIndex = 15;
            this.btnWarehouseRestock.Text = "Restock";
            this.btnWarehouseRestock.UseVisualStyleBackColor = false;
            this.btnWarehouseRestock.Click += new System.EventHandler(this.btnWarehouseRestock_Click);
            // 
            // Warehouse_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(610, 574);
            this.Controls.Add(this.btnWarehouseRestock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBarRestock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linktoHome);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgViewWarehouse);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Warehouse_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Warehouse_Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewWarehouse;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.LinkLabel linktoHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBarRestock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWarehouseRestock;
        private System.Windows.Forms.ToolTip ttGenerate;
    }
}