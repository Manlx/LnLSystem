
namespace LnLBackEndSystem
{
    partial class frmBankPage
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
            this.btnRemoveBank = new System.Windows.Forms.Button();
            this.btnBankAdd = new System.Windows.Forms.Button();
            this.btnUploadBank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveBank
            // 
            this.btnRemoveBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRemoveBank.FlatAppearance.BorderSize = 0;
            this.btnRemoveBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBank.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoveBank.Location = new System.Drawing.Point(15, 99);
            this.btnRemoveBank.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnRemoveBank.Name = "btnRemoveBank";
            this.btnRemoveBank.Size = new System.Drawing.Size(182, 82);
            this.btnRemoveBank.TabIndex = 1;
            this.btnRemoveBank.Text = "Remove &Bank";
            this.btnRemoveBank.UseVisualStyleBackColor = false;
            this.btnRemoveBank.Click += new System.EventHandler(this.btnRemoveBank_Click);
            // 
            // btnBankAdd
            // 
            this.btnBankAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBankAdd.FlatAppearance.BorderSize = 0;
            this.btnBankAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBankAdd.Location = new System.Drawing.Point(15, 9);
            this.btnBankAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnBankAdd.Name = "btnBankAdd";
            this.btnBankAdd.Size = new System.Drawing.Size(182, 82);
            this.btnBankAdd.TabIndex = 2;
            this.btnBankAdd.Text = "&Add Bank";
            this.btnBankAdd.UseVisualStyleBackColor = false;
            this.btnBankAdd.Click += new System.EventHandler(this.btnBankAdd_Click);
            // 
            // btnUploadBank
            // 
            this.btnUploadBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUploadBank.FlatAppearance.BorderSize = 0;
            this.btnUploadBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadBank.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUploadBank.Location = new System.Drawing.Point(15, 189);
            this.btnUploadBank.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnUploadBank.Name = "btnUploadBank";
            this.btnUploadBank.Size = new System.Drawing.Size(182, 82);
            this.btnUploadBank.TabIndex = 3;
            this.btnUploadBank.Text = "&Update Bank";
            this.btnUploadBank.UseVisualStyleBackColor = false;
            this.btnUploadBank.Click += new System.EventHandler(this.btnUploadBank_Click);
            // 
            // frmBankPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(212, 280);
            this.Controls.Add(this.btnUploadBank);
            this.Controls.Add(this.btnBankAdd);
            this.Controls.Add(this.btnRemoveBank);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Home Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankPage_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveBank;
        private System.Windows.Forms.Button btnBankAdd;
        private System.Windows.Forms.Button btnUploadBank;
    }
}