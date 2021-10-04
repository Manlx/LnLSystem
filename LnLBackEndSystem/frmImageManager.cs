using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSDataModule;
namespace LnLBackEndSystem
{
    public partial class frmImageManager : Form
    {
        static public Form Creator;
        public frmImageManager()
        {
            InitializeComponent();
        }

        private void frmImageManager_Load(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgvInfo,"SELECT StockID,StockName FROM tblStock");
        }
    }
}
