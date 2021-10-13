
namespace LnLBackEndSystem
{
    partial class frmSupplierUpdate
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
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtPhoneNumber = new System.Windows.Forms.TextBox();
            this.edtWebsite = new System.Windows.Forms.TextBox();
            this.edtContactName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstSuppliers.ForeColor = System.Drawing.Color.White;
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 25;
            this.lstSuppliers.Location = new System.Drawing.Point(0, 0);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(524, 104);
            this.lstSuppliers.TabIndex = 0;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(157, 115);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(354, 33);
            this.edtName.TabIndex = 1;
            // 
            // edtPhoneNumber
            // 
            this.edtPhoneNumber.Location = new System.Drawing.Point(157, 213);
            this.edtPhoneNumber.Name = "edtPhoneNumber";
            this.edtPhoneNumber.Size = new System.Drawing.Size(354, 33);
            this.edtPhoneNumber.TabIndex = 3;
            // 
            // edtWebsite
            // 
            this.edtWebsite.Location = new System.Drawing.Point(157, 164);
            this.edtWebsite.Name = "edtWebsite";
            this.edtWebsite.Size = new System.Drawing.Size(354, 33);
            this.edtWebsite.TabIndex = 2;
            // 
            // edtContactName
            // 
            this.edtContactName.Location = new System.Drawing.Point(157, 262);
            this.edtContactName.Name = "edtContactName";
            this.edtContactName.Size = new System.Drawing.Size(354, 33);
            this.edtContactName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Website:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact Name:";
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnUpdateSupplier.FlatAppearance.BorderSize = 0;
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSupplier.Location = new System.Drawing.Point(10, 304);
            this.btnUpdateSupplier.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(501, 47);
            this.btnUpdateSupplier.TabIndex = 5;
            this.btnUpdateSupplier.Text = "Update Supplier";
            this.btnUpdateSupplier.UseVisualStyleBackColor = false;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // frmSupplierUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(523, 363);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtContactName);
            this.Controls.Add(this.edtWebsite);
            this.Controls.Add(this.edtPhoneNumber);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.lstSuppliers);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplierUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSupplierUpdate_FormClosed);
            this.Load += new System.EventHandler(this.frmSupplierUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtPhoneNumber;
        private System.Windows.Forms.TextBox edtWebsite;
        private System.Windows.Forms.TextBox edtContactName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateSupplier;
    }
}