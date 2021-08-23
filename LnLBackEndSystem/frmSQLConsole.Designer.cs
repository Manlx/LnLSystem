
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
            this.SuspendLayout();
            // 
            // redSqlOut
            // 
            this.redSqlOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redSqlOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.redSqlOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.redSqlOut.Location = new System.Drawing.Point(0, 0);
            this.redSqlOut.Name = "redSqlOut";
            this.redSqlOut.Size = new System.Drawing.Size(910, 306);
            this.redSqlOut.TabIndex = 0;
            this.redSqlOut.Text = "";
            // 
            // edtSqlInput
            // 
            this.edtSqlInput.AcceptsReturn = true;
            this.edtSqlInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtSqlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.edtSqlInput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.edtSqlInput.Location = new System.Drawing.Point(0, 305);
            this.edtSqlInput.Multiline = true;
            this.edtSqlInput.Name = "edtSqlInput";
            this.edtSqlInput.Size = new System.Drawing.Size(910, 148);
            this.edtSqlInput.TabIndex = 1;
            // 
            // btnGOSQL
            // 
            this.btnGOSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGOSQL.Location = new System.Drawing.Point(0, 453);
            this.btnGOSQL.Name = "btnGOSQL";
            this.btnGOSQL.Size = new System.Drawing.Size(910, 49);
            this.btnGOSQL.TabIndex = 2;
            this.btnGOSQL.Text = "GO";
            this.btnGOSQL.UseVisualStyleBackColor = true;
            this.btnGOSQL.Click += new System.EventHandler(this.btnGOSQL_Click);
            // 
            // frmSQLConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(910, 502);
            this.Controls.Add(this.btnGOSQL);
            this.Controls.Add(this.edtSqlInput);
            this.Controls.Add(this.redSqlOut);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSQLConsole";
            this.Text = "SQL Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSQLConsole_FormClosed);
            this.Load += new System.EventHandler(this.frmSQLConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox redSqlOut;
        private System.Windows.Forms.TextBox edtSqlInput;
        private System.Windows.Forms.Button btnGOSQL;
    }
}