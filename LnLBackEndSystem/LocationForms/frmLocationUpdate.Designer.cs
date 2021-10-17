
namespace LnLBackEndSystem
{
    partial class frmLocationUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHasStage = new System.Windows.Forms.CheckBox();
            this.EdtDescription = new System.Windows.Forms.TextBox();
            this.chkHasMusicAccess = new System.Windows.Forms.CheckBox();
            this.chkSwimmingPool = new System.Windows.Forms.CheckBox();
            this.chkHasLakeAccess = new System.Windows.Forms.CheckBox();
            this.chkHasKitchenAcces = new System.Windows.Forms.CheckBox();
            this.chkHasBarAccess = new System.Windows.Forms.CheckBox();
            this.chkIsOutdoors = new System.Windows.Forms.CheckBox();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(40, 508);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(239, 37);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update Location";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkHasStage);
            this.panel1.Controls.Add(this.EdtDescription);
            this.panel1.Controls.Add(this.chkHasMusicAccess);
            this.panel1.Controls.Add(this.chkSwimmingPool);
            this.panel1.Controls.Add(this.chkHasLakeAccess);
            this.panel1.Controls.Add(this.chkHasKitchenAcces);
            this.panel1.Controls.Add(this.chkHasBarAccess);
            this.panel1.Controls.Add(this.chkIsOutdoors);
            this.panel1.Location = new System.Drawing.Point(16, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 370);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description:";
            // 
            // chkHasStage
            // 
            this.chkHasStage.AutoSize = true;
            this.chkHasStage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasStage.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasStage.Location = new System.Drawing.Point(24, 319);
            this.chkHasStage.Name = "chkHasStage";
            this.chkHasStage.Size = new System.Drawing.Size(189, 26);
            this.chkHasStage.TabIndex = 7;
            this.chkHasStage.Text = "Has Stage Access";
            this.chkHasStage.UseVisualStyleBackColor = true;
            // 
            // EdtDescription
            // 
            this.EdtDescription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtDescription.ForeColor = System.Drawing.Color.White;
            this.EdtDescription.Location = new System.Drawing.Point(24, 56);
            this.EdtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtDescription.Name = "EdtDescription";
            this.EdtDescription.Size = new System.Drawing.Size(239, 33);
            this.EdtDescription.TabIndex = 0;
            // 
            // chkHasMusicAccess
            // 
            this.chkHasMusicAccess.AutoSize = true;
            this.chkHasMusicAccess.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasMusicAccess.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasMusicAccess.Location = new System.Drawing.Point(24, 282);
            this.chkHasMusicAccess.Name = "chkHasMusicAccess";
            this.chkHasMusicAccess.Size = new System.Drawing.Size(219, 26);
            this.chkHasMusicAccess.TabIndex = 6;
            this.chkHasMusicAccess.Text = "Has Access To Music";
            this.chkHasMusicAccess.UseVisualStyleBackColor = true;
            // 
            // chkSwimmingPool
            // 
            this.chkSwimmingPool.AutoSize = true;
            this.chkSwimmingPool.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSwimmingPool.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSwimmingPool.Location = new System.Drawing.Point(24, 245);
            this.chkSwimmingPool.Name = "chkSwimmingPool";
            this.chkSwimmingPool.Size = new System.Drawing.Size(199, 26);
            this.chkSwimmingPool.TabIndex = 5;
            this.chkSwimmingPool.Text = "Has Swimming Pool";
            this.chkSwimmingPool.UseVisualStyleBackColor = true;
            // 
            // chkHasLakeAccess
            // 
            this.chkHasLakeAccess.AutoSize = true;
            this.chkHasLakeAccess.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasLakeAccess.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasLakeAccess.Location = new System.Drawing.Point(24, 208);
            this.chkHasLakeAccess.Name = "chkHasLakeAccess";
            this.chkHasLakeAccess.Size = new System.Drawing.Size(219, 26);
            this.chkHasLakeAccess.TabIndex = 4;
            this.chkHasLakeAccess.Text = "Has Access To Lake ";
            this.chkHasLakeAccess.UseVisualStyleBackColor = true;
            // 
            // chkHasKitchenAcces
            // 
            this.chkHasKitchenAcces.AutoSize = true;
            this.chkHasKitchenAcces.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasKitchenAcces.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasKitchenAcces.Location = new System.Drawing.Point(24, 171);
            this.chkHasKitchenAcces.Name = "chkHasKitchenAcces";
            this.chkHasKitchenAcces.Size = new System.Drawing.Size(239, 26);
            this.chkHasKitchenAcces.TabIndex = 3;
            this.chkHasKitchenAcces.Text = "Has Access To Kitchen";
            this.chkHasKitchenAcces.UseVisualStyleBackColor = true;
            // 
            // chkHasBarAccess
            // 
            this.chkHasBarAccess.AutoSize = true;
            this.chkHasBarAccess.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasBarAccess.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasBarAccess.Location = new System.Drawing.Point(24, 134);
            this.chkHasBarAccess.Name = "chkHasBarAccess";
            this.chkHasBarAccess.Size = new System.Drawing.Size(199, 26);
            this.chkHasBarAccess.TabIndex = 2;
            this.chkHasBarAccess.Text = "Has Access To Bar";
            this.chkHasBarAccess.UseVisualStyleBackColor = true;
            // 
            // chkIsOutdoors
            // 
            this.chkIsOutdoors.AutoSize = true;
            this.chkIsOutdoors.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsOutdoors.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsOutdoors.Location = new System.Drawing.Point(24, 97);
            this.chkIsOutdoors.Name = "chkIsOutdoors";
            this.chkIsOutdoors.Size = new System.Drawing.Size(139, 26);
            this.chkIsOutdoors.TabIndex = 1;
            this.chkIsOutdoors.Text = "Is Outdoors";
            this.chkIsOutdoors.UseVisualStyleBackColor = true;
            // 
            // lstLocations
            // 
            this.lstLocations.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstLocations.ForeColor = System.Drawing.Color.White;
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.ItemHeight = 25;
            this.lstLocations.Location = new System.Drawing.Point(16, 12);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(286, 104);
            this.lstLocations.TabIndex = 4;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // frmLocationUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(319, 567);
            this.Controls.Add(this.lstLocations);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocationUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLocationUpdate_FormClosed);
            this.Load += new System.EventHandler(this.frmLocationUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkHasStage;
        private System.Windows.Forms.TextBox EdtDescription;
        private System.Windows.Forms.CheckBox chkHasMusicAccess;
        private System.Windows.Forms.CheckBox chkSwimmingPool;
        private System.Windows.Forms.CheckBox chkHasLakeAccess;
        private System.Windows.Forms.CheckBox chkHasKitchenAcces;
        private System.Windows.Forms.CheckBox chkHasBarAccess;
        private System.Windows.Forms.CheckBox chkIsOutdoors;
        private System.Windows.Forms.ListBox lstLocations;
    }
}