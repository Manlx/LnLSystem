
namespace LnLBackEndSystem
{
    partial class frmStaffBank
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlBankingInfo = new System.Windows.Forms.Panel();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnRemoveInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtBankNumber = new System.Windows.Forms.TextBox();
            this.EdtBankBranch = new System.Windows.Forms.TextBox();
            this.cbbBanks = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBankInfo = new System.Windows.Forms.ListBox();
            this.pnlBankingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(12, 361);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(571, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "&Commit Changes";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlBankingInfo
            // 
            this.pnlBankingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.pnlBankingInfo.Controls.Add(this.cbbSupplier);
            this.pnlBankingInfo.Controls.Add(this.label1);
            this.pnlBankingInfo.Controls.Add(this.btnAddInfo);
            this.pnlBankingInfo.Controls.Add(this.btnRemoveInfo);
            this.pnlBankingInfo.Controls.Add(this.label7);
            this.pnlBankingInfo.Controls.Add(this.label6);
            this.pnlBankingInfo.Controls.Add(this.edtBankNumber);
            this.pnlBankingInfo.Controls.Add(this.EdtBankBranch);
            this.pnlBankingInfo.Controls.Add(this.cbbBanks);
            this.pnlBankingInfo.Controls.Add(this.label5);
            this.pnlBankingInfo.Controls.Add(this.lstBankInfo);
            this.pnlBankingInfo.Location = new System.Drawing.Point(12, 10);
            this.pnlBankingInfo.Name = "pnlBankingInfo";
            this.pnlBankingInfo.Size = new System.Drawing.Size(571, 343);
            this.pnlBankingInfo.TabIndex = 2;
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSupplier.ForeColor = System.Drawing.Color.White;
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(90, 13);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(462, 38);
            this.cbbSupplier.TabIndex = 0;
            this.cbbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbbSupplier_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Staff:";
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAddInfo.FlatAppearance.BorderSize = 0;
            this.btnAddInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInfo.Location = new System.Drawing.Point(390, 177);
            this.btnAddInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(160, 46);
            this.btnAddInfo.TabIndex = 4;
            this.btnAddInfo.Text = "&Add Info";
            this.btnAddInfo.UseVisualStyleBackColor = false;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnRemoveInfo
            // 
            this.btnRemoveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRemoveInfo.FlatAppearance.BorderSize = 0;
            this.btnRemoveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveInfo.Location = new System.Drawing.Point(18, 177);
            this.btnRemoveInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveInfo.Name = "btnRemoveInfo";
            this.btnRemoveInfo.Size = new System.Drawing.Size(160, 46);
            this.btnRemoveInfo.TabIndex = 5;
            this.btnRemoveInfo.Text = "&Remove Info";
            this.btnRemoveInfo.UseVisualStyleBackColor = false;
            this.btnRemoveInfo.Click += new System.EventHandler(this.btnRemoveInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bank Branch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Account Number:";
            // 
            // edtBankNumber
            // 
            this.edtBankNumber.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edtBankNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtBankNumber.ForeColor = System.Drawing.Color.White;
            this.edtBankNumber.Location = new System.Drawing.Point(18, 136);
            this.edtBankNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtBankNumber.Name = "edtBankNumber";
            this.edtBankNumber.Size = new System.Drawing.Size(256, 35);
            this.edtBankNumber.TabIndex = 2;
            // 
            // EdtBankBranch
            // 
            this.EdtBankBranch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtBankBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtBankBranch.ForeColor = System.Drawing.Color.White;
            this.EdtBankBranch.Location = new System.Drawing.Point(294, 136);
            this.EdtBankBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtBankBranch.Name = "EdtBankBranch";
            this.EdtBankBranch.Size = new System.Drawing.Size(256, 35);
            this.EdtBankBranch.TabIndex = 3;
            // 
            // cbbBanks
            // 
            this.cbbBanks.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbbBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbBanks.ForeColor = System.Drawing.Color.White;
            this.cbbBanks.FormattingEnabled = true;
            this.cbbBanks.Location = new System.Drawing.Point(90, 60);
            this.cbbBanks.Name = "cbbBanks";
            this.cbbBanks.Size = new System.Drawing.Size(462, 38);
            this.cbbBanks.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bank:";
            // 
            // lstBankInfo
            // 
            this.lstBankInfo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstBankInfo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBankInfo.ForeColor = System.Drawing.Color.White;
            this.lstBankInfo.FormattingEnabled = true;
            this.lstBankInfo.ItemHeight = 18;
            this.lstBankInfo.Location = new System.Drawing.Point(18, 231);
            this.lstBankInfo.Name = "lstBankInfo";
            this.lstBankInfo.Size = new System.Drawing.Size(532, 94);
            this.lstBankInfo.TabIndex = 6;
            // 
            // frmStaffBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(594, 417);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlBankingInfo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStaffBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Bank Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStaffBank_FormClosed);
            this.Load += new System.EventHandler(this.frmStaffBankManagement_Load);
            this.pnlBankingInfo.ResumeLayout(false);
            this.pnlBankingInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlBankingInfo;
        private System.Windows.Forms.ComboBox cbbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnRemoveInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtBankNumber;
        private System.Windows.Forms.TextBox EdtBankBranch;
        private System.Windows.Forms.ComboBox cbbBanks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstBankInfo;
    }
}