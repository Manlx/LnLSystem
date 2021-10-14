//Manuel A Nunes 34551875
using System;

using NSDataModule;
namespace StaffRankObjUtil
{
    
    public class StaffRankObj
    {
        public string RankID, Description, Salary, isSenior;
        private string gWHERE { get { return $"WHERE RankID = {RankID}"; } }
        public StaffRankObj()
        {
        }
        public StaffRankObj(string rankID, string description, string salary, string isSenior)
        {
            RankID = rankID;
            Description = description;
            Salary = salary;
            this.isSenior = isSenior;
        }
        public bool isFilled()
        {
            return !String.IsNullOrEmpty(RankID) && !String.IsNullOrEmpty(Salary) && !String.IsNullOrEmpty(Description);
        }
        public bool LoadFromDB(string RankID)
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT `RankID`, `Description`, `Salary`, `isSenior` FROM `tblStaffRank` {gWHERE}",new int[] {0,1,2,3 })[0];
                this.RankID = Row[0];
                this.Description = Row[1];
                this.Salary = Row[2];
                this.isSenior = Row[3];
                return isFilled();
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
        public bool DeleteSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"DELETE FROM `tblStaffRank` {gWHERE}") > 0;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
        public bool InsertSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"INSERT INTO `tblStaffRank`(`Description`, `Salary`, `isSenior`) VALUES ('{Description}',{Salary:F2},{isSenior})")>0 ;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
        public bool UpdateSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"UPDATE `tblStaffRank` SET `Description`='{Description}',`Salary`={Salary:F2},`isSenior`={isSenior} {gWHERE}") > 0;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }

    }
}
