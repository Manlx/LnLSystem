
namespace LnLBackEndSystem
{
    partial class Delete_Booking
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cldTime = new System.Windows.Forms.MonthCalendar();
            this.lstBookings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnDelete.Location = new System.Drawing.Point(78, 391);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 42);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete booking";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cldTime
            // 
            this.cldTime.Location = new System.Drawing.Point(69, 18);
            this.cldTime.Name = "cldTime";
            this.cldTime.TabIndex = 36;
            this.cldTime.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldTime_DateSelected);
            // 
            // lstBookings
            // 
            this.lstBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstBookings.ForeColor = System.Drawing.Color.White;
            this.lstBookings.FormattingEnabled = true;
            this.lstBookings.ItemHeight = 25;
            this.lstBookings.Location = new System.Drawing.Point(12, 192);
            this.lstBookings.Name = "lstBookings";
            this.lstBookings.Size = new System.Drawing.Size(341, 179);
            this.lstBookings.TabIndex = 37;
            // 
            // Delete_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(365, 448);
            this.Controls.Add(this.lstBookings);
            this.Controls.Add(this.cldTime);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Delete_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delete_Booking_FormClosing);
            this.Load += new System.EventHandler(this.Delete_Booking_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MonthCalendar cldTime;
        private System.Windows.Forms.ListBox lstBookings;
    }
}