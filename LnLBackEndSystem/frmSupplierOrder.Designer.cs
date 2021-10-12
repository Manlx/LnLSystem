
namespace LnLBackEndSystem
{
    partial class frmSupplierOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.edtAmount = new System.Windows.Forms.TextBox();
            this.lblAmountOf = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lstPayment = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.lstSuppliers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 432);
            this.panel1.TabIndex = 0;
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstSuppliers.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuppliers.ForeColor = System.Drawing.Color.White;
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 18;
            this.lstSuppliers.Location = new System.Drawing.Point(6, 80);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(432, 328);
            this.lstSuppliers.TabIndex = 1;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(909, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 432);
            this.panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(9, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(239, 139);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(9, 80);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(239, 139);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Product";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.panel3.Controls.Add(this.lstProducts);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(484, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 432);
            this.panel3.TabIndex = 1;
            // 
            // lstProducts
            // 
            this.lstProducts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstProducts.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducts.ForeColor = System.Drawing.Color.White;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 18;
            this.lstProducts.Location = new System.Drawing.Point(7, 80);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(405, 328);
            this.lstProducts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDecrease.FlatAppearance.BorderSize = 0;
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Location = new System.Drawing.Point(862, 44);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(255, 57);
            this.btnDecrease.TabIndex = 5;
            this.btnDecrease.Text = "Decrease Product";
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Location = new System.Drawing.Point(862, 105);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(255, 57);
            this.btnIncrease.TabIndex = 6;
            this.btnIncrease.Text = "Increase Product";
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // edtAmount
            // 
            this.edtAmount.Location = new System.Drawing.Point(990, 5);
            this.edtAmount.Name = "edtAmount";
            this.edtAmount.Size = new System.Drawing.Size(127, 33);
            this.edtAmount.TabIndex = 7;
            // 
            // lblAmountOf
            // 
            this.lblAmountOf.AutoSize = true;
            this.lblAmountOf.Location = new System.Drawing.Point(873, 9);
            this.lblAmountOf.Name = "lblAmountOf";
            this.lblAmountOf.Size = new System.Drawing.Size(111, 25);
            this.lblAmountOf.TabIndex = 8;
            this.lblAmountOf.Text = "Amount To:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.panel4.Controls.Add(this.lstPayment);
            this.panel4.Controls.Add(this.btnGenerateFile);
            this.panel4.Controls.Add(this.lstOrder);
            this.panel4.Controls.Add(this.lblAmountOf);
            this.panel4.Controls.Add(this.btnDecrease);
            this.panel4.Controls.Add(this.edtAmount);
            this.panel4.Controls.Add(this.btnIncrease);
            this.panel4.Location = new System.Drawing.Point(40, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1125, 236);
            this.panel4.TabIndex = 2;
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGenerateFile.FlatAppearance.BorderSize = 0;
            this.btnGenerateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateFile.Location = new System.Drawing.Point(862, 166);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(255, 57);
            this.btnGenerateFile.TabIndex = 9;
            this.btnGenerateFile.Text = "Generate File/Place Order";
            this.btnGenerateFile.UseVisualStyleBackColor = false;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstOrder.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.ForeColor = System.Drawing.Color.White;
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 18;
            this.lstOrder.Location = new System.Drawing.Point(6, 5);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(634, 220);
            this.lstOrder.TabIndex = 3;
            // 
            // lstPayment
            // 
            this.lstPayment.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstPayment.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPayment.ForeColor = System.Drawing.Color.White;
            this.lstPayment.FormattingEnabled = true;
            this.lstPayment.ItemHeight = 18;
            this.lstPayment.Location = new System.Drawing.Point(646, 5);
            this.lstPayment.Name = "lstPayment";
            this.lstPayment.Size = new System.Drawing.Size(210, 220);
            this.lstPayment.TabIndex = 10;
            // 
            // frmSupplierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1204, 725);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplierOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Order at Supplier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSupplierOrder_FormClosed);
            this.Load += new System.EventHandler(this.frmSupplierOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox edtAmount;
        private System.Windows.Forms.Label lblAmountOf;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.ListBox lstPayment;
    }
}