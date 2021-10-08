
namespace LnLBackEndSystem
{
    partial class Update_Booking
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lstVenues = new System.Windows.Forms.ListBox();
            this.clsRequirements = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cldDate = new System.Windows.Forms.MonthCalendar();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblFacilities = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHeadings = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Client ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Client Details";
            // 
            // txtClientID
            // 
            this.txtClientID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientID.ForeColor = System.Drawing.Color.White;
            this.txtClientID.Location = new System.Drawing.Point(99, 46);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(100, 20);
            this.txtClientID.TabIndex = 35;
            // 
            // lstVenues
            // 
            this.lstVenues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstVenues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVenues.ForeColor = System.Drawing.Color.White;
            this.lstVenues.FormattingEnabled = true;
            this.lstVenues.Location = new System.Drawing.Point(24, 523);
            this.lstVenues.Name = "lstVenues";
            this.lstVenues.Size = new System.Drawing.Size(227, 145);
            this.lstVenues.TabIndex = 34;
            // 
            // clsRequirements
            // 
            this.clsRequirements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clsRequirements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clsRequirements.ForeColor = System.Drawing.Color.White;
            this.clsRequirements.FormattingEnabled = true;
            this.clsRequirements.Location = new System.Drawing.Point(24, 390);
            this.clsRequirements.Name = "clsRequirements";
            this.clsRequirements.Size = new System.Drawing.Size(227, 122);
            this.clsRequirements.TabIndex = 33;
            this.clsRequirements.Click += new System.EventHandler(this.clsRequirements_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(318, 714);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(64, 332);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 21);
            this.cbType.TabIndex = 31;
            // 
            // cldDate
            // 
            this.cldDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cldDate.ForeColor = System.Drawing.Color.White;
            this.cldDate.Location = new System.Drawing.Point(18, 132);
            this.cldDate.Name = "cldDate";
            this.cldDate.TabIndex = 30;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.Location = new System.Drawing.Point(64, 306);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 29;
            this.txtTime.Text = "00:00:00";
            // 
            // lblFacilities
            // 
            this.lblFacilities.AutoSize = true;
            this.lblFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilities.Location = new System.Drawing.Point(22, 371);
            this.lblFacilities.Name = "lblFacilities";
            this.lblFacilities.Size = new System.Drawing.Size(71, 16);
            this.lblFacilities.TabIndex = 28;
            this.lblFacilities.Text = "Facilities";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(22, 332);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 27;
            this.lblType.Text = "Type:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(22, 309);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 13);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Please select a date";
            // 
            // lblHeadings
            // 
            this.lblHeadings.AutoSize = true;
            this.lblHeadings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadings.Location = new System.Drawing.Point(22, 84);
            this.lblHeadings.Name = "lblHeadings";
            this.lblHeadings.Size = new System.Drawing.Size(116, 16);
            this.lblHeadings.TabIndex = 24;
            this.lblHeadings.Text = "Booking details";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(86, 674);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 51);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Update booking";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Update_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(405, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lstVenues);
            this.Controls.Add(this.clsRequirements);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cldDate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblFacilities);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeadings);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Update_Booking";
            this.Text = "Update_Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_Booking_FormClosing);
            this.Load += new System.EventHandler(this.Update_Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.ListBox lstVenues;
        private System.Windows.Forms.CheckedListBox clsRequirements;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.MonthCalendar cldDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHeadings;
        private System.Windows.Forms.Button btnAdd;
    }
}