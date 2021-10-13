
namespace LnLBackEndSystem
{
    partial class frmConsoleSettings
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
            this.components = new System.ComponentModel.Container();
            this.btnApply = new System.Windows.Forms.Button();
            this.chkClearOnLoad = new System.Windows.Forms.CheckBox();
            this.ttHints = new System.Windows.Forms.ToolTip(this.components);
            this.chkClearSQLAfterExecution = new System.Windows.Forms.CheckBox();
            this.chkClearAfterSuccessOnly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(237, 65);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(110, 42);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.ttHints.SetToolTip(this.btnApply, "Saves Settings");
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkClearOnLoad
            // 
            this.chkClearOnLoad.AutoSize = true;
            this.chkClearOnLoad.Location = new System.Drawing.Point(12, 7);
            this.chkClearOnLoad.Name = "chkClearOnLoad";
            this.chkClearOnLoad.Size = new System.Drawing.Size(151, 29);
            this.chkClearOnLoad.TabIndex = 0;
            this.chkClearOnLoad.Text = "Clear On Load";
            this.ttHints.SetToolTip(this.chkClearOnLoad, "Clears Form on load");
            this.chkClearOnLoad.UseVisualStyleBackColor = true;
            // 
            // chkClearSQLAfterExecution
            // 
            this.chkClearSQLAfterExecution.AutoSize = true;
            this.chkClearSQLAfterExecution.Location = new System.Drawing.Point(12, 42);
            this.chkClearSQLAfterExecution.Name = "chkClearSQLAfterExecution";
            this.chkClearSQLAfterExecution.Size = new System.Drawing.Size(208, 29);
            this.chkClearSQLAfterExecution.TabIndex = 1;
            this.chkClearSQLAfterExecution.Text = "Clear After Execution";
            this.ttHints.SetToolTip(this.chkClearSQLAfterExecution, "Clear Console after each Execution");
            this.chkClearSQLAfterExecution.UseVisualStyleBackColor = true;
            // 
            // chkClearAfterSuccessOnly
            // 
            this.chkClearAfterSuccessOnly.AutoSize = true;
            this.chkClearAfterSuccessOnly.Location = new System.Drawing.Point(12, 77);
            this.chkClearAfterSuccessOnly.Name = "chkClearAfterSuccessOnly";
            this.chkClearAfterSuccessOnly.Size = new System.Drawing.Size(175, 29);
            this.chkClearAfterSuccessOnly.TabIndex = 2;
            this.chkClearAfterSuccessOnly.Text = "Clear On Success";
            this.ttHints.SetToolTip(this.chkClearAfterSuccessOnly, "Clears Input Console if SQL Was successfull");
            this.chkClearAfterSuccessOnly.UseVisualStyleBackColor = true;
            // 
            // frmConsoleSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(354, 113);
            this.Controls.Add(this.chkClearAfterSuccessOnly);
            this.Controls.Add(this.chkClearSQLAfterExecution);
            this.Controls.Add(this.chkClearOnLoad);
            this.Controls.Add(this.btnApply);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsoleSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsoleSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.CheckBox chkClearOnLoad;
        public System.Windows.Forms.ToolTip ttHints;
        public System.Windows.Forms.CheckBox chkClearSQLAfterExecution;
        public System.Windows.Forms.CheckBox chkClearAfterSuccessOnly;
    }
}