
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
            this.linkToGuestLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkToGuestLogin
            // 
            this.linkToGuestLogin.AutoSize = true;
            this.linkToGuestLogin.Location = new System.Drawing.Point(12, 428);
            this.linkToGuestLogin.Name = "linkToGuestLogin";
            this.linkToGuestLogin.Size = new System.Drawing.Size(140, 13);
            this.linkToGuestLogin.TabIndex = 1;
            this.linkToGuestLogin.TabStop = true;
            this.linkToGuestLogin.Text = "Return to guest login screen";
            // 
            // Tab_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkToGuestLogin);
            this.Name = "Tab_login";
            this.Text = "Tab_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkToGuestLogin;
    }
}