
namespace LnLBackEndSystem
{
    partial class frmStockReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvStockReport = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.gbAscDesc = new System.Windows.Forms.GroupBox();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.rbASC = new System.Windows.Forms.RadioButton();
            this.gbOrderBy = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbCountInBar = new System.Windows.Forms.RadioButton();
            this.rbProfitMargin = new System.Windows.Forms.RadioButton();
            this.rbCostPrice = new System.Windows.Forms.RadioButton();
            this.rbDateAquired = new System.Windows.Forms.RadioButton();
            this.rbStockName = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCountINWareHouse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountInBar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProviderSearch = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCountInBar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCountInWarehouse = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWarehouse = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.gbAscDesc.SuspendLayout();
            this.gbOrderBy.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountInBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountInWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Report";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 0);
            this.panel1.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(178, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(138, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "YYYY/MM/DD";
            // 
            // dgvStockReport
            // 
            this.dgvStockReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockReport.EnableHeadersVisualStyles = false;
            this.dgvStockReport.Location = new System.Drawing.Point(0, 50);
            this.dgvStockReport.Name = "dgvStockReport";
            this.dgvStockReport.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.dgvStockReport.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStockReport.Size = new System.Drawing.Size(868, 655);
            this.dgvStockReport.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnClearSearch);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtCountINWareHouse);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCountInBar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(863, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 707);
            this.panel2.TabIndex = 5;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Location = new System.Drawing.Point(168, 241);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(75, 23);
            this.btnClearSearch.TabIndex = 2;
            this.btnClearSearch.Text = "Clear search";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.gbAscDesc);
            this.panel6.Controls.Add(this.gbOrderBy);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(303, 194);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnClear);
            this.panel7.Controls.Add(this.btnOrderBy);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(299, 40);
            this.panel7.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(166, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnOrderBy.FlatAppearance.BorderSize = 0;
            this.btnOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderBy.Location = new System.Drawing.Point(70, 9);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(75, 23);
            this.btnOrderBy.TabIndex = 0;
            this.btnOrderBy.Text = "OK";
            this.btnOrderBy.UseVisualStyleBackColor = false;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // gbAscDesc
            // 
            this.gbAscDesc.Controls.Add(this.rbDesc);
            this.gbAscDesc.Controls.Add(this.rbASC);
            this.gbAscDesc.Location = new System.Drawing.Point(175, 3);
            this.gbAscDesc.Name = "gbAscDesc";
            this.gbAscDesc.Size = new System.Drawing.Size(125, 145);
            this.gbAscDesc.TabIndex = 0;
            this.gbAscDesc.TabStop = false;
            this.gbAscDesc.Text = "Ascending or Decending";
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(19, 63);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(52, 17);
            this.rbDesc.TabIndex = 1;
            this.rbDesc.TabStop = true;
            this.rbDesc.Text = "DESC";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // rbASC
            // 
            this.rbASC.AutoSize = true;
            this.rbASC.Location = new System.Drawing.Point(19, 37);
            this.rbASC.Name = "rbASC";
            this.rbASC.Size = new System.Drawing.Size(45, 17);
            this.rbASC.TabIndex = 0;
            this.rbASC.TabStop = true;
            this.rbASC.Text = "ASC";
            this.rbASC.UseVisualStyleBackColor = true;
            // 
            // gbOrderBy
            // 
            this.gbOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbOrderBy.Controls.Add(this.radioButton1);
            this.gbOrderBy.Controls.Add(this.rbCountInBar);
            this.gbOrderBy.Controls.Add(this.rbProfitMargin);
            this.gbOrderBy.Controls.Add(this.rbCostPrice);
            this.gbOrderBy.Controls.Add(this.rbDateAquired);
            this.gbOrderBy.Controls.Add(this.rbStockName);
            this.gbOrderBy.Location = new System.Drawing.Point(0, 3);
            this.gbOrderBy.Name = "gbOrderBy";
            this.gbOrderBy.Size = new System.Drawing.Size(169, 145);
            this.gbOrderBy.TabIndex = 14;
            this.gbOrderBy.TabStop = false;
            this.gbOrderBy.Text = "Order by";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Count in Warehouse";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbCountInBar
            // 
            this.rbCountInBar.AutoSize = true;
            this.rbCountInBar.Location = new System.Drawing.Point(25, 44);
            this.rbCountInBar.Name = "rbCountInBar";
            this.rbCountInBar.Size = new System.Drawing.Size(89, 17);
            this.rbCountInBar.TabIndex = 17;
            this.rbCountInBar.TabStop = true;
            this.rbCountInBar.Text = "Count in Bar";
            this.rbCountInBar.UseVisualStyleBackColor = true;
            // 
            // rbProfitMargin
            // 
            this.rbProfitMargin.AutoSize = true;
            this.rbProfitMargin.Location = new System.Drawing.Point(25, 90);
            this.rbProfitMargin.Name = "rbProfitMargin";
            this.rbProfitMargin.Size = new System.Drawing.Size(93, 17);
            this.rbProfitMargin.TabIndex = 16;
            this.rbProfitMargin.TabStop = true;
            this.rbProfitMargin.Text = "Profit Margin";
            this.rbProfitMargin.UseVisualStyleBackColor = true;
            // 
            // rbCostPrice
            // 
            this.rbCostPrice.AutoSize = true;
            this.rbCostPrice.Location = new System.Drawing.Point(25, 21);
            this.rbCostPrice.Name = "rbCostPrice";
            this.rbCostPrice.Size = new System.Drawing.Size(75, 17);
            this.rbCostPrice.TabIndex = 15;
            this.rbCostPrice.TabStop = true;
            this.rbCostPrice.Text = "Cost Price";
            this.rbCostPrice.UseVisualStyleBackColor = true;
            // 
            // rbDateAquired
            // 
            this.rbDateAquired.AutoSize = true;
            this.rbDateAquired.Location = new System.Drawing.Point(39, -16);
            this.rbDateAquired.Name = "rbDateAquired";
            this.rbDateAquired.Size = new System.Drawing.Size(98, 17);
            this.rbDateAquired.TabIndex = 14;
            this.rbDateAquired.TabStop = true;
            this.rbDateAquired.Text = "Date Acquired";
            this.rbDateAquired.UseVisualStyleBackColor = true;
            // 
            // rbStockName
            // 
            this.rbStockName.AutoSize = true;
            this.rbStockName.Location = new System.Drawing.Point(25, 113);
            this.rbStockName.Name = "rbStockName";
            this.rbStockName.Size = new System.Drawing.Size(84, 17);
            this.rbStockName.TabIndex = 13;
            this.rbStockName.TabStop = true;
            this.rbStockName.Text = "Stock name";
            this.rbStockName.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(0, 391);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 212);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 603);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 100);
            this.panel4.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(15, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 48);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(216, 42);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCountINWareHouse
            // 
            this.txtCountINWareHouse.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCountINWareHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountINWareHouse.ForeColor = System.Drawing.Color.White;
            this.txtCountINWareHouse.Location = new System.Drawing.Point(191, 319);
            this.txtCountINWareHouse.Name = "txtCountINWareHouse";
            this.txtCountINWareHouse.Size = new System.Drawing.Size(100, 22);
            this.txtCountINWareHouse.TabIndex = 11;
            this.txtCountINWareHouse.TextChanged += new System.EventHandler(this.txtCountINWareHouse_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Count in warehouse below:";
            // 
            // txtCountInBar
            // 
            this.txtCountInBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCountInBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountInBar.ForeColor = System.Drawing.Color.White;
            this.txtCountInBar.Location = new System.Drawing.Point(191, 279);
            this.txtCountInBar.Name = "txtCountInBar";
            this.txtCountInBar.Size = new System.Drawing.Size(100, 22);
            this.txtCountInBar.TabIndex = 9;
            this.txtCountInBar.TextChanged += new System.EventHandler(this.txtCountInBar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Count in bar below:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(72, 241);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(59, 215);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 50);
            this.panel3.TabIndex = 6;
            // 
            // errorProviderSearch
            // 
            this.errorProviderSearch.ContainerControl = this;
            // 
            // errorProviderCountInBar
            // 
            this.errorProviderCountInBar.ContainerControl = this;
            // 
            // errorProviderCountInWarehouse
            // 
            this.errorProviderCountInWarehouse.ContainerControl = this;
            // 
            // errorProviderWarehouse
            // 
            this.errorProviderWarehouse.ContainerControl = this;
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 707);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvStockReport);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStockReport";
            this.Text = "Stock Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStockReport_FormClosed);
            this.Load += new System.EventHandler(this.frmStockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.gbAscDesc.ResumeLayout(false);
            this.gbAscDesc.PerformLayout();
            this.gbOrderBy.ResumeLayout(false);
            this.gbOrderBy.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountInBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountInWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvStockReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCountINWareHouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCountInBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.GroupBox gbAscDesc;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.RadioButton rbASC;
        private System.Windows.Forms.GroupBox gbOrderBy;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbCountInBar;
        private System.Windows.Forms.RadioButton rbProfitMargin;
        private System.Windows.Forms.RadioButton rbCostPrice;
        private System.Windows.Forms.RadioButton rbDateAquired;
        private System.Windows.Forms.RadioButton rbStockName;
        private System.Windows.Forms.ErrorProvider errorProviderSearch;
        private System.Windows.Forms.ErrorProvider errorProviderCountInBar;
        private System.Windows.Forms.ErrorProvider errorProviderCountInWarehouse;
        private System.Windows.Forms.ErrorProvider errorProviderWarehouse;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClearSearch;
    }
}