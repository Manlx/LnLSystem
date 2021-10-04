
namespace LnLBackEndSystem
{
    partial class frmImageManager
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.PictureBox();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.imgExsistingImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExsistingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvInfo.Margin = new System.Windows.Forms.Padding(6);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.Size = new System.Drawing.Size(958, 274);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.SelectionChanged += new System.EventHandler(this.dgvInfo_SelectionChanged);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(0, 306);
            this.img.Margin = new System.Windows.Forms.Padding(6);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(300, 300);
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(384, 436);
            this.btnLoadFromFile.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(190, 44);
            this.btnLoadFromFile.TabIndex = 2;
            this.btnLoadFromFile.Text = "Load From File";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // imgExsistingImage
            // 
            this.imgExsistingImage.Location = new System.Drawing.Point(658, 306);
            this.imgExsistingImage.Margin = new System.Windows.Forms.Padding(6);
            this.imgExsistingImage.Name = "imgExsistingImage";
            this.imgExsistingImage.Size = new System.Drawing.Size(300, 300);
            this.imgExsistingImage.TabIndex = 3;
            this.imgExsistingImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(99, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preview:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(782, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current:";
            // 
            // frmImageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(959, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgExsistingImage);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.img);
            this.Controls.Add(this.dgvInfo);
            this.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmImageManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImageManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmImageManager_FormClosed);
            this.Load += new System.EventHandler(this.frmImageManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExsistingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.PictureBox imgExsistingImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}