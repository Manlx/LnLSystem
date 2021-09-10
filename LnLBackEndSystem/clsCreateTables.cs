using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSDataModule;

namespace LnLBackEndSystem
{
    public class clsCreateTables
    {
        public clsCreateTables(string SQL)
        {
            string[] TableNames = DataModule.GetValues<string>(0,"SHOW Tables");
            //foreach
            //DataModule.GetNameAndColumType();
        }
    }
}
