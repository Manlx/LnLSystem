﻿
namespace LnLBackEndSystem
{
    partial class Secretary_form
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
            this.dbView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbView
            // 
            this.dbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbView.Location = new System.Drawing.Point(0, 0);
            this.dbView.Name = "dbView";
            this.dbView.Size = new System.Drawing.Size(449, 178);
            this.dbView.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(158, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 53);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Staff Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(302, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Staff Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(12, 184);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(138, 54);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert Staff Record";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(361, 265);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 21);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(12, 244);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(138, 41);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "Manage Bookings";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(156, 243);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(135, 42);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Generate Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Secretary_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 297);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dbView);
            this.Name = "Secretary_form";
            this.Text = "Secretary_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Secretary_form_FormClosing);
            this.Load += new System.EventHandler(this.Secretary_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnReport;
    }
}