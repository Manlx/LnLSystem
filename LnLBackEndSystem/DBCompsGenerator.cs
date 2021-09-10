using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSDataModule;

namespace LnLBackEndSystem
{
    public class DBCompsGenerator
    {
        public Control[] Inputs;
        public Label[] Desc;
        public DBCompsGenerator(Control Parents, string SQL)
        {
            int[] Cols = { 0, 1 };
            string[][] NameAndType = DataModule.GetValues(SQL, Cols);
            Inputs = new Control[NameAndType.Length];
            Desc = new Label[NameAndType.Length];
            for (int x = 0;x < NameAndType.Length;x++)
            {
                string temp = StringMakeLength( NameAndType[x][1],7);
                if (temp.IndexOf("int(") == 0)
                {
                    Inputs[x] = new TextBox() {Height = 50, Width= 150 };
                    ((TextBox)Inputs[x]).TextChanged += new EventHandler(edtInpNumOnly);
                }
            }
        }
        public static string StringMakeLength(string Inp, int Length = 0)
        {
            for (int x = Inp.Length; x < Length; x++)
                Inp += ' ';
            return Inp.Substring(0,Length);
        }
        public static void edtInpNumOnly(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if ((int)temp.Text[temp.Text.Length - 1] < 48 || (int)temp.Text[temp.Text.Length - 1] > 47)
                temp.Text = temp.Text.Substring(0,temp.Text.Length-2);
        }
    }
}
