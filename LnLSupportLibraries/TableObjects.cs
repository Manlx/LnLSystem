//Manuel A Nunes 34551875
using NSDataModule;

namespace NSTableAndUtil
{
    public enum DataTypes
    {
        String,
        Number,
        Boolean,
        Date
    }
    public static class Utilities
    {
        public static DataTypes StringToDT(string Input)
        {
            int Out;
            Input = Input.ToUpper();
            string[] Strings = { "VARCHAR(", "VARCHAR", "CHAR(", "TINYTEXT", "TEXT(", "MEDIUMTEXT", "LONGTEXT", "NVARCHAR" },
                Number = { "TINYINT", "SMALLINT", "INT", "BIGINT", "DECIMAL", "INTEGER(", "DOUBLE(", "FLOAT(", "DECIMAL(", "DEC(" },
                Booleans = { "BOOL", "BIT", "BIT(" },
                DATE = { "DATE", "DATETIME(", "TIMESTAMP(", "TIME(", "YEAR" };
            Out = -1;
            bool bLooking = true;

            while (bLooking && Out < 4)
            {
                Out++;
                int x = 0;
                switch (Out)
                {
                    case 0:
                        while (bLooking && x < Strings.Length)
                            bLooking = Input.IndexOf(Strings[x++]) < 0;
                        break;
                    case 1:
                        while (bLooking && x < Number.Length)
                            bLooking = Input.IndexOf(Number[x++]) < 0;
                        break;
                    case 2:
                        while (bLooking && x < Booleans.Length)
                            bLooking = Input.IndexOf(Booleans[x++]) < 0;
                        break;
                    case 3:
                        while (bLooking && x < DATE.Length)
                            bLooking = Input.IndexOf(DATE[x++]) < 0;
                        break;
                }
            }
            return (DataTypes)Out;
        }
        public static Field SearchField(Field[] Fields, string FieldName)
        {
            int x = 0;
            bool Looking = true;
            for (; Looking && x < Fields.Length; x++)
                Looking = Fields[x].FieldDesc != FieldName;
            return (Looking)?null :Fields[--x];
        }
        public static Table SearchTable(Table[] Tables, string TableName)
        {
            bool bLooking = true;
            int x = 0;
            for (; x < Tables.Length && bLooking; x++)
                bLooking = Tables[x].TableName != TableName;
            return (bLooking) ?null : Tables[--x];
        }
        public static void UpdateFields(Table[] Tables)
        {
            string[][] Datas = DataModule.GetValues($"SELECT CONSTRAINT_NAME,TABLE_NAME,COLUMN_NAME,REFERENCED_TABLE_NAME,REFERENCED_COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE" +
                $" WHERE REFERENCED_COLUMN_NAME IS NOT NULL " +
                $"ORDER BY TABLE_NAME ASC; ",new int[] { 1,2,3,4});
            foreach (string[] Row in Datas)
            {
                Table TempTable = SearchTable(Tables, Row[0]);//Looks for table and gets fields of selected table;
                Field[] TempFields = TempTable.Fields;
                Field SelectedField = SearchField(TempFields, Row[1]);//Get Selected field
                SelectedField.Source = SearchTable(Tables, Row[2]);//Gets Source table for foreign table
                SelectedField.FieldPrime = SearchField(SelectedField.Source.Fields,Row[3]);//Get foreign field
                SelectedField.IsReference = true;
            }
            
        }
        public static Table[] GenerateTables()
        {
            string[] Datas = DataModule.GetValues<string>(0,"SHOW TABLES");
            Table[] Tables = new Table[Datas.Length];
            for (int x = 0; x < Datas.Length; x++)
                Tables[x] = new Table(Datas[x]);
            return Tables;
        }
    }
    public class Field
    {
        public DataTypes DataType;
        public string FieldDesc;
        public bool IsReference;
        public Table Source;
        public Field FieldPrime;
        public bool IsPrimaryField;
        public bool ReadOnly;
        public Field(DataTypes DataType,string FieldDesc)
        {
            this.DataType = DataType;
            this.FieldDesc = FieldDesc;
        }
    }
    public class Table
    {
        public string TableName;
        public Field[] Fields;
        public Table(string TableName)
        {
            string[][] FieldsData = DataModule.GetValues($"SHOW COLUMNS FROM {TableName}",new int[] {0,1,3,5 });
            this.TableName = TableName;
            Fields = new Field[FieldsData.Length];

            for (int x = 0;x < FieldsData.Length;x++)
            {
                Fields[x] = new Field(Utilities.StringToDT(FieldsData[x][1]), FieldsData[x][0]);
                Fields[x].IsPrimaryField = FieldsData[x][2] != "";
                Fields[x].ReadOnly = FieldsData[x][3] != "";
            }
                

        }
    }
}
