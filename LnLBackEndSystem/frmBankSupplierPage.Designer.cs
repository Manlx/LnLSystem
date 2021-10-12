
namespace LnLBackEndSystem
{
    partial class frmBankSupplierPage
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
            this.btnRemoveSupBank = new System.Windows.Forms.Button();
            this.btnSupBank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveSupBank
            // 
            this.btnRemoveSupBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRemoveSupBank.FlatAppearance.BorderSize = 0;
            this.btnRemoveSupBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSupBank.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoveSupBank.Location = new System.Drawing.Point(14, 99);
            this.btnRemoveSupBank.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnRemoveSupBank.Name = "btnRemoveSupBank";
            this.btnRemoveSupBank.Size = new System.Drawing.Size(182, 82);
            this.btnRemoveSupBank.TabIndex = 48;
            this.btnRemoveSupBank.Text = "Remove Supplier Bank";
            this.btnRemoveSupBank.UseVisualStyleBackColor = false;
            // 
            // btnSupBank
            // 
            this.btnSupBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSupBank.FlatAppearance.BorderSize = 0;
            this.btnSupBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupBank.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSupBank.Location = new System.Drawing.Point(14, 9);
            this.btnSupBank.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSupBank.Name = "btnSupBank";
            this.btnSupBank.Size = new System.Drawing.Size(182, 82);
            this.btnSupBank.TabIndex = 47;
            this.btnSupBank.Text = "Add Supplier Bank";
            this.btnSupBank.UseVisualStyleBackColor = false;
            this.btnSupBank.Click += new System.EventHandler(this.btnSupBank_Click);
            // 
            // frmBankSupplierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(211, 191);
            this.Controls.Add(this.btnRemoveSupBank);
            this.Controls.Add(this.btnSupBank);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankSupplierPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Supplier Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankSupplierPage_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveSupBank;
        private System.Windows.Forms.Button btnSupBank;
    }
}