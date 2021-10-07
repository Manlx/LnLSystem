﻿
namespace LnLBackEndSystem
{
    partial class frmStockPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockPurchase));
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddToTab = new System.Windows.Forms.Button();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.imgBackUp = new System.Windows.Forms.PictureBox();
            this.pnlStockBox = new System.Windows.Forms.Panel();
            this.btnDecrease = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lstOrder
            // 
            this.lstOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lstOrder.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.ForeColor = System.Drawing.Color.White;
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 23;
            this.lstOrder.Location = new System.Drawing.Point(14, 456);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(1285, 234);
            this.lstOrder.TabIndex = 1;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(279, 705);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(265, 192);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddToTab
            // 
            this.btnAddToTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAddToTab.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddToTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToTab.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToTab.Location = new System.Drawing.Point(1034, 705);
            this.btnAddToTab.Name = "btnAddToTab";
            this.btnAddToTab.Size = new System.Drawing.Size(265, 192);
            this.btnAddToTab.TabIndex = 4;
            this.btnAddToTab.Text = "Add To Tab";
            this.btnAddToTab.UseVisualStyleBackColor = false;
            this.btnAddToTab.Click += new System.EventHandler(this.btnAddToTab_Click);
            // 
            // btnPayCash
            // 
            this.btnPayCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnPayCash.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPayCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayCash.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCash.Location = new System.Drawing.Point(771, 705);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(265, 192);
            this.btnPayCash.TabIndex = 5;
            this.btnPayCash.Text = "Cash Payment";
            this.btnPayCash.UseVisualStyleBackColor = false;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // imgBackUp
            // 
            this.imgBackUp.Image = ((System.Drawing.Image)(resources.GetObject("imgBackUp.Image")));
            this.imgBackUp.Location = new System.Drawing.Point(-100, -100);
            this.imgBackUp.Name = "imgBackUp";
            this.imgBackUp.Size = new System.Drawing.Size(100, 50);
            this.imgBackUp.TabIndex = 0;
            this.imgBackUp.TabStop = false;
            // 
            // pnlStockBox
            // 
            this.pnlStockBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlStockBox.Location = new System.Drawing.Point(14, 11);
            this.pnlStockBox.Name = "pnlStockBox";
            this.pnlStockBox.Size = new System.Drawing.Size(1285, 439);
            this.pnlStockBox.TabIndex = 6;
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDecrease.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrease.Location = new System.Drawing.Point(14, 705);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(265, 192);
            this.btnDecrease.TabIndex = 7;
            this.btnDecrease.Text = "Decrease";
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // frmStockPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1309, 923);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnAddToTab);
            this.Controls.Add(this.pnlStockBox);
            this.Controls.Add(this.btnPayCash);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.imgBackUp);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStockPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStockPurchase_FormClosed);
            this.Load += new System.EventHandler(this.frmStockPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBackUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddToTab;
        private System.Windows.Forms.Button btnPayCash;
        public System.Windows.Forms.PictureBox imgBackUp;
        private System.Windows.Forms.Panel pnlStockBox;
        private System.Windows.Forms.Button btnDecrease;
    }
}