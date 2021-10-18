
namespace LnLBackEndSystem
{
    partial class frmStockRemove
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
            this.lstStock = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRemoveStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStock
            // 
            this.lstStock.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstStock.ForeColor = System.Drawing.Color.White;
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 25;
            this.lstStock.Location = new System.Drawing.Point(12, 51);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(493, 229);
            this.lstStock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock List:";
            // 
            // BtnRemoveStock
            // 
            this.BtnRemoveStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnRemoveStock.FlatAppearance.BorderSize = 0;
            this.BtnRemoveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveStock.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnRemoveStock.Location = new System.Drawing.Point(12, 290);
            this.BtnRemoveStock.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnRemoveStock.Name = "BtnRemoveStock";
            this.BtnRemoveStock.Size = new System.Drawing.Size(493, 50);
            this.BtnRemoveStock.TabIndex = 5;
            this.BtnRemoveStock.Text = "&Remove Stock";
            this.BtnRemoveStock.UseVisualStyleBackColor = false;
            this.BtnRemoveStock.Click += new System.EventHandler(this.BtnRemoveStock_Click);
            // 
            // frmStockRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(517, 354);
            this.Controls.Add(this.BtnRemoveStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStock);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Stock Record";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStockRemove_FormClosed);
            this.Load += new System.EventHandler(this.frmStockRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRemoveStock;
    }
}