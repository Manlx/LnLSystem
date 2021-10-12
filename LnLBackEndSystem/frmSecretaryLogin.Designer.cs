
namespace LnLBackEndSystem
{
    partial class frmSecretaryLogin
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
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnBankSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStaff.Location = new System.Drawing.Point(13, 7);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(182, 82);
            this.btnStaff.TabIndex = 43;
            this.btnStaff.Text = "Staff Management";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSupplier.Location = new System.Drawing.Point(13, 97);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(182, 82);
            this.btnSupplier.TabIndex = 44;
            this.btnSupplier.Text = "Supplier Management";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnBankSupplier
            // 
            this.btnBankSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBankSupplier.FlatAppearance.BorderSize = 0;
            this.btnBankSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBankSupplier.Location = new System.Drawing.Point(13, 187);
            this.btnBankSupplier.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnBankSupplier.Name = "btnBankSupplier";
            this.btnBankSupplier.Size = new System.Drawing.Size(182, 82);
            this.btnBankSupplier.TabIndex = 45;
            this.btnBankSupplier.Text = "Bank Supplier Management";
            this.btnBankSupplier.UseVisualStyleBackColor = false;
            this.btnBankSupplier.Click += new System.EventHandler(this.btnBankSupplier_Click);
            // 
            // frmSecretaryLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(208, 276);
            this.Controls.Add(this.btnBankSupplier);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnStaff);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSecretaryLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretary Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnBankSupplier;
    }
}