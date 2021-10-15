
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTableData = new System.Windows.Forms.DataGridView();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbbOrderFields = new System.Windows.Forms.ComboBox();
            this.radAsc = new System.Windows.Forms.RadioButton();
            this.radDesc = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edtSearchValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSearchField = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableData)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabInsert.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTableData
            // 
            this.dgvTableData.AllowUserToDeleteRows = false;
            this.dgvTableData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableData.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvTableData.EnableHeadersVisualStyles = false;
            this.dgvTableData.GridColor = System.Drawing.Color.DarkGray;
            this.dgvTableData.Location = new System.Drawing.Point(0, 0);
            this.dgvTableData.MultiSelect = false;
            this.dgvTableData.Name = "dgvTableData";
            this.dgvTableData.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableData.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvTableData.RowHeadersVisible = false;
            this.dgvTableData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableData.Size = new System.Drawing.Size(1160, 302);
            this.dgvTableData.TabIndex = 0;
            this.dgvTableData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableData_RowEnter);
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcMain.Controls.Add(this.tabUpdate);
            this.tbcMain.Controls.Add(this.tabInsert);
            this.tbcMain.Controls.Add(this.tabDelete);
            this.tbcMain.Location = new System.Drawing.Point(0, 374);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1160, 275);
            this.tbcMain.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbcMain, "Deletes Selected Record");
            // 
            // tabUpdate
            // 
            this.tabUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabUpdate.Controls.Add(this.btnUpdate);
            this.tabUpdate.ForeColor = System.Drawing.Color.White;
            this.tabUpdate.Location = new System.Drawing.Point(4, 36);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(1152, 235);
            this.tabUpdate.TabIndex = 0;
            this.tabUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(479, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 43);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Record";
            this.toolTip1.SetToolTip(this.btnUpdate, "Updates Selected Record");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabInsert
            // 
            this.tabInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabInsert.Controls.Add(this.btnInsert);
            this.tabInsert.ForeColor = System.Drawing.Color.White;
            this.tabInsert.Location = new System.Drawing.Point(4, 36);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(1152, 235);
            this.tabInsert.TabIndex = 1;
            this.tabInsert.Text = "Insert";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(505, 187);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 43);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert Row";
            this.toolTip1.SetToolTip(this.btnInsert, "Inserts Entered Data");
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.ForeColor = System.Drawing.Color.White;
            this.tabDelete.Location = new System.Drawing.Point(4, 36);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(1152, 235);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(471, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected Row";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbbOrderFields
            // 
            this.cbbOrderFields.FormattingEnabled = true;
            this.cbbOrderFields.Location = new System.Drawing.Point(3, 31);
            this.cbbOrderFields.Name = "cbbOrderFields";
            this.cbbOrderFields.Size = new System.Drawing.Size(216, 32);
            this.cbbOrderFields.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbbOrderFields, "Order acording to the following field");
            // 
            // radAsc
            // 
            this.radAsc.AutoSize = true;
            this.radAsc.Location = new System.Drawing.Point(252, 4);
            this.radAsc.Name = "radAsc";
            this.radAsc.Size = new System.Drawing.Size(157, 28);
            this.radAsc.TabIndex = 2;
            this.radAsc.TabStop = true;
            this.radAsc.Text = "Sort Ascending";
            this.radAsc.UseVisualStyleBackColor = true;
            // 
            // radDesc
            // 
            this.radDesc.AutoSize = true;
            this.radDesc.Location = new System.Drawing.Point(252, 36);
            this.radDesc.Name = "radDesc";
            this.radDesc.Size = new System.Drawing.Size(168, 28);
            this.radDesc.TabIndex = 1;
            this.radDesc.TabStop = true;
            this.radDesc.Text = "Sort Descending";
            this.radDesc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.btnResetOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radAsc);
            this.panel1.Controls.Add(this.cbbOrderFields);
            this.panel1.Controls.Add(this.radDesc);
            this.panel1.Location = new System.Drawing.Point(4, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 66);
            this.panel1.TabIndex = 1;
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.AutoSize = true;
            this.btnResetOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnResetOrder.FlatAppearance.BorderSize = 0;
            this.btnResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetOrder.Location = new System.Drawing.Point(55, 3);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(54, 26);
            this.btnResetOrder.TabIndex = 3;
            this.btnResetOrder.Text = "Reset";
            this.btnResetOrder.UseVisualStyleBackColor = false;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Field:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.btnResetSearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.edtSearchValue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbbSearchField);
            this.panel2.Location = new System.Drawing.Point(702, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 66);
            this.panel2.TabIndex = 3;
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.AutoSize = true;
            this.btnResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnResetSearch.FlatAppearance.BorderSize = 0;
            this.btnResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSearch.Location = new System.Drawing.Point(56, 3);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(54, 26);
            this.btnResetSearch.TabIndex = 2;
            this.btnResetSearch.Text = "Reset";
            this.btnResetSearch.UseVisualStyleBackColor = false;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Value:";
            // 
            // edtSearchValue
            // 
            this.edtSearchValue.Location = new System.Drawing.Point(225, 31);
            this.edtSearchValue.Name = "edtSearchValue";
            this.edtSearchValue.Size = new System.Drawing.Size(228, 29);
            this.edtSearchValue.TabIndex = 1;
            this.edtSearchValue.Text = "Search For";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Field:";
            // 
            // cbbSearchField
            // 
            this.cbbSearchField.FormattingEnabled = true;
            this.cbbSearchField.Location = new System.Drawing.Point(3, 31);
            this.cbbSearchField.Name = "cbbSearchField";
            this.cbbSearchField.Size = new System.Drawing.Size(216, 32);
            this.cbbSearchField.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbbSearchField, "Search in the following Field");
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(460, 304);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(243, 66);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.toolTip1.SetToolTip(this.btnApply, "Applies Search and Sorts");
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmMaintainces
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1160, 650);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.dgvTableData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox cbbOrderFields;
        private System.Windows.Forms.RadioButton radAsc;
        private System.Windows.Forms.RadioButton radDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbSearchField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtSearchValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}