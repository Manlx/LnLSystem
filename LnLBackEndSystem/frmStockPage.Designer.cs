
namespace LnLBackEndSystem
{
    partial class frmStockPage
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
            this.BtnUpdateStock = new System.Windows.Forms.Button();
            this.BtnRemoveStock = new System.Windows.Forms.Button();
            this.BtnAddStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUpdateStock
            // 
            this.BtnUpdateStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnUpdateStock.FlatAppearance.BorderSize = 0;
            this.BtnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateStock.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnUpdateStock.Location = new System.Drawing.Point(15, 189);
            this.BtnUpdateStock.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnUpdateStock.Name = "BtnUpdateStock";
            this.BtnUpdateStock.Size = new System.Drawing.Size(182, 82);
            this.BtnUpdateStock.TabIndex = 5;
            this.BtnUpdateStock.Text = "&Update Stock";
            this.BtnUpdateStock.UseVisualStyleBackColor = false;
            this.BtnUpdateStock.Click += new System.EventHandler(this.BtnUpdateStock_Click);
            // 
            // BtnRemoveStock
            // 
            this.BtnRemoveStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnRemoveStock.FlatAppearance.BorderSize = 0;
            this.BtnRemoveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveStock.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnRemoveStock.Location = new System.Drawing.Point(15, 99);
            this.BtnRemoveStock.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnRemoveStock.Name = "BtnRemoveStock";
            this.BtnRemoveStock.Size = new System.Drawing.Size(182, 82);
            this.BtnRemoveStock.TabIndex = 4;
            this.BtnRemoveStock.Text = "&Remove Stock";
            this.BtnRemoveStock.UseVisualStyleBackColor = false;
            this.BtnRemoveStock.Click += new System.EventHandler(this.BtnRemoveStock_Click);
            // 
            // BtnAddStock
            // 
            this.BtnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnAddStock.FlatAppearance.BorderSize = 0;
            this.BtnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStock.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnAddStock.Location = new System.Drawing.Point(15, 9);
            this.BtnAddStock.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnAddStock.Name = "BtnAddStock";
            this.BtnAddStock.Size = new System.Drawing.Size(182, 82);
            this.BtnAddStock.TabIndex = 3;
            this.BtnAddStock.Text = "&Add Stock";
            this.BtnAddStock.UseVisualStyleBackColor = false;
            this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // frmStockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(212, 280);
            this.Controls.Add(this.BtnUpdateStock);
            this.Controls.Add(this.BtnRemoveStock);
            this.Controls.Add(this.BtnAddStock);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Homepage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStockPage_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateStock;
        private System.Windows.Forms.Button BtnRemoveStock;
        private System.Windows.Forms.Button BtnAddStock;
    }
}