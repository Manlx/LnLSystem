
namespace LnLBackEndSystem
{
    partial class frmClientRecoverPass
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
            this.edtClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIsValid = new System.Windows.Forms.Panel();
            this.lblIsValid = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtCellphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlIsValid.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtClientID
            // 
            this.edtClientID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edtClientID.Location = new System.Drawing.Point(186, 19);
            this.edtClientID.Name = "edtClientID";
            this.edtClientID.Size = new System.Drawing.Size(148, 35);
            this.edtClientID.TabIndex = 0;
            this.edtClientID.TextChanged += new System.EventHandler(this.AllEditChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID:";
            // 
            // pnlIsValid
            // 
            this.pnlIsValid.Controls.Add(this.lblIsValid);
            this.pnlIsValid.Location = new System.Drawing.Point(45, 215);
            this.pnlIsValid.Name = "pnlIsValid";
            this.pnlIsValid.Size = new System.Drawing.Size(391, 50);
            this.pnlIsValid.TabIndex = 2;
            // 
            // lblIsValid
            // 
            this.lblIsValid.AutoSize = true;
            this.lblIsValid.ForeColor = System.Drawing.Color.Black;
            this.lblIsValid.Location = new System.Drawing.Point(9, 10);
            this.lblIsValid.Name = "lblIsValid";
            this.lblIsValid.Size = new System.Drawing.Size(0, 30);
            this.lblIsValid.TabIndex = 0;
            // 
            // edtName
            // 
            this.edtName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edtName.Location = new System.Drawing.Point(186, 70);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(148, 35);
            this.edtName.TabIndex = 1;
            this.edtName.TextChanged += new System.EventHandler(this.AllEditChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // edtSurname
            // 
            this.edtSurname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edtSurname.Location = new System.Drawing.Point(186, 121);
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(148, 35);
            this.edtSurname.TabIndex = 2;
            this.edtSurname.TextChanged += new System.EventHandler(this.AllEditChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname:";
            // 
            // edtCellphone
            // 
            this.edtCellphone.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edtCellphone.Location = new System.Drawing.Point(186, 172);
            this.edtCellphone.Name = "edtCellphone";
            this.edtCellphone.Size = new System.Drawing.Size(148, 35);
            this.edtCellphone.TabIndex = 3;
            this.edtCellphone.TextChanged += new System.EventHandler(this.AllEditChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cell Number:";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUpdatePassword.FlatAppearance.BorderSize = 0;
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Location = new System.Drawing.Point(45, 332);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(391, 39);
            this.btnUpdatePassword.TabIndex = 5;
            this.btnUpdatePassword.Text = "Update Password";
            this.toolTip1.SetToolTip(this.btnUpdatePassword, "Overwrites Old password with new one");
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // edtPassword
            // 
            this.edtPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.edtPassword.Location = new System.Drawing.Point(186, 281);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '#';
            this.edtPassword.Size = new System.Drawing.Size(148, 35);
            this.edtPassword.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // frmClientRecoverPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(478, 390);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtCellphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.pnlIsValid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtClientID);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientRecoverPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover Client Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClientRecoverPass_FormClosed);
            this.Load += new System.EventHandler(this.frmClientRecoverPass_Load);
            this.pnlIsValid.ResumeLayout(false);
            this.pnlIsValid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlIsValid;
        private System.Windows.Forms.Label lblIsValid;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtCellphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}