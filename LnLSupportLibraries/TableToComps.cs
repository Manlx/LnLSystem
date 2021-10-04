//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSTableAndUtil;
using NSDataModule;

namespace LnLSupportLibraries
{
    public class CompsUtilities
    {
        public Control[] InputControl;
        public Label[] Labels;
        public Table TableUpdate;
        public DataGridView dgvDipInp;
        public void CreateComs(Table InpTable, Control BigParent,DataGridView DataInput)
        {//Generates Components Required to do Update functions
            this.dgvDipInp = DataInput;
            TableUpdate = InpTable;
            InputControl = new Control[InpTable.Fields.Length];
            if (Labels != null)
                foreach (Control DisItems in Labels)
                DisItems.Dispose();

            Labels = new Label[InpTable.Fields.Length];
            int ColCount = 10,RowCount = 10;
            int x = 0;
            foreach (Field SelField in InpTable.Fields)
            {
                if (SelField.IsReference)
                {
                    InputControl[x] = new ComboBox() { Name=$"cbb{SelField.FieldDesc}", Parent = BigParent, /*Enabled = !SelField.IsPrimaryField*/ };
                    foreach (string Item in DataModule.GetValues(0, $"SELECT {SelField.FieldPrime.FieldDesc} FROM {SelField.Source.TableName}"))
                        ((ComboBox)InputControl[x]).Items.Add(Item);
                }
                else
                {
                    switch (SelField.DataType)
                    {
                        case DataTypes.Boolean: InputControl[x] = new CheckBox() { Name = $"chk{SelField.FieldDesc}",Text = ".", Parent =BigParent, AutoSize = true,/*Enabled = !SelField.IsPrimaryField*/ };
                            break;
                        case DataTypes.String:
                        case DataTypes.Date:
                        case DataTypes.Number:
                        {
                            InputControl[x] = new TextBox() { Name = $"edt{SelField.FieldDesc}", Parent = BigParent,/* Enabled = !SelField.IsPrimaryField*/ };
                            if (SelField.DataType == DataTypes.Number)
                                ((TextBox)InputControl[x]).TextChanged += new EventHandler(NumberOnly);
                        }
                        break;
                    }
                }
                Labels[x] = new Label() { Text = SelField.FieldDesc, AutoSize = true, Parent = BigParent};
                int temp = ColCount + Labels[x].Width+InputControl[x].Width+10;
                if (temp > BigParent.Width)
                {
                    RowCount = InputControl[x].Height + 20;
                    temp -= ColCount;
                    ColCount = 10;
                }
                Labels[x].Left = ColCount;
                Labels[x].Top = RowCount;
                ColCount += Labels[x].Width;
                InputControl[x].Top = RowCount;
                InputControl[x].Left = ColCount;
                ColCount = temp;
                x++;
            }
        }
        public string GenerateUpdateString()
        {//Generate SQL UPDATE Statment
            string SQL = $"UPDATE {TableUpdate.TableName} SET ";
            for (int x = 0; x < TableUpdate.Fields.Length; x++)
                SQL += $" {Utilities.FieldAndCompToString(TableUpdate.Fields[x], InputControl[x])},";

            SQL = SQL.Substring(0,SQL.Length-2);

            SQL += " WHERE ";
            bool Looking = true;
            int y = 0;
            for (; y < TableUpdate.Fields.Length && Looking; y++)
                Looking = !TableUpdate.Fields[y].IsPrimaryField;
            SQL += $" {Utilities.FieldAndCompToString(TableUpdate.Fields[y],InputControl[y])}";
            return SQL;
        }
        private void NumberOnly(object sender, EventArgs e)
        {//Checks if the text box only has numbers in it
            TextBox TempBox = ((TextBox)sender);
            string temp = TempBox.Text;
            RemoveLetters(ref temp);
            TempBox.Text = temp;
        }
        public void UpdateValue(Table InpTable)
        {//Loops through all comps and updates the displayed values
            int x = 0;
            foreach (Field SelField in InpTable.Fields)
            {
                if (SelField.IsReference)
                    ((ComboBox)InputControl[x]).Text = dgvDipInp.SelectedRows[0].Cells[x].Value.ToString();
                else if (SelField.DataType == DataTypes.Boolean)
                    ((CheckBox)InputControl[x]).Checked = dgvDipInp.SelectedRows[0].Cells[x].Value.ToString() == "1";
                else
                    ((TextBox)InputControl[x]).Text = dgvDipInp.SelectedRows[0].Cells[x].Value.ToString();
                x++;
            }
                
        }
        public string GenerateUpdateSQL(Table InpTable)
        {
            //Builds Update String
            string SQL = $"UPDATE {InpTable.TableName} SET ",strTemp;
            int x = 0;
            
            foreach (Field SelField in InpTable.Fields)
            {
                SQL = $"{SQL} {SelField.FieldDesc} = {ConfQoutes(SelField, GetValueAt(SelField, x))},";
                x++;
            }

            SQL = SQL.Remove(SQL.Length-1,1);
            
            SQL = $"{SQL} {BuildWHERE(InpTable,dgvDipInp)};";
            return SQL;
        }
        public static string BuildWHERE(Table InpTable, DataGridView dgvDipInp)
        {//Builds where string for update and Delete SQL Statements
            string WHERE = "WHERE ";
            int x = 0;
            foreach (Field SelField in InpTable.Fields)
            {
                if (SelField.IsPrimaryField)
                    WHERE = $"{WHERE} ({SelField.FieldDesc} = {ConfQoutes(SelField, dgvDipInp.SelectedRows[0].Cells[x].Value.ToString())}) AND ";
                x++;
            }
            WHERE = WHERE.Remove(WHERE.Length - 5, 4);
            return WHERE;
        }
        public string GetValueAt(Field SelField,int x)
        { //Gets Values out of objects at
            string strTemp;
            if (SelField.IsReference)
                strTemp = ((ComboBox)InputControl[x]).Items[((ComboBox)InputControl[x]).SelectedIndex].ToString();
            else
                switch (SelField.DataType)
                {
                    case DataTypes.Boolean:
                        strTemp = ((CheckBox)InputControl[x]).Checked ? "1" : "0";
                        break;
                    default:
                        strTemp = ((TextBox)InputControl[x]).Text;
                        break;
                }
            return strTemp;
        }
        public static string ConfQoutes(Field Col, string Value)
        { //Adds Qoutes if required
            if (Col.DataType == DataTypes.Number)
                return Value;
            else
                return $"'{Value}'";
        }
        public void RemoveLetters(ref string Value)
        {//Removes Letters for string leaving only numbers
            string Temp = "";
            foreach (char x in Value)
                if (x > 47 && x < 58)
                    Temp += x;
            Value = Temp;
        }
        public bool GenerateInsertSQL(ref string SQL,Table InpTable)
        {
            bool isSuccess = true;
            Field SelField;
            int x = 0;
            SQL = $"INSERT INTO {InpTable.TableName} (";
            string Cols = "", Values = "";
            bool IsAllEmpty= true;

            while (x < InpTable.Fields.Length && isSuccess )
            {
                SelField = InpTable.Fields[x];
                string strTemp =GetValueAt(SelField,x);
                if (strTemp!= "")
                {
                    Cols += $"{SelField.FieldDesc}, ";
                    Values += $"{ConfQoutes(SelField,strTemp)}, ";
                }
                else if (InpTable.HasMultiPrime)
                        if (SelField.IsPrimaryField)
                            isSuccess = strTemp != "";
                if (IsAllEmpty)
                    IsAllEmpty = strTemp == "";
                x++;
            }

            if (Values.Length >2)
                Values= Values.Remove(Values.Length - 2, 2);
            if (Cols.Length > 2)
                Cols = Cols.Remove(Cols.Length - 2, 2);
            
            SQL += $"{Cols}) VALUES ({Values})";
            return isSuccess && !IsAllEmpty;
        }
    }

}
