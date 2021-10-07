//Manuel A Nunes 34551875 2021-09-15
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
            
        }
        public static string TableName;
        public static CompsUtilities MyUpdateComps,MyInsertComps;
        private void frmBank_Load(object sender, EventArgs e)
        {
            this.Width = Creator.ClientRectangle.Width - 5;
            string[][] FieldAndCols = DataModule.GetNamesAndColumTypes(TableName);
            DataTypes[] FieldTypes = new DataTypes[FieldAndCols.Length];
            for (int x = 0; x < FieldAndCols.Length;x++)
                FieldTypes[x] = Utilities.StringToDT(FieldAndCols[x][1]);

            string SQL = "SELECT ";
            for (int x = 0; x < FieldTypes.Length; x++)
                switch (FieldTypes[x])
                {
                    case DataTypes.Date:
                        SQL += $" DATE_FORMAT({FieldAndCols[x][0]},'%Y-%m-%d') AS {FieldAndCols[x][0]}, ";
                        break;
                    default:
                        SQL += $" {FieldAndCols[x][0]},";
                        break;
                }
                
            SQL = $"{SQL.Remove(SQL.Length - 1, 1)} FROM {TableName}";
            Clipboard.SetText(SQL);
            DataModule.LoadTable(ref dgvTableData, SQL);
            dgvTableData.AutoResizeColumns();
            dgvTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                        DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
                    }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string temp ="";
            InsertErrorCodes ErrorCatcher;
            if (MyInsertComps.GenerateInsertSQL(out temp, ActiveTable, out ErrorCatcher))
                MessageBox.Show($"{DataModule.ExecuteSQL(temp)} Rows were effected");
            switch(ErrorCatcher)
            {
                case InsertErrorCodes.Empty: MessageBox.Show("All fields can't be empty");
                    break;
                case InsertErrorCodes.MissingPrime: MessageBox.Show("Missing Primary Key");
                    break;
                case InsertErrorCodes.SyntaxIssues: MessageBox.Show("Unknown error as occured");
                    break;
            }
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show( $"{DataModule.ExecuteSQL(MyUpdateComps.GenerateUpdateSQL(ActiveTable))} Rows were effected");
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
        }
    }
}
