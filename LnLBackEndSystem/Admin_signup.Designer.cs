
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
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
            // 
            // Admin_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 306);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSignup;
    }
}