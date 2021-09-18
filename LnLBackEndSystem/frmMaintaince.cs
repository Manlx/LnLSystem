//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;
using NSDataModule;
using NSTableAndUtil;
namespace LnLBackEndSystem
{
    public partial class frmMaintainces : Form
    {
        public Table[] Tables;
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
            dgvTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Tables = Utilities.GenerateTables();
            Utilities.UpdateFields(Tables);
        }

        private void dgvTableData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvTableData.SelectedRows.Count != 0)
            //{
            //    string SelectedRow = "";
            //    int limit = ((dgvTableData.ColumnCount > 4) ? 5 : dgvTableData.ColumnCount);
            //    for (int x = 0; x < limit; x++)
            //        SelectedRow += $"{dgvTableData.Columns[x].Name}: {dgvTableData.SelectedRows[0].Cells[x].Value.ToString()}\n" ;
            //    lblSelectedRow.Text = SelectedRow;
            //}
                
                //MessageBox.Show(dgvTableData.SelectedRows[0].Cells[0].Value.ToString());
            //MessageBox.Show(dgvTableData.SelectedCells[0].Value.ToString());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure you would like to delete? ","Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //Need to fix
                DataModule.ExecuteSQL($"DELETE FROM {TableName} WHERE {dgvTableData}= {dgvTableData.SelectedRows[0].Cells[0]}");
        }
    }
}
