
namespace LnLBackEndSystem
{
    partial class frmSupplierRegister
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
            this.EdtName = new System.Windows.Forms.TextBox();
            this.EdtPhoneNumber = new System.Windows.Forms.TextBox();
            this.EdtWebsite = new System.Windows.Forms.TextBox();
            this.EdtWarehouseContactname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlSupplierInfo = new System.Windows.Forms.Panel();
            this.pnlSupplierInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // EdtName
            // 
            this.EdtName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtName.ForeColor = System.Drawing.Color.White;
            this.EdtName.Location = new System.Drawing.Point(188, 22);
            this.EdtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtName.Name = "EdtName";
            this.EdtName.Size = new System.Drawing.Size(222, 35);
            this.EdtName.TabIndex = 0;
            // 
            // EdtPhoneNumber
            // 
            this.EdtPhoneNumber.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.EdtPhoneNumber.Location = new System.Drawing.Point(188, 72);
            this.EdtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtPhoneNumber.Name = "EdtPhoneNumber";
            this.EdtPhoneNumber.Size = new System.Drawing.Size(222, 35);
            this.EdtPhoneNumber.TabIndex = 1;
            // 
            // EdtWebsite
            // 
            this.EdtWebsite.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtWebsite.ForeColor = System.Drawing.Color.White;
            this.EdtWebsite.Location = new System.Drawing.Point(188, 122);
            this.EdtWebsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtWebsite.Name = "EdtWebsite";
            this.EdtWebsite.Size = new System.Drawing.Size(222, 35);
            this.EdtWebsite.TabIndex = 2;
            // 
            // EdtWarehouseContactname
            // 
            this.EdtWarehouseContactname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.EdtWarehouseContactname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdtWarehouseContactname.ForeColor = System.Drawing.Color.White;
            this.EdtWarehouseContactname.Location = new System.Drawing.Point(188, 172);
            this.EdtWarehouseContactname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EdtWarehouseContactname.Name = "EdtWarehouseContactname";
            this.EdtWarehouseContactname.Size = new System.Drawing.Size(222, 35);
            this.EdtWarehouseContactname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Website:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact Name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(280, 254);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 46);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit list";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlSupplierInfo
            // 
            this.pnlSupplierInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlSupplierInfo.Controls.Add(this.EdtName);
            this.pnlSupplierInfo.Controls.Add(this.EdtPhoneNumber);
            this.pnlSupplierInfo.Controls.Add(this.EdtWebsite);
            this.pnlSupplierInfo.Controls.Add(this.EdtWarehouseContactname);
            this.pnlSupplierInfo.Controls.Add(this.label1);
            this.pnlSupplierInfo.Controls.Add(this.label4);
            this.pnlSupplierInfo.Controls.Add(this.label2);
            this.pnlSupplierInfo.Controls.Add(this.label3);
            this.pnlSupplierInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlSupplierInfo.Name = "pnlSupplierInfo";
            this.pnlSupplierInfo.Size = new System.Drawing.Size(428, 234);
            this.pnlSupplierInfo.TabIndex = 13;
            // 
            // frmSupplierRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(451, 307);
            this.Controls.Add(this.pnlSupplierInfo);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplierRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSupplierRegister_FormClosed);
            this.pnlSupplierInfo.ResumeLayout(false);
            this.pnlSupplierInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox EdtName;
        private System.Windows.Forms.TextBox EdtPhoneNumber;
        private System.Windows.Forms.TextBox EdtWebsite;
        private System.Windows.Forms.TextBox EdtWarehouseContactname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlSupplierInfo;
    }
}