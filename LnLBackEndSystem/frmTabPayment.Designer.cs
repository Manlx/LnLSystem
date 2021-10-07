
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmitTotal = new System.Windows.Forms.Button();
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
            this.label5.Location = new System.Drawing.Point(13, 58);
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
            this.EdtAmount.Location = new System.Drawing.Point(161, 105);
            this.EdtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtAmount.Name = "EdtAmount";
            this.EdtAmount.Size = new System.Drawing.Size(149, 29);
            this.EdtAmount.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "R 00,00";
            // 
            // btnSubmitTotal
            // 
            this.btnSubmitTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSubmitTotal.FlatAppearance.BorderSize = 0;
            this.btnSubmitTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTotal.Location = new System.Drawing.Point(17, 99);
            this.btnSubmitTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitTotal.Name = "btnSubmitTotal";
            this.btnSubmitTotal.Size = new System.Drawing.Size(112, 37);
            this.btnSubmitTotal.TabIndex = 15;
            this.btnSubmitTotal.Text = "Submit Total";
            this.btnSubmitTotal.UseVisualStyleBackColor = false;
            this.btnSubmitTotal.Click += new System.EventHandler(this.btnSubmitTotal_Click);
            // 
            // frmTabPayment
            // 
            this.AcceptButton = this.btnSubmitTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(324, 150);
            this.Controls.Add(this.btnSubmitTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EdtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTabPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tab Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tab_Order_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EdtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmitTotal;
    }
}