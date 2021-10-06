using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSDataModule;
namespace LnLBackEndSystem
{
    public partial class frmImageManager : Form
    {
        string FilePath;
        string SelectedRow;
        static public Form Creator;
        public frmImageManager()
        {
            InitializeComponent();
        }

        private void frmImageManager_Load(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgvInfo,"SELECT StockID,StockName FROM tblStock");
            dgvInfo.AutoResizeColumns();
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CheckFilePath();
        }
        private void frmImageManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Creator.Show();
        }
        public static void CheckFilePath()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory()+"\\Images"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory()+"\\Images");
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageOFD = new OpenFileDialog();
            ImageOFD.Filter = "png (*.png)|*.png";
            ImageOFD.ShowDialog();
            if (File.Exists(ImageOFD.FileName))
            {
                FilePath = ImageOFD.FileName;
                img.Image = Image.FromFile(ImageOFD.FileName);
                string FilePathOut = $"Images\\{SelectedRow}.png";
                
                if (File.Exists(FilePathOut))
                {
                    if (imgExsistingImage.Image != null)
                        imgExsistingImage.Image.Dispose();
                    imgExsistingImage.Image = Image.FromFile(FilePathOut);
                    if (MessageBox.Show("Overwrite file", "Overwrite?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        imgExsistingImage.Image.Dispose();
                        File.Delete(FilePathOut);
                        imgExsistingImage.Image = null;
                    }
                        
                    else
                    {
                        MessageBox.Show("Canceled");
                        return;
                    }
                }
                else
                    File.Copy(ImageOFD.FileName, FilePathOut);
                dgvInfo_SelectionChanged(dgvInfo, new EventArgs());
                MessageBox.Show("Success");
            }
            img.Image = null;
        }

        private void dgvInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInfo.SelectedRows.Count != 0)
                if (dgvInfo.SelectedRows != null)
                    if (dgvInfo.SelectedRows[0].Cells[0].Value != null)
                    {
                        SelectedRow = dgvInfo.SelectedRows[0].Cells[0].Value.ToString();
                        if (File.Exists($"Images\\{SelectedRow}.png"))
                            imgExsistingImage.Image = Image.FromFile($"Images\\{SelectedRow}.png");
                        else
                        {
                            if (imgExsistingImage.Image != null)
                                imgExsistingImage.Image.Dispose();
                            imgExsistingImage.Image = null;
                        }
                    }
        }

        private void img_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
