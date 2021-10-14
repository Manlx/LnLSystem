
namespace LnLBackEndSystem
{
    partial class frmHRAdmin
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
            this.btnStaffBank = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaffBank
            // 
            this.btnStaffBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnStaffBank.FlatAppearance.BorderSize = 0;
            this.btnStaffBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffBank.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStaffBank.Location = new System.Drawing.Point(13, 99);
            this.btnStaffBank.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStaffBank.Name = "btnStaffBank";
            this.btnStaffBank.Size = new System.Drawing.Size(182, 82);
            this.btnStaffBank.TabIndex = 6;
            this.btnStaffBank.Text = "S&taff Bank Management";
            this.btnStaffBank.UseVisualStyleBackColor = false;
            this.btnStaffBank.Click += new System.EventHandler(this.btnStaffBank_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStaff.Location = new System.Drawing.Point(13, 9);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(182, 82);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "&Staff Management";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // frmHRAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(208, 190);
            this.Controls.Add(this.btnStaffBank);
            this.Controls.Add(this.btnStaff);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmHRAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHRAdmin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaffBank;
        private System.Windows.Forms.Button btnStaff;
    }
}