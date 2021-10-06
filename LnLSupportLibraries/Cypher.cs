//Manuel A Nunes 34551875
//2021-10-05
namespace CypherLib
{
    public static class Cypher
    {
        static private string OldKey = "11111111";
        static private string NewKey = "11111111";
        static public string Encrypt(string UnCrypt)
        {
            string Return = "";
            int iKey = 0;
            for (int x = 0; x < UnCrypt.Length; x++)
            {
                int temp = (((int)UnCrypt[x]) + ((int)NewKey[iKey] - '0'));
                if (temp > 126)
                    temp = temp - 80;
                Return += (char)temp;
                iKey++;
                if (iKey == NewKey.Length)
                    iKey = 0;
            }    
            return Return;
        }
        static public string Decrypt(string UnCrypt)
        {
            string Return = "";
            int iKey = 0;
            for (int x = 0; x < UnCrypt.Length; x++)
            {
                int temp = (((int)UnCrypt[x]) - ((int)NewKey[iKey] - '0'));
                if (temp < 48)
                    temp = temp + 80;
                Return += (char)temp;
                iKey++;
                if (iKey == NewKey.Length)
                    iKey = 0;
            }
            return Return;
        }
        static public string UpdateFromOldKey(string EncryptedValue)
        {
            string TempKey = NewKey;
            NewKey = OldKey;
            string TempValue = Decrypt(EncryptedValue);
            NewKey = TempKey;
            TempValue = Encrypt(TempValue);
            return TempValue;
        }
        public static void UpdateKey(string strNewKey)
        {
            OldKey = NewKey;
            NewKey = strNewKey;
        }
    }
}
