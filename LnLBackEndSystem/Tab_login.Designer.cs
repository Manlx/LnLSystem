
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTabPIN = new System.Windows.Forms.TextBox();
            this.btnSubmitTab = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkToHome = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkToGuestLogin
            // 
            this.linkToGuestLogin.AutoSize = true;
            this.linkToGuestLogin.Location = new System.Drawing.Point(291, 261);
            this.linkToGuestLogin.Name = "linkToGuestLogin";
            this.linkToGuestLogin.Size = new System.Drawing.Size(140, 13);
            this.linkToGuestLogin.TabIndex = 1;
            this.linkToGuestLogin.TabStop = true;
            this.linkToGuestLogin.Text = "Return to guest login screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the following information to continue with the tab purchase";
            // 
            // txtTabID
            // 
            this.txtTabID.Location = new System.Drawing.Point(95, 86);
            this.txtTabID.Name = "txtTabID";
            this.txtTabID.Size = new System.Drawing.Size(139, 20);
            this.txtTabID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Tab ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Tab PIN : ";
            // 
            // txtTabPIN
            // 
            this.txtTabPIN.Location = new System.Drawing.Point(95, 129);
            this.txtTabPIN.Name = "txtTabPIN";
            this.txtTabPIN.Size = new System.Drawing.Size(139, 20);
            this.txtTabPIN.TabIndex = 6;
            // 
            // btnSubmitTab
            // 
            this.btnSubmitTab.Location = new System.Drawing.Point(15, 194);
            this.btnSubmitTab.Name = "btnSubmitTab";
            this.btnSubmitTab.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitTab.TabIndex = 7;
            this.btnSubmitTab.Text = "Submit";
            this.btnSubmitTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Click submit to proceed to order page!";
            // 
            // linkToHome
            // 
            this.linkToHome.AutoSize = true;
            this.linkToHome.Location = new System.Drawing.Point(12, 261);
            this.linkToHome.Name = "linkToHome";
            this.linkToHome.Size = new System.Drawing.Size(119, 13);
            this.linkToHome.TabIndex = 9;
            this.linkToHome.TabStop = true;
            this.linkToHome.Text = "Return to Home Screen";
            // 
            // Tab_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 283);
            this.Controls.Add(this.linkToHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmitTab);
            this.Controls.Add(this.txtTabPIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTabID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkToGuestLogin);
            this.Name = "Tab_login";
            this.Text = "Tab_login";
            this.Load += new System.EventHandler(this.Tab_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkToGuestLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTabPIN;
        private System.Windows.Forms.Button btnSubmitTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkToHome;
    }
}