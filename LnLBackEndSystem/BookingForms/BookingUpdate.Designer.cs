
namespace LnLBackEndSystem
{
    partial class BookingUpdate
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
            this.lstVenues = new System.Windows.Forms.ListBox();
            this.clsRequirements = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblFacilities = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHeadings = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DTPTime = new System.Windows.Forms.DateTimePicker();
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.lstBooking = new System.Windows.Forms.ListBox();
            this.gpbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Client Details";
            // 
            // lstVenues
            // 
            this.lstVenues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstVenues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVenues.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVenues.ForeColor = System.Drawing.Color.White;
            this.lstVenues.FormattingEnabled = true;
            this.lstVenues.ItemHeight = 25;
            this.lstVenues.Location = new System.Drawing.Point(17, 319);
            this.lstVenues.Name = "lstVenues";
            this.lstVenues.Size = new System.Drawing.Size(227, 127);
            this.lstVenues.TabIndex = 4;
            // 
            // clsRequirements
            // 
            this.clsRequirements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clsRequirements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clsRequirements.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsRequirements.ForeColor = System.Drawing.Color.White;
            this.clsRequirements.FormattingEnabled = true;
            this.clsRequirements.Location = new System.Drawing.Point(17, 195);
            this.clsRequirements.Name = "clsRequirements";
            this.clsRequirements.Size = new System.Drawing.Size(227, 114);
            this.clsRequirements.TabIndex = 3;
            this.clsRequirements.Click += new System.EventHandler(this.clsRequirements_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(354, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(93, 132);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 33);
            this.cbType.TabIndex = 2;
            // 
            // lblFacilities
            // 
            this.lblFacilities.AutoSize = true;
            this.lblFacilities.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilities.Location = new System.Drawing.Point(17, 167);
            this.lblFacilities.Name = "lblFacilities";
            this.lblFacilities.Size = new System.Drawing.Size(83, 25);
            this.lblFacilities.TabIndex = 28;
            this.lblFacilities.Text = "Facilities";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(17, 135);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 25);
            this.lblType.TabIndex = 27;
            this.lblType.Text = "Type:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(17, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 25);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(17, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(176, 25);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Please select a date";
            // 
            // lblHeadings
            // 
            this.lblHeadings.AutoSize = true;
            this.lblHeadings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadings.Location = new System.Drawing.Point(6, 0);
            this.lblHeadings.Name = "lblHeadings";
            this.lblHeadings.Size = new System.Drawing.Size(141, 25);
            this.lblHeadings.TabIndex = 24;
            this.lblHeadings.Text = "Booking details";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(17, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 67);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Update booking";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DTPTime
            // 
            this.DTPTime.CustomFormat = "HH:mm";
            this.DTPTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPTime.Location = new System.Drawing.Point(93, 100);
            this.DTPTime.Name = "DTPTime";
            this.DTPTime.Size = new System.Drawing.Size(200, 33);
            this.DTPTime.TabIndex = 1;
            // 
            // gpbOptions
            // 
            this.gpbOptions.Controls.Add(this.DTPDate);
            this.gpbOptions.Controls.Add(this.DTPTime);
            this.gpbOptions.Controls.Add(this.btnAdd);
            this.gpbOptions.Controls.Add(this.lblHeadings);
            this.gpbOptions.Controls.Add(this.lblTime);
            this.gpbOptions.Controls.Add(this.lblType);
            this.gpbOptions.Controls.Add(this.lblDate);
            this.gpbOptions.Controls.Add(this.lblFacilities);
            this.gpbOptions.Controls.Add(this.lstVenues);
            this.gpbOptions.Controls.Add(this.cbType);
            this.gpbOptions.Controls.Add(this.clsRequirements);
            this.gpbOptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOptions.Location = new System.Drawing.Point(12, 187);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(489, 537);
            this.gpbOptions.TabIndex = 2;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Enter += new System.EventHandler(this.gpbOptions_Enter);
            // 
            // DTPDate
            // 
            this.DTPDate.CustomFormat = "yyyy-MM-dd";
            this.DTPDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDate.Location = new System.Drawing.Point(93, 68);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(200, 33);
            this.DTPDate.TabIndex = 0;
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSelectClient.FlatAppearance.BorderSize = 0;
            this.btnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectClient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectClient.Location = new System.Drawing.Point(12, 41);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(147, 47);
            this.btnSelectClient.TabIndex = 0;
            this.btnSelectClient.Text = "Client Login";
            this.btnSelectClient.UseVisualStyleBackColor = false;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // lstBooking
            // 
            this.lstBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstBooking.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBooking.ForeColor = System.Drawing.Color.White;
            this.lstBooking.FormattingEnabled = true;
            this.lstBooking.ItemHeight = 18;
            this.lstBooking.Location = new System.Drawing.Point(12, 94);
            this.lstBooking.Name = "lstBooking";
            this.lstBooking.Size = new System.Drawing.Size(489, 94);
            this.lstBooking.TabIndex = 1;
            // 
            // Update_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(513, 736);
            this.Controls.Add(this.lstBooking);
            this.Controls.Add(this.gpbOptions);
            this.Controls.Add(this.btnSelectClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_Booking_FormClosing);
            this.Load += new System.EventHandler(this.Update_Booking_Load);
            this.gpbOptions.ResumeLayout(false);
            this.gpbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstVenues;
        private System.Windows.Forms.CheckedListBox clsRequirements;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHeadings;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker DTPTime;
        private System.Windows.Forms.GroupBox gpbOptions;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.ListBox lstBooking;
    }
}