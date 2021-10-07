
namespace LnLBackEndSystem
{
    partial class Tab_login
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
            this.txtTabID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTabPIN = new System.Windows.Forms.TextBox();
            this.btnSubmitTab = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the following information to continue\r\nwith the tab purchase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTabID
            // 
            this.txtTabID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTabID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTabID.ForeColor = System.Drawing.Color.White;
            this.txtTabID.Location = new System.Drawing.Point(175, 68);
            this.txtTabID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTabID.Name = "txtTabID";
            this.txtTabID.Size = new System.Drawing.Size(185, 27);
            this.txtTabID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Tab ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Tab PIN : ";
            // 
            // txtTabPIN
            // 
            this.txtTabPIN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTabPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTabPIN.ForeColor = System.Drawing.Color.White;
            this.txtTabPIN.Location = new System.Drawing.Point(175, 100);
            this.txtTabPIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTabPIN.Name = "txtTabPIN";
            this.txtTabPIN.Size = new System.Drawing.Size(185, 27);
            this.txtTabPIN.TabIndex = 6;
            // 
            // btnSubmitTab
            // 
            this.btnSubmitTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSubmitTab.FlatAppearance.BorderSize = 0;
            this.btnSubmitTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTab.Location = new System.Drawing.Point(234, 169);
            this.btnSubmitTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitTab.Name = "btnSubmitTab";
            this.btnSubmitTab.Size = new System.Drawing.Size(143, 51);
            this.btnSubmitTab.TabIndex = 7;
            this.btnSubmitTab.Text = "Submit";
            this.btnSubmitTab.UseVisualStyleBackColor = false;
            this.btnSubmitTab.Click += new System.EventHandler(this.btnSubmitTab_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Click submit to proceed to order page!";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(69, 169);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 51);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Tab_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(447, 230);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmitTab);
            this.Controls.Add(this.txtTabPIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTabID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tab_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tab_login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tab_login_FormClosed);
            this.Load += new System.EventHandler(this.Tab_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTabPIN;
        private System.Windows.Forms.Button btnSubmitTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}