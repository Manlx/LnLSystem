
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpiringStock = new System.Windows.Forms.Label();
            this.lblExpiredStock = new System.Windows.Forms.Label();
            this.btnOrderStock = new System.Windows.Forms.Button();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewWarehouse
            // 
            this.dgViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewWarehouse.Location = new System.Drawing.Point(15, 105);
            this.dgViewWarehouse.Name = "dgViewWarehouse";
            this.dgViewWarehouse.Size = new System.Drawing.Size(453, 272);
            this.dgViewWarehouse.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Needs restock!";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(111, 427);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(58, 13);
            this.lblLowStock.TabIndex = 4;
            this.lblLowStock.Text = "RESTOCK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Almost expired stock!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Already expired stock!";
            // 
            // lblExpiringStock
            // 
            this.lblExpiringStock.AutoSize = true;
            this.lblExpiringStock.Location = new System.Drawing.Point(144, 503);
            this.lblExpiringStock.Name = "lblExpiringStock";
            this.lblExpiringStock.Size = new System.Drawing.Size(58, 13);
            this.lblExpiringStock.TabIndex = 7;
            this.lblExpiringStock.Text = "EXPIRING";
            // 
            // lblExpiredStock
            // 
            this.lblExpiredStock.AutoSize = true;
            this.lblExpiredStock.Location = new System.Drawing.Point(148, 464);
            this.lblExpiredStock.Name = "lblExpiredStock";
            this.lblExpiredStock.Size = new System.Drawing.Size(54, 13);
            this.lblExpiredStock.TabIndex = 8;
            this.lblExpiredStock.Text = "EXPIRED";
            // 
            // btnOrderStock
            // 
            this.btnOrderStock.Location = new System.Drawing.Point(175, 422);
            this.btnOrderStock.Name = "btnOrderStock";
            this.btnOrderStock.Size = new System.Drawing.Size(75, 23);
            this.btnOrderStock.TabIndex = 9;
            this.btnOrderStock.Text = "Order Stock";
            this.btnOrderStock.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.Location = new System.Drawing.Point(208, 459);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(87, 23);
            this.btnRemoveStock.TabIndex = 10;
            this.btnRemoveStock.Text = "Remove Stock";
            this.btnRemoveStock.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 578);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Return to Home Screen";
            // 
            // Warehouse_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 603);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnRemoveStock);
            this.Controls.Add(this.btnOrderStock);
            this.Controls.Add(this.lblExpiredStock);
            this.Controls.Add(this.lblExpiringStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLowStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgViewWarehouse);
            this.Name = "Warehouse_Login";
            this.Text = "Warehouse_Login";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewWarehouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExpiringStock;
        private System.Windows.Forms.Label lblExpiredStock;
        private System.Windows.Forms.Button btnOrderStock;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}