
namespace LnLBackEndSystem
{
    partial class Admin_signup
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.cbLicence = new System.Windows.Forms.CheckBox();
            this.cbFulltimeMember = new System.Windows.Forms.CheckBox();
            this.cbRank = new System.Windows.Forms.ComboBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 79);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoSize = true;
            this.lblCellNumber.Location = new System.Drawing.Point(12, 113);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(97, 13);
            this.lblCellNumber.TabIndex = 2;
            this.lblCellNumber.Text = "Cellphone Number:";
            // 
            // cbLicence
            // 
            this.cbLicence.AutoSize = true;
            this.cbLicence.Location = new System.Drawing.Point(15, 152);
            this.cbLicence.Name = "cbLicence";
            this.cbLicence.Size = new System.Drawing.Size(102, 17);
            this.cbLicence.TabIndex = 3;
            this.cbLicence.Text = "I have a licence";
            this.cbLicence.UseVisualStyleBackColor = true;
            // 
            // cbFulltimeMember
            // 
            this.cbFulltimeMember.AutoSize = true;
            this.cbFulltimeMember.Location = new System.Drawing.Point(15, 189);
            this.cbFulltimeMember.Name = "cbFulltimeMember";
            this.cbFulltimeMember.Size = new System.Drawing.Size(133, 17);
            this.cbFulltimeMember.TabIndex = 4;
            this.cbFulltimeMember.Text = "I am a full time member";
            this.cbFulltimeMember.UseVisualStyleBackColor = true;
            // 
            // cbRank
            // 
            this.cbRank.FormattingEnabled = true;
            this.cbRank.Location = new System.Drawing.Point(126, 224);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(121, 21);
            this.cbRank.TabIndex = 5;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(12, 232);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(47, 13);
            this.lblRank.TabIndex = 6;
            this.lblRank.Text = "RankID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(147, 76);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(147, 110);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(100, 20);
            this.txtCellphone.TabIndex = 9;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(10, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(229, 25);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "Personal Information";
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(88, 270);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 23);
            this.btnSignup.TabIndex = 11;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // Admin_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 306);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtCellphone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.cbRank);
            this.Controls.Add(this.cbFulltimeMember);
            this.Controls.Add(this.cbLicence);
            this.Controls.Add(this.lblCellNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "Admin_signup";
            this.Text = "Admin_signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblCellNumber;
        private System.Windows.Forms.CheckBox cbLicence;
        private System.Windows.Forms.CheckBox cbFulltimeMember;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSignup;
    }
}