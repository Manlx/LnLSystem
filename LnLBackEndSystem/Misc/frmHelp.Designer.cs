
namespace LnLBackEndSystem
{
    partial class frmHelp
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
            this.memOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // memOutput
            // 
            this.memOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.memOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memOutput.ForeColor = System.Drawing.Color.White;
            this.memOutput.Location = new System.Drawing.Point(0, 0);
            this.memOutput.Multiline = true;
            this.memOutput.Name = "memOutput";
            this.memOutput.ReadOnly = true;
            this.memOutput.Size = new System.Drawing.Size(742, 406);
            this.memOutput.TabIndex = 0;
            this.memOutput.TabStop = false;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(742, 406);
            this.Controls.Add(this.memOutput);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHelp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memOutput;
    }
}