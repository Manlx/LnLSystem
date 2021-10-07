//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NSDataModule
{
    public static class DataModule
    {
        public static string IP { private get; set; } = "197.242.148.255";
        public static string USER { private get; set; } = "mfdotjzd_LNLDBUSER";
        public static string DATABASE { private get; set; } = "mfdotjzd_LnLDatabase";
        public static string PASSWORD { private get; set; } = "b?0zefWA&.93JfA0-#";
        public static MySqlConnection Con { private get; set; } = new MySqlConnection(
            $"SERVER={IP};PORT=3306;DATABASE={DATABASE};UID={USER};PASSWORD={PASSWORD};SSLMode=none");
        public static MySqlCommand Com { private get; set; } = new MySqlCommand();
        public static MySqlDataAdapter Dapter { private get; set; } = new MySqlDataAdapter();
        public static MySqlDataReader Reader { private get; set; }
        public static DataSet DataS;
        public static int TableSpacer = 2;
        //public static void UpdateConString()
        //public static bool OpenConnection()
        //public static bool LoadTable(ref DataGridView Grid, string SQL)
        //public static T[][] GetValues<T>(string SQL, int[] ArrColums);
        public static bool LoadTable(ref DataGridView Grid, string SQL)
        {
            bool bSuccess = OpenConnection();
            if (!bSuccess)
                return bSuccess;
            Com = new MySqlCommand(SQL, Con);
            Dapter = new MySqlDataAdapter(Com);
            DataS = new DataSet();
            Dapter.Fill(DataS, "SourceTable");
            Grid.DataSource = DataS;
            Grid.DataMember = "SourceTable";
            Con.Close();
            Com.Dispose();
            Dapter.Dispose();
            return bSuccess;
        }
        /// <summary>
        /// Tries to open a connection to main database.
        /// </summary>
        /// <returns>True if connection was successfull; False if connection encountered an error</returns>
        public static bool OpenConnection()
        {
            if (Con.State == System.Data.ConnectionState.Open)
                return true;
            try
            {
                Con.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        /// <summary>
        /// Updates the Connection Object with the new connection string created from the static variables
        /// </summary>
        public static void UpdateConString()
        {
            if (!CloseConnection())
                return;
            Con = new MySqlConnection($"SERVER={IP};PORT=3306;DATABASE={DATABASE};UID={USER};PASSWORD={PASSWORD};SSLMode=none");
        }
        /// <summary>
        /// Given the table name and Column Number the method returns the column name and type starting at 0
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="ColumNumber"></param>
        /// <returns></returns>
        public static string GetNameAndColumType(string tableName, int ColumnNumber)
        {
            string[] arrType = GetValues<string>(1, $"SHOW COLUMNS FROM {tableName}");
            string[] arrField = GetValues<string>(0, $"SHOW COLUMNS FROM {tableName}");
            if (ColumnNumber < arrField.Length)
                return $"{arrField[ColumnNumber]} {arrType[ColumnNumber]}";
            return "";
        }
        public static string[][] GetNamesAndColumTypes(string tableName)
        {
            string[] arrType = GetValues<string>(1, $"SHOW COLUMNS FROM {tableName}");
            string[] arrField = GetValues<string>(0, $"SHOW COLUMNS FROM {tableName}");
            string[][] Outs = new string[arrType.Length][];
            for (int x = 0; x < arrType.Length; x++)
                Outs[x] = new string[] {arrField[x],arrType[x] };
            return Outs;
        }
        /// <summary>
        /// Gets the datatype of given column number in table
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="ColumnNumber"></param>
        /// <returns></returns>
        public static string GetColumType(string tableName, int ColumnNumber)
        {
            string[] arrType = GetValues<string>(1, $"SHOW COLUMNS FROM {tableName}");
            if (ColumnNumber < arrType.Length)
                return $"{arrType[ColumnNumber]}";
            return "";
        }
        /// <summary>
        /// Tries to Close the database connection if open
        /// </summary>
        /// <returns>True if closed successfully; False if Failed</returns>
        public static bool CloseConnection()
        {
            try
            {
                Con.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
                throw;
            }
        }
        /// <summary>
        /// Set the SQL command for later use
        /// </summary>
        /// <param name="SQL">SQL to be set</param>
        /// <returns>True if Successfull false if failed</returns>
        public static bool SetCom(string SQL)
        {
            try
            {
                Com.Connection = Con;
                Com.CommandText = SQL;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// This function is used to get the first records selected field value
        /// </summary>
        /// <typeparam name="T">The datatype used stored in the field</typeparam>
        /// <param name="Colum">The column/field number starting at 0</param>
        /// <param name="SQL">The sql to be executed if SQL is left empty the function assumes that the SQL has already be set</param>
        /// <returns>Returns the value of selected datatype</returns>
        public static string GetValue(int Colum, string SQL = "")
        {
            string Outs = default;
            if (OpenConnection())
            {
                if (SQL != "")
                    Com = new MySqlCommand(SQL, Con);
                else if (Com.CommandText == "")
                    return Outs;
                Reader = Com.ExecuteReader();
                Reader.Read();
                if (Colum < Reader.FieldCount)
                    Outs = Reader.GetValue(Colum).ToString();
            }
            Reader.Close();
            return Outs;
        }
        public static T GetValue<T>(int Colum, string SQL = "")
        {
            T Outs = default;
            if (OpenConnection())
            {
                if (SQL != "")
                    Com = new MySqlCommand(SQL, Con);
                else if (Com.CommandText == "")
                    return Outs;
                Reader = Com.ExecuteReader();
                Reader.Read();
                if (Colum < Reader.FieldCount)
                    Outs = (T)Reader.GetValue(Colum);
            }
            Reader.Close();
            return Outs;
        }
        ///<summary>
        ///The GetValues function returns the selected colum of the executed sql
        ///</summary>
        ///<returns>Returns an array of the generic data type</returns>
        public static T[] GetValues<T>(int Colum, string SQL = "")
        {

            System.Collections.Generic.List<T> Outs = new System.Collections.Generic.List<T>();

            if (OpenConnection())
            {
                if (SQL != "")
                    Com = new MySqlCommand(SQL, Con);
                else if (Com.CommandText == "")
                    return Outs.ToArray();
                Reader = Com.ExecuteReader();
                if (Colum < Reader.FieldCount)
                    while (Reader.Read())
                        Outs.Add((T)Reader.GetValue(Colum));
                Reader.Close();
            }

            return Outs.ToArray();
        }
        public static string[] GetValues(int Colum, string SQL = "")
        {

            System.Collections.Generic.List<string> Outs = new System.Collections.Generic.List<string>();

            if (OpenConnection())
            {
                if (SQL != "")
                    Com = new MySqlCommand(SQL, Con);
                else if (Com.CommandText == "")
                    return Outs.ToArray();
                Reader = Com.ExecuteReader();
                if (Colum < Reader.FieldCount)
                    while (Reader.Read())
                        Outs.Add(Reader.GetValue(Colum).ToString());
                Reader.Close();
            }

            return Outs.ToArray();
        }
        /// <summary>
        /// Executes SQL and returns the number of effected columns 
        /// </summary>
        /// <param name="SQL">The SQL String</param>
        /// <returns>The number of effected Columns</returns>
        public static int ExecuteSQL(string SQL)
        {
            if (!OpenConnection())
                return -1;
            if (SQL != "")
                Com = new MySqlCommand(SQL, Con);
            try
            {
                return Com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
                throw;
            }

        }
        public static string[] GetTableFields(string SQL)
        {
            if (!OpenConnection())
                return new string[0];
            Com = new MySqlCommand(SQL, Con);
            Reader = Com.ExecuteReader();
            string[] temp = new string[Reader.FieldCount];
            for (int x = 0; x < Reader.FieldCount; x++)
                temp[x] = Reader.GetName(x);

            Reader.Close();
            Con.Close();
            return temp;
        }

        public static string[] GenerateTable(string SQL)
        {
            if (!OpenConnection())
                return new string[] { "Connection failed" };
            Com = new MySqlCommand(SQL, Con);
            try
            {
                Reader = Com.ExecuteReader();
                //Gets Sizing for tabel Columns
                int[] Sizing = new int[Reader.VisibleFieldCount];
                //Gets Headings
                string[] Headings = new string[Reader.FieldCount];
                for (int x = 0; x < Sizing.Length; x++)
                {
                    Headings[x] = Reader.GetName(x);
                    Sizing[x] = Headings[x].Length;
                }
                //Output is a list of String array. List because we don't know how many records there are. String Array because we know before hand how many fields there are.
                List<string[]> OutPut = new List<string[]>();

                //Reads through table
                while (Reader.Read())
                {
                    OutPut.Add(new string[Reader.VisibleFieldCount]);
                    for (int x = 0; x < Reader.FieldCount; x++)
                    {
                        OutPut[OutPut.Count - 1][x] += Reader.GetValue(x).ToString();
                        if (OutPut[OutPut.Count - 1][x].Length > Sizing[x])
                            Sizing[x] = OutPut[OutPut.Count - 1][x].Length;
                    }
                }

                int ColCount = Reader.FieldCount;
                //Closes IO
                Reader.Close();
                Con.Close();

                //Builds Output
                string[] ProperOut = new string[OutPut.Count + 1];//Plus one to make space for the headings
                string temp = "";
                for (int y = 0; y < ColCount; y++)
                    temp += $"{StringReSizer(ref (Headings[y]), (Sizing[y] + TableSpacer))}";
                ProperOut[0] = temp;
                int Max = OutPut.Count + 1;
                for (int x = 1; x < Max; x++)
                {
                    temp = "";
                    for (int y = 0; y < ColCount; y++)
                        temp += $"{StringReSizer(ref (OutPut[x - 1][y]), (Sizing[y] + TableSpacer))}";
                    ProperOut[x] = temp;
                }
                return ProperOut;
            }
            catch
            {
                return new string[] { "SQL Error Encountered" };
            }
        }
        public static string StringReSizer(ref string Input, int SizeReg)
        {
            if (SizeReg < 0)
                SizeReg *= -1;
            for (int x = Input.Length; x < SizeReg; x++)
                Input += " ";
            return Input;
        }

        public static string[] GetTableDataTypes(string SQL)
        {//Loops through the table created with the SQL instruction and return the datatype of each column
            if (!OpenConnection())
                return new string[] { "Connection Failed to be opened" };
            try
            {
                Com = new MySqlCommand(SQL, Con);
                Reader = Com.ExecuteReader();
                string[] DataTypes = new string[Reader.VisibleFieldCount];
                for (int x = 0; x < DataTypes.Length; x++)
                    DataTypes[x] = Reader.GetDataTypeName(x);
                Reader.Close();
                Com.Dispose();
                Con.Close();
                return DataTypes;
            }
            catch (Exception e)
            {
                return new string[] { "SQL Failure", e.ToString() };
                throw;
            }
        }
        public static int GetColumCount(string SQL)
        {//Returns the count of columns in sql table
            if (!OpenConnection())
                return -1;
            Com = new MySqlCommand(SQL, Con);
            int temp = Com.ExecuteReader().FieldCount;
            Con.Close();
            return temp;
        }
        public static string[][] GetValues(string SQL, int[] ArrColums)
        {//Returns an array of array of selected columns and cells
            string[][] Out = default;

            int TableMax = GetColumCount(SQL);
            for (int x = 0; x < ArrColums.Length; x++)
                if (TableMax <= ArrColums[x])
                    return Out;
            if (!OpenConnection())
                return Out;

            List<string[]> Big = new List<string[]>();
            Reader = new MySqlCommand(SQL, Con).ExecuteReader();
            while (Reader.Read())
            {
                string[] Row = new string[ArrColums.Length];
                for (int x = 0; x < ArrColums.Length; x++)
                    Row[x] = (Reader.GetValue(ArrColums[x]).ToString());
                Big.Add(Row);
            }
            Con.Close();
            return Big.ToArray();
        }
        public static T[][] GetValues<T>(string SQL, int[] ArrColums)
        {//Returns an array of array of selected columns and cells
            T[][] Out = default;

            int TableMax = GetColumCount(SQL);
            for (int x = 0; x < ArrColums.Length; x++)
                if (TableMax <= ArrColums[x])
                    return Out;
            if (!OpenConnection())
                return Out;

            List<T[]> Big = new List<T[]>();
            Reader = new MySqlCommand(SQL, Con).ExecuteReader();
            while (Reader.Read())
            {
                T[] Row = new T[ArrColums.Length];
                for (int x = 0; x < ArrColums.Length; x++)
                    Row[x] = (T)(Reader.GetValue(ArrColums[x]));
                Big.Add(Row);
            }
            Con.Close();
            return Big.ToArray();
        }
    }
}
