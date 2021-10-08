
namespace LnLBackEndSystem
{
    partial class Booking_Management
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHeadings = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFacilities = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.clsRequirements = new System.Windows.Forms.CheckedListBox();
            this.lstVenues = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.DTPTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(264, 607);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add booking";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHeadings
            // 
            this.lblHeadings.AutoSize = true;
            this.lblHeadings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadings.Location = new System.Drawing.Point(35, 103);
            this.lblHeadings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadings.Name = "lblHeadings";
            this.lblHeadings.Size = new System.Drawing.Size(116, 16);
            this.lblHeadings.TabIndex = 1;
            this.lblHeadings.Text = "Booking details";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(34, 127);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(152, 21);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Please select a date";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(35, 190);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 21);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // lblFacilities
            // 
            this.lblFacilities.AutoSize = true;
            this.lblFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilities.Location = new System.Drawing.Point(36, 223);
            this.lblFacilities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacilities.Name = "lblFacilities";
            this.lblFacilities.Size = new System.Drawing.Size(71, 16);
            this.lblFacilities.TabIndex = 11;
            this.lblFacilities.Text = "Facilities";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(112, 187);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(148, 29);
            this.cbType.TabIndex = 16;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(37, 607);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 37);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // clsRequirements
            // 
            this.clsRequirements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clsRequirements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clsRequirements.ForeColor = System.Drawing.Color.White;
            this.clsRequirements.FormattingEnabled = true;
            this.clsRequirements.Location = new System.Drawing.Point(38, 244);
            this.clsRequirements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clsRequirements.Name = "clsRequirements";
            this.clsRequirements.Size = new System.Drawing.Size(340, 194);
            this.clsRequirements.TabIndex = 18;
            this.clsRequirements.TabIndexChanged += new System.EventHandler(this.clsRequirements_Click);
            // 
            // lstVenues
            // 
            this.lstVenues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstVenues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVenues.ForeColor = System.Drawing.Color.White;
            this.lstVenues.FormattingEnabled = true;
            this.lstVenues.ItemHeight = 21;
            this.lstVenues.Location = new System.Drawing.Point(38, 448);
            this.lstVenues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstVenues.Name = "lstVenues";
            this.lstVenues.Size = new System.Drawing.Size(340, 149);
            this.lstVenues.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Client Details";
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Location = new System.Drawing.Point(37, 47);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(118, 35);
            this.btnClient.TabIndex = 22;
            this.btnClient.Text = "Client Login";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // DTPDate
            // 
            this.DTPDate.CustomFormat = "yyyy - MM - dd ";
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDate.Location = new System.Drawing.Point(37, 150);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.ShowUpDown = true;
            this.DTPDate.Size = new System.Drawing.Size(132, 29);
            this.DTPDate.TabIndex = 23;
            // 
            // DTPTime
            // 
            this.DTPTime.CustomFormat = "HH:mm";
            this.DTPTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPTime.Location = new System.Drawing.Point(189, 150);
            this.DTPTime.Name = "DTPTime";
            this.DTPTime.ShowUpDown = true;
            this.DTPTime.Size = new System.Drawing.Size(144, 29);
            this.DTPTime.TabIndex = 24;
            // 
            // Booking_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(398, 660);
            this.Controls.Add(this.DTPTime);
            this.Controls.Add(this.DTPDate);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVenues);
            this.Controls.Add(this.clsRequirements);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblFacilities);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeadings);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Booking_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking_Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Booking_Management_FormClosing);
            this.Load += new System.EventHandler(this.Booking_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHeadings;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckedListBox clsRequirements;
        private System.Windows.Forms.ListBox lstVenues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.DateTimePicker DTPTime;
    }
}