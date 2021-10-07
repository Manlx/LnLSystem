
namespace LnLBackEndSystem
{
    partial class Tab_Order
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
            this.txtTabSettleAmount = new System.Windows.Forms.TextBox();
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
            // txtTabSettleAmount
            // 
            this.txtTabSettleAmount.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTabSettleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTabSettleAmount.ForeColor = System.Drawing.Color.White;
            this.txtTabSettleAmount.Location = new System.Drawing.Point(193, 105);
            this.txtTabSettleAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTabSettleAmount.Name = "txtTabSettleAmount";
            this.txtTabSettleAmount.Size = new System.Drawing.Size(149, 29);
            this.txtTabSettleAmount.TabIndex = 7;
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
            // Tab_Order
            // 
            this.AcceptButton = this.btnSubmitTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(360, 162);
            this.Controls.Add(this.btnSubmitTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTabSettleAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tab_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tab Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tab_Order_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTabSettleAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmitTotal;
    }
}