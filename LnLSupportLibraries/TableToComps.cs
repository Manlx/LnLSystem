//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSTableAndUtil;
using NSDataModule;
using NSTableAndUtil;

namespace LnLSupportLibraries
{
    public class CreateUpdateComs
    {
        public Control[] InputControl;
        public Table TableUpdate;
        public CreateUpdateComs(Table InpTable, Control BigParent)
        {
            TableUpdate = InpTable;
            InputControl = new Control[InpTable.Fields.Length];
            int x = 0;
            foreach (Field SelField in InpTable.Fields)
            {
                if (SelField.IsReference)
                {
                    InputControl[x] = new ComboBox() { Name=$"cbb{SelField.FieldDesc}" };
                    foreach (string Item in DataModule.GetValues<string>(0, $"SELECT {SelField.FieldPrime.FieldDesc} FROM {SelField.Source.TableName}"))
                        ((ComboBox)InputControl[x]).Items.Add(Item);
                }
                else
                {
                    switch (SelField.DataType)
                    {
                        case DataTypes.Boolean: InputControl[x] = new CheckBox() { Name = $"chk{SelField.FieldDesc}", Text = SelField.FieldDesc, };
                            break;
                        case DataTypes.String:
                        case DataTypes.Date:
                        case DataTypes.Number:
                        {
                            InputControl[x] = new TextBox() { Name = $"edt{SelField.FieldDesc}" };
                            if (SelField.DataType == DataTypes.Number)
                                ((TextBox)InputControl[x]).TextChanged += new EventHandler(NumberOnly);
                        }
                        break;
                    }
                }
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
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, ((TextBox)sender).Text.Length-2);
        }
    }
}
