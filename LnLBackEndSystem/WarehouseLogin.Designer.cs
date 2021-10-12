
namespace LnLBackEndSystem
{
    partial class WarehouseLogin
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
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnOrderSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRestock.FlatAppearance.BorderSize = 0;
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Location = new System.Drawing.Point(10, 12);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(209, 55);
            this.btnRestock.TabIndex = 4;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnOrderSupplier
            // 
            this.btnOrderSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOrderSupplier.FlatAppearance.BorderSize = 0;
            this.btnOrderSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderSupplier.Location = new System.Drawing.Point(10, 73);
            this.btnOrderSupplier.Name = "btnOrderSupplier";
            this.btnOrderSupplier.Size = new System.Drawing.Size(209, 55);
            this.btnOrderSupplier.TabIndex = 5;
            this.btnOrderSupplier.Text = "Order Stock";
            this.btnOrderSupplier.UseVisualStyleBackColor = false;
            this.btnOrderSupplier.Click += new System.EventHandler(this.btnOrderSupplier_Click);
            // 
            // WarehouseLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(229, 137);
            this.Controls.Add(this.btnOrderSupplier);
            this.Controls.Add(this.btnRestock);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WarehouseLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WarehouseLogin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnOrderSupplier;
    }
}