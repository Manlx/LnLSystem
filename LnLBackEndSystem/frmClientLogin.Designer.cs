
namespace LnLBackEndSystem
{
    partial class frmClientLogin
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
            this.components = new System.ComponentModel.Container();
            this.edtID = new System.Windows.Forms.TextBox();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClientForgot = new System.Windows.Forms.Button();
            this.ttTips = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // edtID
            // 
            this.edtID.Location = new System.Drawing.Point(152, 13);
            this.edtID.Margin = new System.Windows.Forms.Padding(4);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(204, 35);
            this.edtID.TabIndex = 0;
            this.ttTips.SetToolTip(this.edtID, "Example: 0");
            // 
            // edtPassword
            // 
            this.edtPassword.Location = new System.Drawing.Point(152, 72);
            this.edtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '#';
            this.edtPassword.Size = new System.Drawing.Size(204, 35);
            this.edtPassword.TabIndex = 1;
            this.ttTips.SetToolTip(this.edtPassword, "Example: Pass123");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(33, 172);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(323, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClientForgot
            // 
            this.btnClientForgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClientForgot.FlatAppearance.BorderSize = 0;
            this.btnClientForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientForgot.Location = new System.Drawing.Point(33, 123);
            this.btnClientForgot.Name = "btnClientForgot";
            this.btnClientForgot.Size = new System.Drawing.Size(323, 43);
            this.btnClientForgot.TabIndex = 5;
            this.btnClientForgot.Text = "Forgot password";
            this.btnClientForgot.UseVisualStyleBackColor = false;
            this.btnClientForgot.Click += new System.EventHandler(this.btnClientForgot_Click);
            // 
            // ttTips
            // 
            this.ttTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ttTips.ForeColor = System.Drawing.Color.White;
            // 
            // frmClientLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(387, 244);
            this.Controls.Add(this.btnClientForgot);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.edtID);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClientLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClientForgot;
        private System.Windows.Forms.ToolTip ttTips;
    }
}