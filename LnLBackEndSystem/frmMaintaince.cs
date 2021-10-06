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
            this.Width = Creator.ClientRectangle.Width - 10;
            this.Height = ((frmDataManagement)Creator).cbbTable.Top - 10;
            this.Top = 5;
            this.Left = 5;

            dgvTableData.Width = ClientRectangle.Width - 10;
            tbcMain.Width = ClientRectangle.Width - 10;
            dgvTableData.Left = 5;
            tbcMain.Left = 5;

            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
            dgvTableData.AutoResizeColumns();
            dgvTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Tables = Utilities.GenerateTables();
            Utilities.UpdateFields(Tables);
            MyUpdateComps = new CompsUtilities();
            MyInsertComps = new CompsUtilities();

            ActiveTable = Utilities.SearchTable(Tables, TableName);

            MyUpdateComps.CreateComs(ActiveTable, tabUpdate,dgvTableData) ;
            MyInsertComps.CreateComs(ActiveTable, tabInsert ,dgvTableData);

            btnDelete.Left = (btnDelete.Parent.Width - btnDelete.Width) / 2;
            btnInsert.Left = (btnInsert.Parent.Width - btnInsert.Width) / 2;
            btnUpdate.Left = (btnUpdate.Parent.Width - btnUpdate.Width) / 2;
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
