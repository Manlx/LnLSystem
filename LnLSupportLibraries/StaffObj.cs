//Manuel A Nunes 34551875
using System;
using NSDataModule;
using NSTableAndUtil;

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
        public bool InsertSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"INSERT INTO tblStaff (Name,Surname,CellNumber,HasLicense,IsFullTimeMember,RankID,EncryptedPassword) VALUES " +
                    $"('{Name}','{SurName}','{CellNumber}','{Utilities.BoolToBit(HasLicense)}','{Utilities.BoolToBit(IsFullTimeMember)}',{RankID},'{EncryptedPassword}')") > 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool UpdateSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"UPDATE tblStaff SET Name = '{Name}',Surname = '{SurName}',CellNumber = '{CellNumber}' ," +
                    $"HasLicense = {Utilities.BoolToBit(HasLicense)},IsFullTimeMember = {Utilities.BoolToBit(IsFullTimeMember)},RankID = {RankID}," +
                    $"EncryptedPassword = '{EncryptedPassword}' WHERE StaffID = {StaffID} ")> 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool DeleteSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"DELETE FROM tblStaff WHERE StaffID = {StaffID}") > 0;
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
