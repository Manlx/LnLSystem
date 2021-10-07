using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSDataModule;

namespace StaffObjAndUtils
{
    public class StaffObj
    {
        public string StaffID, Name, SurName, CellNumber, RankID, EncryptedPassword;
        public bool HasLicense, IsFullTimeMember;
        public StaffObj() { }
        public bool LoadFromDB(string ID)
        {
            if (!int.TryParse(ID, out int Temp))
                return false;
            try
            {
                string[][] Data = DataModule.GetValues($"SELECT StaffID,Name,Surname,CellNumber,HasLicense,IsFullTimeMember," +
                    $"RankID,EncryptedPassword FROM tblStaff WHERE StaffID = {Temp}", new int[] { 0, 1, 2, 3, 4, 5, 6,7 });
                foreach (string[] Row in Data)
                {
                    StaffID = Row[0];
                    Name = Row[1];
                    SurName = Row[2];
                    CellNumber = Row[3];
                    HasLicense = Row[4] == "1" ;
                    IsFullTimeMember = Row[5] == "1";
                    RankID = Row[6];
                    EncryptedPassword = Row[7];
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool IsValid()
        {
            return (StaffID != "") && (EncryptedPassword != "");
        }

    }
}
