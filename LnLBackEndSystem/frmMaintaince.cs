//Manuel A Nunes 34551875
using System;
using System.Windows.Forms;
using NSDataModule;
using NSTableAndUtil;
using LnLSupportLibraries;
namespace LnLBackEndSystem
{
    public partial class frmMaintainces : Form
    {
        public Table[] Tables;
        public static Form Creator;
        public frmMaintainces()
        {
            InitializeComponent();
            this.Width = Creator.ClientRectangle.Width-10;
        }
        public static string TableName;
        public static CreateUpdateComs MyUpdateComps;
        private void frmBank_Load(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
            dgvTableData.AutoResizeColumns();
            dgvTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Tables = Utilities.GenerateTables();
            Utilities.UpdateFields(Tables);
            MyUpdateComps = new CreateUpdateComs(Utilities.SearchTable(Tables,TableName), tabUpdate,dgvTableData) ;
        }

        private void dgvTableData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvTableData.SelectedRows.Count != 0)
                if (dgvTableData.SelectedRows[0].Cells[0].Value != null)
                    MyUpdateComps.UpdateValue(Utilities.SearchTable(Tables, TableName));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Sure you would like to delete? ","Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //Need to fix
                DataModule.ExecuteSQL($"DELETE FROM {TableName} WHERE {dgvTableData}= {dgvTableData.SelectedRows[0].Cells[0]}");
        }

        private void tbcMaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTableData.Visible = tbcMaint.SelectedTab != tabInsert;
            //MessageBox.Show(tbcMaint.SelectedTab.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(DataModule.ExecuteSQL(MyUpdateComps.GenerateUpdateSQL(Utilities.SearchTable(Tables, TableName))).ToString());
            Clipboard.SetText((MyUpdateComps.GenerateUpdateSQL(Utilities.SearchTable(Tables, TableName))).ToString());
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
        }
    }
}
