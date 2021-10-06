
namespace LnLBackEndSystem
{
    partial class frmCEO
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
            this.btnNavigateBartender = new System.Windows.Forms.Button();
            this.btnNavidateToSecretary = new System.Windows.Forms.Button();
            this.NavigateToAccountant = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNavigateBartender
            // 
            this.btnNavigateBartender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnNavigateBartender.FlatAppearance.BorderSize = 0;
            this.btnNavigateBartender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavigateBartender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavigateBartender.Location = new System.Drawing.Point(12, 183);
            this.btnNavigateBartender.Name = "btnNavigateBartender";
            this.btnNavigateBartender.Size = new System.Drawing.Size(139, 51);
            this.btnNavigateBartender.TabIndex = 39;
            this.btnNavigateBartender.Text = "Navigate To Bartender";
            this.btnNavigateBartender.UseVisualStyleBackColor = false;
            this.btnNavigateBartender.Click += new System.EventHandler(this.btnNavigateBartender_Click);
            // 
            // btnNavidateToSecretary
            // 
            this.btnNavidateToSecretary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnNavidateToSecretary.FlatAppearance.BorderSize = 0;
            this.btnNavidateToSecretary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavidateToSecretary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavidateToSecretary.Location = new System.Drawing.Point(12, 126);
            this.btnNavidateToSecretary.Name = "btnNavidateToSecretary";
            this.btnNavidateToSecretary.Size = new System.Drawing.Size(139, 51);
            this.btnNavidateToSecretary.TabIndex = 40;
            this.btnNavidateToSecretary.Text = "Navigate To Secretary";
            this.btnNavidateToSecretary.UseVisualStyleBackColor = false;
            this.btnNavidateToSecretary.Click += new System.EventHandler(this.btnNavidateToSecretary_Click);
            // 
            // NavigateToAccountant
            // 
            this.NavigateToAccountant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NavigateToAccountant.FlatAppearance.BorderSize = 0;
            this.NavigateToAccountant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigateToAccountant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigateToAccountant.Location = new System.Drawing.Point(12, 69);
            this.NavigateToAccountant.Name = "NavigateToAccountant";
            this.NavigateToAccountant.Size = new System.Drawing.Size(139, 51);
            this.NavigateToAccountant.TabIndex = 41;
            this.NavigateToAccountant.Text = "Navigate To Accountant";
            this.NavigateToAccountant.UseVisualStyleBackColor = false;
            this.NavigateToAccountant.Click += new System.EventHandler(this.NavigateToAccountant_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(12, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(139, 51);
            this.btnAdmin.TabIndex = 42;
            this.btnAdmin.Text = "Navigate To Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(160, 240);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.NavigateToAccountant);
            this.Controls.Add(this.btnNavidateToSecretary);
            this.Controls.Add(this.btnNavigateBartender);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCEO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEO ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNavigateBartender;
        private System.Windows.Forms.Button btnNavidateToSecretary;
        private System.Windows.Forms.Button NavigateToAccountant;
        private System.Windows.Forms.Button btnAdmin;
    }
}