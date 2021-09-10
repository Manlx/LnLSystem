using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnLBackEndSystem
{
    public enum FieldType
    {
        Integer,
        String,
        Boolean
    }
    public class clsTables
    {
        public string[] Fields;
        public FieldType[] FieldDataType;
        public clsTableRelation[] Connections;
    }
}
