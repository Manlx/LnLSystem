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
    public class CreateUpdateComs
    {
        public Control[] InputControl;
        public Label[] Labels;
        public Table TableUpdate;
        public DataGridView dgvDipInp;
        public CreateUpdateComs(Table InpTable, Control BigParent,DataGridView DataInput)
        {
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
                    InputControl[x] = new ComboBox() { Name=$"cbb{SelField.FieldDesc}", Parent = BigParent };
                    foreach (string Item in DataModule.GetValues(0, $"SELECT {SelField.FieldPrime.FieldDesc} FROM {SelField.Source.TableName}"))
                        ((ComboBox)InputControl[x]).Items.Add(Item);
                }
                else
                {
                    switch (SelField.DataType)
                    {
                        case DataTypes.Boolean: InputControl[x] = new CheckBox() { Name = $"chk{SelField.FieldDesc}",Text = ".", Parent =BigParent, AutoSize = true };
                            break;
                        case DataTypes.String:
                        case DataTypes.Date:
                        case DataTypes.Number:
                        {
                            InputControl[x] = new TextBox() { Name = $"edt{SelField.FieldDesc}", Parent = BigParent};
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
        //private void NumberOnly(object sender, EventArgs e)
        //{
        //    ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, ((TextBox)sender).Text.Length-2);
        //}
        private void NumberOnly(object sender, EventArgs e)
        {
            TextBox TempBox = ((TextBox)sender);
            string temp = TempBox.Text;
            RemoveLetters(ref temp);
            //((TextBox)sender).Text;
            TempBox.Text = temp;
        }
        public void UpdateValue(Table InpTable)
        {
            int x = 0;
            foreach (Field SelField in InpTable.Fields)
            {
                if (SelField.IsReference)
                    ((ComboBox)InputControl[x]).Text = dgvDipInp.SelectedRows[0].Cells[x].Value.ToString();
                else
                    switch (SelField.DataType)
                    {
                        case DataTypes.Boolean:
                            ((CheckBox)InputControl[x]).Checked = dgvDipInp.SelectedRows[0].Cells[x].Value.ToString() == "1";
                            break;
                        default:
                            ((TextBox)InputControl[x]).Text = dgvDipInp.SelectedRows[0].Cells[x].Value.ToString();
                            break;
                    }
                x++;
            }
                
        }
        //public string GenerateUpdateSQL(Table InpTable)
        //{
        //    string SQL = $"UPDATE {InpTable.TableName} SET ";
        //    int x = 0;
        //    foreach (Field SelField in InpTable.Fields)
        //    {
        //        if (!SelField.IsPrimaryField)
        //        {
        //            SQL = $"{SQL} {SelField.FieldDesc} = {((SelField.DataType != DataTypes.Number) ? "'" : "")}";
        //            if (SelField.IsReference)
        //                (ComboBox)InputControl[x]).Text;
        //            else
        //                switch (SelField.DataType)
        //                {
        //                    case DataTypes.Boolean:
        //                        ((CheckBox)InputControl[x]).Checked = dgvDipInp.SelectedRows[0].Cells[x].Value.ToString() == "1";
        //                        break;
        //                    default:
        //                        ((TextBox)InputControl[x]).Text = dgvDipInp.SelectedRows[0].Cells[x].Value.ToString();
        //                        break;
        //                }
        //            SQL = $"{SQL}{((SelField.DataType != DataTypes.Number) ? "'" : "")}";

        //        }
        //        x++;
        //    }
                
                    
        //    return SQL;
        //}

        public void RemoveLetters(ref string Value)
        {
            string Temp = "";
            foreach (char x in Value)
                if (x > 48 && x < 57)
                    Temp += x;
            Value = Temp;
        }
    }

}
