//Manuel A Nunes 34551875
using System;
using NSDataModule;
namespace BankObjAndUtil
{
    public class BankObj
    {
        public string BankID, BankName;
        public bool isFilled()
        {
            return (!String.IsNullOrEmpty(BankID) && !String.IsNullOrEmpty(BankName));
        }
        public bool Equals(BankObj Other)
        {
            return (BankID == Other.BankID) && (BankName == Other.BankName);
        }
        public bool InsertSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"INSERT INTO tblBank (BankName) Values ('{BankName}')") > 0;
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
                return DataModule.ExecuteSQL($"DELETE FROM tblBank WHERE BankID = {BankID}") > 0;
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
                return DataModule.ExecuteSQL($"Update tblBank SET BankName = '{BankName}' WHERE BankID = {BankID}") > 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool LoadFromDB(string ID)
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT BankID,BankName FROM tblBank WHERE BankID = {ID}", new int[] { 0, 1 })[0];
                if (Row.Length <= 0)
                    return false;
                this.BankID = Row[0];
                this.BankName = Row[1];
                return isFilled();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
