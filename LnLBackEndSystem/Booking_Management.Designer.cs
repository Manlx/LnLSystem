
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFacilities = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cldDate = new System.Windows.Forms.MonthCalendar();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.clsRequirements = new System.Windows.Forms.CheckedListBox();
            this.lstVenues = new System.Windows.Forms.ListBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(24, 666);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add booking";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHeadings
            // 
            this.lblHeadings.AutoSize = true;
            this.lblHeadings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadings.Location = new System.Drawing.Point(22, 80);
            this.lblHeadings.Name = "lblHeadings";
            this.lblHeadings.Size = new System.Drawing.Size(116, 16);
            this.lblHeadings.TabIndex = 1;
            this.lblHeadings.Text = "Booking details";
            this.lblHeadings.Click += new System.EventHandler(this.lblHeadings_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Please select a date";
            this.lblDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(22, 305);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(22, 328);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // lblFacilities
            // 
            this.lblFacilities.AutoSize = true;
            this.lblFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilities.Location = new System.Drawing.Point(22, 367);
            this.lblFacilities.Name = "lblFacilities";
            this.lblFacilities.Size = new System.Drawing.Size(71, 16);
            this.lblFacilities.TabIndex = 11;
            this.lblFacilities.Text = "Facilities";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(64, 302);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 14;
            // 
            // cldDate
            // 
            this.cldDate.Location = new System.Drawing.Point(18, 128);
            this.cldDate.Name = "cldDate";
            this.cldDate.TabIndex = 15;
            this.cldDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(64, 328);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 21);
            this.cbType.TabIndex = 16;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(257, 656);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // clsRequirements
            // 
            this.clsRequirements.FormattingEnabled = true;
            this.clsRequirements.Location = new System.Drawing.Point(24, 386);
            this.clsRequirements.Name = "clsRequirements";
            this.clsRequirements.Size = new System.Drawing.Size(227, 124);
            this.clsRequirements.TabIndex = 18;
            this.clsRequirements.Click += new System.EventHandler(this.clsRequirements_Click);
            // 
            // lstVenues
            // 
            this.lstVenues.FormattingEnabled = true;
            this.lstVenues.Location = new System.Drawing.Point(24, 519);
            this.lstVenues.Name = "lstVenues";
            this.lstVenues.Size = new System.Drawing.Size(227, 147);
            this.lstVenues.TabIndex = 19;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(99, 42);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(100, 20);
            this.txtClientID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Client Details";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Client Details";
            // 
            // Booking_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 723);
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
            this.Name = "Booking_Management";
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
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.MonthCalendar cldDate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckedListBox clsRequirements;
        private System.Windows.Forms.ListBox lstVenues;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}