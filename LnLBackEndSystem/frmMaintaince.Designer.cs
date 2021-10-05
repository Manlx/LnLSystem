
namespace LnLBackEndSystem
{
    partial class frmMaintainces
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
            this.dgvTableData = new System.Windows.Forms.DataGridView();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableData)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabInsert.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTableData
            // 
            this.dgvTableData.AllowUserToDeleteRows = false;
            this.dgvTableData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dgvTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.dgvTableData.Location = new System.Drawing.Point(0, 0);
            this.dgvTableData.Name = "dgvTableData";
            this.dgvTableData.ReadOnly = true;
            this.dgvTableData.Size = new System.Drawing.Size(995, 316);
            this.dgvTableData.TabIndex = 0;
            this.dgvTableData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableData_RowEnter);
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbcMain.Controls.Add(this.tabUpdate);
            this.tbcMain.Controls.Add(this.tabInsert);
            this.tbcMain.Controls.Add(this.tabDelete);
            this.tbcMain.Location = new System.Drawing.Point(0, 316);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(995, 255);
            this.tbcMain.TabIndex = 1;
            // 
            // tabUpdate
            // 
            this.tabUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.tabUpdate.Location = new System.Drawing.Point(4, 35);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(987, 216);
            this.tabUpdate.TabIndex = 0;
            this.tabUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(392, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabInsert
            // 
            this.tabInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tabInsert.Controls.Add(this.btnInsert);
            this.tabInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.tabInsert.Location = new System.Drawing.Point(4, 35);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(987, 216);
            this.tabInsert.TabIndex = 1;
            this.tabInsert.Text = "Insert";
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Location = new System.Drawing.Point(422, 168);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 43);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert Row";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.tabDelete.Location = new System.Drawing.Point(4, 35);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(987, 216);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(325, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(337, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMaintainces
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.dgvTableData);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaintainces";
            this.Text = "Bank Table Management";
            this.Load += new System.EventHandler(this.frmBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableData)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.tabUpdate.ResumeLayout(false);
            this.tabInsert.ResumeLayout(false);
            this.tabDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableData;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}