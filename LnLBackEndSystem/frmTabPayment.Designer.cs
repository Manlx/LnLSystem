
namespace LnLBackEndSystem
{
    partial class frmTabPayment
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
            this.label5 = new System.Windows.Forms.Label();
            this.EdtAmount = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnSubmitTotal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCutOffValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outstanding balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter amount you would like to settle:";
            // 
            // EdtAmount
            // 
            this.EdtAmount.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtAmount.ForeColor = System.Drawing.Color.White;
            this.EdtAmount.Location = new System.Drawing.Point(161, 111);
            this.EdtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtAmount.Name = "EdtAmount";
            this.EdtAmount.Size = new System.Drawing.Size(222, 29);
            this.EdtAmount.TabIndex = 0;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(175, 15);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(64, 21);
            this.lblBalance.TabIndex = 12;
            this.lblBalance.Text = "R 00,00";
            // 
            // btnSubmitTotal
            // 
            this.btnSubmitTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSubmitTotal.FlatAppearance.BorderSize = 0;
            this.btnSubmitTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTotal.Location = new System.Drawing.Point(17, 105);
            this.btnSubmitTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitTotal.Name = "btnSubmitTotal";
            this.btnSubmitTotal.Size = new System.Drawing.Size(112, 37);
            this.btnSubmitTotal.TabIndex = 1;
            this.btnSubmitTotal.Text = "Submit Total";
            this.btnSubmitTotal.UseVisualStyleBackColor = false;
            this.btnSubmitTotal.Click += new System.EventHandler(this.btnSubmitTotal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cut off Value:";
            // 
            // lblCutOffValue
            // 
            this.lblCutOffValue.AutoSize = true;
            this.lblCutOffValue.Location = new System.Drawing.Point(175, 44);
            this.lblCutOffValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCutOffValue.Name = "lblCutOffValue";
            this.lblCutOffValue.Size = new System.Drawing.Size(63, 21);
            this.lblCutOffValue.TabIndex = 17;
            this.lblCutOffValue.Text = "Cut Off";
            // 
            // frmTabPayment
            // 
            this.AcceptButton = this.btnSubmitTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(396, 150);
            this.Controls.Add(this.lblCutOffValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmitTotal);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.EdtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTabPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tab Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tab_Order_FormClosing);
            this.Load += new System.EventHandler(this.frmTabPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EdtAmount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnSubmitTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCutOffValue;
    }
}