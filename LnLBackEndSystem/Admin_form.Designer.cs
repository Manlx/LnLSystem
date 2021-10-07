
namespace LnLBackEndSystem
{
    partial class Admin_form
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
            this.btnModify = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSQLConsole = new System.Windows.Forms.Button();
            this.btnImgManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(55, 13);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(128, 50);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "Modify database";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(55, 71);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(128, 48);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Generate reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(55, 238);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 48);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSQLConsole
            // 
            this.btnSQLConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSQLConsole.FlatAppearance.BorderSize = 0;
            this.btnSQLConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSQLConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQLConsole.Location = new System.Drawing.Point(55, 125);
            this.btnSQLConsole.Name = "btnSQLConsole";
            this.btnSQLConsole.Size = new System.Drawing.Size(128, 48);
            this.btnSQLConsole.TabIndex = 3;
            this.btnSQLConsole.Text = "SQL Console";
            this.btnSQLConsole.UseVisualStyleBackColor = false;
            this.btnSQLConsole.Click += new System.EventHandler(this.btnSQLConsole_Click);
            // 
            // btnImgManager
            // 
            this.btnImgManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnImgManager.FlatAppearance.BorderSize = 0;
            this.btnImgManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgManager.Location = new System.Drawing.Point(55, 179);
            this.btnImgManager.Name = "btnImgManager";
            this.btnImgManager.Size = new System.Drawing.Size(128, 48);
            this.btnImgManager.TabIndex = 4;
            this.btnImgManager.Text = "Image Management";
            this.btnImgManager.UseVisualStyleBackColor = false;
            this.btnImgManager.Click += new System.EventHandler(this.btnImgManager_Click);
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(239, 298);
            this.Controls.Add(this.btnImgManager);
            this.Controls.Add(this.btnSQLConsole);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnModify);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_form_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSQLConsole;
        private System.Windows.Forms.Button btnImgManager;
    }
}