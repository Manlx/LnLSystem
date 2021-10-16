
namespace LnLBackEndSystem
{
    partial class frmBankUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.edtBank = new System.Windows.Forms.TextBox();
            this.lstBank = new System.Windows.Forms.ListBox();
            this.BtnUpdateBank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bank Name:";
            // 
            // edtBank
            // 
            this.edtBank.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edtBank.ForeColor = System.Drawing.Color.White;
            this.edtBank.Location = new System.Drawing.Point(154, 112);
            this.edtBank.Name = "edtBank";
            this.edtBank.Size = new System.Drawing.Size(202, 35);
            this.edtBank.TabIndex = 2;
            // 
            // lstBank
            // 
            this.lstBank.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstBank.ForeColor = System.Drawing.Color.White;
            this.lstBank.FormattingEnabled = true;
            this.lstBank.ItemHeight = 30;
            this.lstBank.Location = new System.Drawing.Point(25, 12);
            this.lstBank.Name = "lstBank";
            this.lstBank.Size = new System.Drawing.Size(331, 94);
            this.lstBank.TabIndex = 5;
            this.lstBank.SelectedIndexChanged += new System.EventHandler(this.lstBank_SelectedIndexChanged);
            // 
            // BtnUpdateBank
            // 
            this.BtnUpdateBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnUpdateBank.FlatAppearance.BorderSize = 0;
            this.BtnUpdateBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateBank.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateBank.Location = new System.Drawing.Point(27, 153);
            this.BtnUpdateBank.Name = "BtnUpdateBank";
            this.BtnUpdateBank.Size = new System.Drawing.Size(329, 46);
            this.BtnUpdateBank.TabIndex = 4;
            this.BtnUpdateBank.Text = "Update Bank";
            this.BtnUpdateBank.UseVisualStyleBackColor = false;
            this.BtnUpdateBank.Click += new System.EventHandler(this.BtnUpdateBank_Click);
            // 
            // frmBankUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(376, 212);
            this.Controls.Add(this.lstBank);
            this.Controls.Add(this.BtnUpdateBank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtBank);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankUpdate_FormClosed);
            this.Load += new System.EventHandler(this.frmBankUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtBank;
        private System.Windows.Forms.ListBox lstBank;
        private System.Windows.Forms.Button BtnUpdateBank;
    }
}