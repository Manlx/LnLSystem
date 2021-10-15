
namespace LnLBackEndSystem
{
    partial class frmLocationPage
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
            this.BtnUpdateLocation = new System.Windows.Forms.Button();
            this.BtnAddLocation = new System.Windows.Forms.Button();
            this.BtnRemoveLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUpdateLocation
            // 
            this.BtnUpdateLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnUpdateLocation.FlatAppearance.BorderSize = 0;
            this.BtnUpdateLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnUpdateLocation.Location = new System.Drawing.Point(15, 189);
            this.BtnUpdateLocation.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnUpdateLocation.Name = "BtnUpdateLocation";
            this.BtnUpdateLocation.Size = new System.Drawing.Size(182, 82);
            this.BtnUpdateLocation.TabIndex = 6;
            this.BtnUpdateLocation.Text = "&Update Location";
            this.BtnUpdateLocation.UseVisualStyleBackColor = false;
            this.BtnUpdateLocation.Click += new System.EventHandler(this.BtnUpdateLocation_Click);
            // 
            // BtnAddLocation
            // 
            this.BtnAddLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnAddLocation.FlatAppearance.BorderSize = 0;
            this.BtnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnAddLocation.Location = new System.Drawing.Point(15, 9);
            this.BtnAddLocation.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnAddLocation.Name = "BtnAddLocation";
            this.BtnAddLocation.Size = new System.Drawing.Size(182, 82);
            this.BtnAddLocation.TabIndex = 5;
            this.BtnAddLocation.Text = "&Add Location";
            this.BtnAddLocation.UseVisualStyleBackColor = false;
            this.BtnAddLocation.Click += new System.EventHandler(this.BtnAddLocation_Click);
            // 
            // BtnRemoveLocation
            // 
            this.BtnRemoveLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnRemoveLocation.FlatAppearance.BorderSize = 0;
            this.BtnRemoveLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnRemoveLocation.Location = new System.Drawing.Point(15, 99);
            this.BtnRemoveLocation.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnRemoveLocation.Name = "BtnRemoveLocation";
            this.BtnRemoveLocation.Size = new System.Drawing.Size(182, 82);
            this.BtnRemoveLocation.TabIndex = 4;
            this.BtnRemoveLocation.Text = "&Remove Location";
            this.BtnRemoveLocation.UseVisualStyleBackColor = false;
            this.BtnRemoveLocation.Click += new System.EventHandler(this.BtnRemoveLocation_Click);
            // 
            // frmLocationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(212, 280);
            this.Controls.Add(this.BtnUpdateLocation);
            this.Controls.Add(this.BtnAddLocation);
            this.Controls.Add(this.BtnRemoveLocation);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Homepage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLocationPage_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateLocation;
        private System.Windows.Forms.Button BtnAddLocation;
        private System.Windows.Forms.Button BtnRemoveLocation;
    }
}