
namespace LnLBackEndSystem
{
    partial class frmTableSelect
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
            this.cmbSelectTables = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbSelectTables
            // 
            this.cmbSelectTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbSelectTables.ForeColor = System.Drawing.Color.White;
            this.cmbSelectTables.FormattingEnabled = true;
            this.cmbSelectTables.Location = new System.Drawing.Point(-1, 1);
            this.cmbSelectTables.Name = "cmbSelectTables";
            this.cmbSelectTables.Size = new System.Drawing.Size(219, 29);
            this.cmbSelectTables.TabIndex = 0;
            this.cmbSelectTables.SelectedIndexChanged += new System.EventHandler(this.cmbSelectTables_SelectedIndexChanged);
            // 
            // frmTableSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(217, 28);
            this.Controls.Add(this.cmbSelectTables);
            this.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTableSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Table";
            this.Load += new System.EventHandler(this.frmTableSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectTables;
    }
}