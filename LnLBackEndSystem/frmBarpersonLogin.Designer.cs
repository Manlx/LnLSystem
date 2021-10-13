
namespace LnLBackEndSystem
{
    partial class frmBarpersonLogin
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
            this.btnStockReport = new System.Windows.Forms.Button();
            this.btnRequestStock = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPointOfSale = new System.Windows.Forms.Button();
            this.btnImageManage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnStockReport
            // 
            this.btnStockReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnStockReport.FlatAppearance.BorderSize = 0;
            this.btnStockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockReport.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStockReport.Location = new System.Drawing.Point(17, 7);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(208, 92);
            this.btnStockReport.TabIndex = 0;
            this.btnStockReport.Text = "&View Stock";
            this.toolTip1.SetToolTip(this.btnStockReport, "View Stock");
            this.btnStockReport.UseVisualStyleBackColor = false;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // btnRequestStock
            // 
            this.btnRequestStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRequestStock.FlatAppearance.BorderSize = 0;
            this.btnRequestStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestStock.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRequestStock.Location = new System.Drawing.Point(17, 307);
            this.btnRequestStock.Name = "btnRequestStock";
            this.btnRequestStock.Size = new System.Drawing.Size(208, 92);
            this.btnRequestStock.TabIndex = 3;
            this.btnRequestStock.Text = "&Request Stock";
            this.toolTip1.SetToolTip(this.btnRequestStock, "Request Stock form Warehouse");
            this.btnRequestStock.UseVisualStyleBackColor = false;
            this.btnRequestStock.Click += new System.EventHandler(this.btnRequestStock_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(18, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 92);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "&Back";
            this.toolTip1.SetToolTip(this.btnBack, "Return To Login");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPointOfSale
            // 
            this.btnPointOfSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnPointOfSale.FlatAppearance.BorderSize = 0;
            this.btnPointOfSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointOfSale.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPointOfSale.Location = new System.Drawing.Point(17, 107);
            this.btnPointOfSale.Name = "btnPointOfSale";
            this.btnPointOfSale.Size = new System.Drawing.Size(208, 92);
            this.btnPointOfSale.TabIndex = 1;
            this.btnPointOfSale.Text = "&Point Of Sale";
            this.toolTip1.SetToolTip(this.btnPointOfSale, "Goes to point of sales");
            this.btnPointOfSale.UseVisualStyleBackColor = false;
            this.btnPointOfSale.Click += new System.EventHandler(this.btnPointOfSale_Click);
            // 
            // btnImageManage
            // 
            this.btnImageManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnImageManage.FlatAppearance.BorderSize = 0;
            this.btnImageManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageManage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnImageManage.Location = new System.Drawing.Point(17, 207);
            this.btnImageManage.Name = "btnImageManage";
            this.btnImageManage.Size = new System.Drawing.Size(208, 92);
            this.btnImageManage.TabIndex = 2;
            this.btnImageManage.Text = "&Manage Stock Images";
            this.toolTip1.SetToolTip(this.btnImageManage, "Allows Images to be Loaded for Stock");
            this.btnImageManage.UseVisualStyleBackColor = false;
            this.btnImageManage.Click += new System.EventHandler(this.btnImageManage_Click);
            // 
            // frmBarpersonLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(242, 507);
            this.Controls.Add(this.btnImageManage);
            this.Controls.Add(this.btnPointOfSale);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRequestStock);
            this.Controls.Add(this.btnStockReport);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBarpersonLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bartender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBarpersonLogin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnRequestStock;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPointOfSale;
        private System.Windows.Forms.Button btnImageManage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}