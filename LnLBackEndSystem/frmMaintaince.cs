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
        public Table ActiveTable;
        public static Form Creator;
        public frmMaintainces()
        {
            InitializeComponent();
            this.Width = Creator.ClientRectangle.Width-10;
        }
        public static string TableName;
        public static CompsUtilities MyUpdateComps,MyInsertComps;
        private void frmBank_Load(object sender, EventArgs e)
        {
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
            dgvTableData.AutoResizeColumns();
            dgvTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbcMaint.Width = Parent.Width - 10;
            tbcMaint.Left = 5;

            Tables = Utilities.GenerateTables();
            Utilities.UpdateFields(Tables);
            MyUpdateComps = new CompsUtilities();
            MyInsertComps = new CompsUtilities();

            ActiveTable = Utilities.SearchTable(Tables, TableName);

            MyUpdateComps.CreateComs(ActiveTable, tabUpdate,dgvTableData) ;
            MyInsertComps.CreateComs(ActiveTable, tabInsert ,dgvTableData);
        }

        private void dgvTableData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvTableData.SelectedRows.Count != 0)
                if (dgvTableData.SelectedRows[0].Cells[0].Value != null)
                    MyUpdateComps.UpdateValue(ActiveTable);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTableData.SelectedRows.Count != 0)
                if (dgvTableData.SelectedRows[0].Cells[0].Value != null)
                    if (MessageBox.Show("Sure you would like to delete? ", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (DataModule.ExecuteSQL($"DELETE FROM {TableName} {CompsUtilities.BuildWHERE(ActiveTable, dgvTableData)}") == -1)
                            MessageBox.Show("Deletion was restricted or has encountered an error");
                        //Clipboard.SetText($"DELETE FROM {TableName} {CompsUtilities.BuildWHERE(Utilities.SearchTable(Tables, TableName), dgvTableData)}");
                        DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");

                    }
        }

        private void tbcMaint_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string temp ="";
            if (MyInsertComps.GenerateInsertSQL(ref temp, ActiveTable))
                MessageBox.Show($"{DataModule.ExecuteSQL(temp)} Rows were effected");
            //Clipboard.SetText(temp);
            //MessageBox.Show(temp);
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show( $"{DataModule.ExecuteSQL(MyUpdateComps.GenerateUpdateSQL(ActiveTable))} Rows were effected");
            //Clipboard.SetText((MyUpdateComps.GenerateUpdateSQL(Utilities.SearchTable(Tables, TableName))).ToString());
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
        }
    }
}
