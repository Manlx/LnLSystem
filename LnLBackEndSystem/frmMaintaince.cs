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
            string tempSQL = $"SELECT * FROM {TableName}";
            DataModule.LoadTable(ref dgvTableData, tempSQL);
            dgvTableData.AutoResizeColumns();
            dgvTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DBEditCompsClass Comps = new DBEditCompsClass(tbcMaint, $"SHOW COLUMNS FROM {TableName}");
        }

        private void dgvTableData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTableData.SelectedRows.Count != 0)
                MessageBox.Show(dgvTableData.SelectedRows[0].Cells[0].Value.ToString());
            //MessageBox.Show(dgvTableData.SelectedCells[0].Value.ToString());
        }
        private void GenerateComps()
        {
            
            foreach (var item in DataModule.GetValues<string>(1, $"SHOW COLUMNS FROM {TableName}"))
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateComps();
        }
    }
}
