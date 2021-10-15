
namespace LnLBackEndSystem
{
    partial class frmSQLConsole
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
            this.redSqlOut = new System.Windows.Forms.RichTextBox();
            this.edtSqlInput = new System.Windows.Forms.TextBox();
            this.btnGOSQL = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSelectAllShort = new System.Windows.Forms.Button();
            this.btnShowTableInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redSqlOut
            // 
            this.redSqlOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redSqlOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.redSqlOut.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redSqlOut.ForeColor = System.Drawing.Color.Silver;
            this.redSqlOut.Location = new System.Drawing.Point(0, 0);
            this.redSqlOut.Name = "redSqlOut";
            this.redSqlOut.ReadOnly = true;
            this.redSqlOut.Size = new System.Drawing.Size(1262, 264);
            this.redSqlOut.TabIndex = 6;
            this.redSqlOut.TabStop = false;
            this.redSqlOut.Text = "";
            // 
            // edtSqlInput
            // 
            this.edtSqlInput.AcceptsReturn = true;
            this.edtSqlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtSqlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edtSqlInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtSqlInput.ForeColor = System.Drawing.Color.White;
            this.edtSqlInput.Location = new System.Drawing.Point(0, 262);
            this.edtSqlInput.Multiline = true;
            this.edtSqlInput.Name = "edtSqlInput";
            this.edtSqlInput.Size = new System.Drawing.Size(1262, 183);
            this.edtSqlInput.TabIndex = 0;
            // 
            // btnGOSQL
            // 
            this.btnGOSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGOSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnGOSQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGOSQL.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGOSQL.ForeColor = System.Drawing.Color.White;
            this.btnGOSQL.Location = new System.Drawing.Point(0, 445);
            this.btnGOSQL.Name = "btnGOSQL";
            this.btnGOSQL.Size = new System.Drawing.Size(566, 41);
            this.btnGOSQL.TabIndex = 1;
            this.btnGOSQL.Text = "GO";
            this.btnGOSQL.UseVisualStyleBackColor = false;
            this.btnGOSQL.Click += new System.EventHandler(this.btnGOSQL_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1139, 445);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 41);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(1011, 445);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(128, 41);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSelectAllShort
            // 
            this.btnSelectAllShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAllShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSelectAllShort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectAllShort.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAllShort.ForeColor = System.Drawing.Color.White;
            this.btnSelectAllShort.Location = new System.Drawing.Point(781, 445);
            this.btnSelectAllShort.Name = "btnSelectAllShort";
            this.btnSelectAllShort.Size = new System.Drawing.Size(230, 41);
            this.btnSelectAllShort.TabIndex = 3;
            this.btnSelectAllShort.Text = "Select All Short";
            this.btnSelectAllShort.UseVisualStyleBackColor = false;
            this.btnSelectAllShort.Click += new System.EventHandler(this.btnSelectAllShort_Click);
            // 
            // btnShowTableInfo
            // 
            this.btnShowTableInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowTableInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnShowTableInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowTableInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTableInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowTableInfo.Location = new System.Drawing.Point(566, 445);
            this.btnShowTableInfo.Name = "btnShowTableInfo";
            this.btnShowTableInfo.Size = new System.Drawing.Size(215, 41);
            this.btnShowTableInfo.TabIndex = 2;
            this.btnShowTableInfo.Text = "Show Table Info";
            this.btnShowTableInfo.UseVisualStyleBackColor = false;
            this.btnShowTableInfo.Click += new System.EventHandler(this.btnShowTableInfo_Click);
            // 
            // frmSQLConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1262, 486);
            this.Controls.Add(this.btnShowTableInfo);
            this.Controls.Add(this.btnSelectAllShort);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGOSQL);
            this.Controls.Add(this.edtSqlInput);
            this.Controls.Add(this.redSqlOut);
            this.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSQLConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSQLConsole_FormClosed);
            this.Load += new System.EventHandler(this.frmSQLConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox redSqlOut;
        public System.Windows.Forms.TextBox edtSqlInput;
        private System.Windows.Forms.Button btnGOSQL;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSelectAllShort;
        private System.Windows.Forms.Button btnShowTableInfo;
    }
}