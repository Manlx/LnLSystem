
namespace LnLBackEndSystem
{
    partial class frmBankAdd
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
            this.edtBank = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegisterBank = new System.Windows.Forms.Button();
            this.lstBank = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // edtBank
            // 
            this.edtBank.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edtBank.ForeColor = System.Drawing.Color.White;
            this.edtBank.Location = new System.Drawing.Point(151, 16);
            this.edtBank.Name = "edtBank";
            this.edtBank.Size = new System.Drawing.Size(202, 35);
            this.edtBank.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Name:";
            // 
            // BtnRegisterBank
            // 
            this.BtnRegisterBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnRegisterBank.FlatAppearance.BorderSize = 0;
            this.BtnRegisterBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegisterBank.ForeColor = System.Drawing.Color.White;
            this.BtnRegisterBank.Location = new System.Drawing.Point(22, 163);
            this.BtnRegisterBank.Name = "BtnRegisterBank";
            this.BtnRegisterBank.Size = new System.Drawing.Size(329, 46);
            this.BtnRegisterBank.TabIndex = 2;
            this.BtnRegisterBank.Text = "Register Bank";
            this.BtnRegisterBank.UseVisualStyleBackColor = false;
            this.BtnRegisterBank.Click += new System.EventHandler(this.BtnRegisterBank_Click);
            // 
            // lstBank
            // 
            this.lstBank.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstBank.ForeColor = System.Drawing.Color.White;
            this.lstBank.FormattingEnabled = true;
            this.lstBank.ItemHeight = 30;
            this.lstBank.Location = new System.Drawing.Point(22, 61);
            this.lstBank.Name = "lstBank";
            this.lstBank.Size = new System.Drawing.Size(331, 94);
            this.lstBank.TabIndex = 3;
            // 
            // frmBankAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(371, 221);
            this.Controls.Add(this.lstBank);
            this.Controls.Add(this.BtnRegisterBank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtBank);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Bank";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegisterBank;
        private System.Windows.Forms.ListBox lstBank;
    }
}