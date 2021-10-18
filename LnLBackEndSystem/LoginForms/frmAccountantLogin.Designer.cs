
namespace LnLBackEndSystem
{
    partial class frmAccountantLogin
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
            this.btnAccountantReport = new System.Windows.Forms.Button();
            this.btnBankManagement = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccountantReport
            // 
            this.btnAccountantReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAccountantReport.FlatAppearance.BorderSize = 0;
            this.btnAccountantReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountantReport.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAccountantReport.Location = new System.Drawing.Point(15, 9);
            this.btnAccountantReport.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAccountantReport.Name = "btnAccountantReport";
            this.btnAccountantReport.Size = new System.Drawing.Size(182, 82);
            this.btnAccountantReport.TabIndex = 3;
            this.btnAccountantReport.Text = "&Reports";
            this.btnAccountantReport.UseVisualStyleBackColor = false;
            this.btnAccountantReport.Click += new System.EventHandler(this.btnAccountantReport_Click);
            // 
            // btnBankManagement
            // 
            this.btnBankManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBankManagement.FlatAppearance.BorderSize = 0;
            this.btnBankManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBankManagement.Location = new System.Drawing.Point(15, 99);
            this.btnBankManagement.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnBankManagement.Name = "btnBankManagement";
            this.btnBankManagement.Size = new System.Drawing.Size(182, 82);
            this.btnBankManagement.TabIndex = 4;
            this.btnBankManagement.Text = "&Bank Management";
            this.btnBankManagement.UseVisualStyleBackColor = false;
            this.btnBankManagement.Click += new System.EventHandler(this.btnBankManagement_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSuppliers.Location = new System.Drawing.Point(15, 189);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(182, 82);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "&Supplier Management";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // frmAccountantLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(212, 280);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnBankManagement);
            this.Controls.Add(this.btnAccountantReport);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountantLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accountant Homepage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccountantLogin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccountantReport;
        private System.Windows.Forms.Button btnBankManagement;
        private System.Windows.Forms.Button btnSuppliers;
    }
}