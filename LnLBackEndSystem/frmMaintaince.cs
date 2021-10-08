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
        private string WHERE, SORT;
        public Table[] Tables;
        public Table ActiveTable;
        public static Form Creator;
        public frmMaintainces()
        {
            InitializeComponent();
            Top = 0;
            Left = 0;
        }
        public static string TableName;
        public static CompsUtilities MyUpdateComps,MyInsertComps;

        private string[][] FieldAndCols;
        private DataTypes[] FieldTypes;

        public void FillTable()
        {// This code is this way to prevent the date time error
            FieldAndCols = DataModule.GetNamesAndColumTypes(TableName);
            FieldTypes = new DataTypes[FieldAndCols.Length];
            for (int x = 0; x < FieldAndCols.Length; x++)
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

            SQL = $"{SQL.Remove(SQL.Length - 1, 1)} FROM {TableName} {WHERE} {SORT}";
            DataModule.LoadTable(ref dgvTableData, SQL);
            dgvTableData.AutoResizeColumns();
            dgvTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void frmBank_Load(object sender, EventArgs e)
        {
            WHERE = "";
            SORT = "";
            this.Width = Creator.ClientRectangle.Width - 5;

            FillTable();

            Tables = Utilities.GenerateTables();
            Utilities.UpdateFields(Tables);
            MyUpdateComps = new CompsUtilities();
            MyInsertComps = new CompsUtilities();

            ActiveTable = Utilities.SearchTable(Tables, TableName);

            MyUpdateComps.CreateComs(ActiveTable, tabUpdate,dgvTableData) ;
            MyInsertComps.CreateComs(ActiveTable, tabInsert ,dgvTableData);

            cbbOrderFields.Items.Clear();
            cbbSearchField.Items.Clear();

            foreach(string[] Row in FieldAndCols)
            {
                cbbOrderFields.Items.Add(Row[0]);
                cbbSearchField.Items.Add(Row[0]);
            }
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
            if (MyInsertComps.GenerateInsertSQL(out string temp, ActiveTable, out InsertErrorCodes ErrorCatcher))
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

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            cbbOrderFields.SelectedIndex = -1;
            radAsc.Checked = false;
            radDesc.Checked = false;
            SORT = "";
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            cbbSearchField.SelectedIndex = -1;
            edtSearchValue.Text = "";
            WHERE = "";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SORT = "";
            WHERE = "";
            string OrderField= "ORDER BY ",Order = "";
            if (cbbOrderFields.SelectedIndex >= 0)
                OrderField += FieldAndCols[cbbOrderFields.SelectedIndex][0];
            if (radAsc.Checked)
                Order = "ASC";
            else if (radDesc.Checked)
                Order = "DESC";
            if (Order.Length > 0 && cbbOrderFields.SelectedIndex >= 0)
                SORT = $"{OrderField} {Order}";

            string WhereField = "WHERE ", WhereValue;
            if (cbbSearchField.SelectedIndex >= 0)
            {
                WhereField += $" {FieldAndCols[cbbSearchField.SelectedIndex][0]} ";
                if (!String.IsNullOrEmpty(edtSearchValue.Text))
                {
                    switch (FieldTypes[cbbSearchField.SelectedIndex])
                    {
                        case DataTypes.Number:
                            WhereValue = $"= {edtSearchValue.Text}";
                            break;
                        default:
                            WhereValue = $"LIKE '%{edtSearchValue.Text}%'";
                            break;
                    }
                    WHERE = $" {WhereField} {WhereValue}";
                }
            }
            FillTable();
            if (dgvTableData.SelectedRows.Count != 0)
                if (dgvTableData.SelectedRows[0].Cells[0].Value != null)
                    MyUpdateComps.UpdateValue(ActiveTable);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show( $"{DataModule.ExecuteSQL(MyUpdateComps.GenerateUpdateSQL(ActiveTable))} Rows were effected");
            DataModule.LoadTable(ref dgvTableData, $"SELECT * FROM {TableName}");
        }
    }
}
