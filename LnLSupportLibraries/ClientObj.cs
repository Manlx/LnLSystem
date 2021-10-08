//Manuel A Nunes 34551875
using System;
using NSDataModule;
namespace ClientAndUtils
{
    public enum ClientErrors
    {
        InvalidID
    }
    public class ClientObj
    {
        public string EncPassword,ClientID,Password,EmailAddress,CellNumber,Name,SurName,TabID;
        public bool IsBlackListed, Limited,HasTab;
        public ClientObj(){}
        public bool LoadFromDB(string ID)
        {
            if (!int.TryParse(ID,out int Temp))
                return false;
            try
            {
                string[][] Data = DataModule.GetValues($"SELECT ClientID,Name,SurName,CellNumber,EmailAddress,IsBlackList,Password FROM tblClient WHERE ClientID = {Temp}", new int[] { 0, 1, 2, 3, 4, 5, 6 });
                foreach (string[] Row in Data)
                {
                    ClientID = Row[0];
                    Name = Row[1];
                    SurName = Row[2];
                    CellNumber = Row[3];
                    EmailAddress = Row[4];
                    IsBlackListed = Row[5] == "1";
                    Password = Row[6];
                }
                HasTab = (TabID = DataModule.GetValue(0, $"SELECT * FROM tblTab WHERE ClientID = {this.ClientID}")) != "" ;
                return true;
            }
            catch (Exception)
            {
                return false; 
                throw;
            }
        }
        public bool DoesExist()
        {
            return (ClientID != "") && (Password != "");
        }
    }
}
