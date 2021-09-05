using System;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public partial class frmMaintainces : Form
    {
        public static Form Creator;
        public frmMaintainces()
        {
            InitializeComponent();
            this.Width = Creator.ClientRectangle.Width;
        }
        public static string TableName;
        private void frmBank_Load(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
            dgvTableData.AutoResizeColumns();
        }
    }
}
