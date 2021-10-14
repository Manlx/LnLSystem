//Manuel A Nunes 34551875
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NSDataModule;
using BankObjAndUtil;
using StaffObjAndUtils;

namespace StaffBankObjUtil
{
    public class StaffBankObj
    {
        private string gWHERE { get { return $"WHERE (StaffID = {Staff.StaffID})AND (BankID = {Bank.BankID})"; } set { gWHERE = value; } }
        public StaffObj Staff;
        public BankObj Bank;
        public string BranchNumber, AccountNumber;

        public StaffBankObj()
        {
        }

        public StaffBankObj(StaffObj staff, BankObj bank, string branchNumber, string accountNumber)
        {
            Staff = staff;
            Bank = bank;
            BranchNumber = branchNumber;
            AccountNumber = accountNumber;
        }
        public bool isFilled()
        {
            return Staff.IsValid() && Bank.isFilled() && !String.IsNullOrEmpty(AccountNumber) && !String.IsNullOrEmpty(BranchNumber);
        }
        public bool LoadFromDB(string StaffID, string BankID)
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT `StaffID`, `BankID`, `BranchNumber`, `AccountNumber` FROM `tblStaffBank` {gWHERE}",new int[] { 0,1,2,3})[0];
                Staff = new StaffObj();
                Staff.LoadFromDB(Row[0]);
                this.Bank = new BankObj();
                Bank.LoadFromDB(Row[1]);
                this.BranchNumber = Row[2];
                this.AccountNumber = Row[3];
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
                return DataModule.ExecuteSQL($"DELETE FROM `tblStaffBank` {gWHERE}")>0;
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
                return DataModule.ExecuteSQL($"INSERT INTO `tblStaffBank`(`StaffID`, `BankID`, `BranchNumber`, `AccountNumber`) VALUES ({Staff.StaffID},{Bank.BankID},'{BranchNumber}','{AccountNumber}')")>0;
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
                return DataModule.ExecuteSQL($"UPDATE `tblStaffBank` SET `StaffID`={Staff.StaffID},`BankID`={Bank.BankID},`BranchNumber`='{BranchNumber}',`AccountNumber`={AccountNumber} {gWHERE}")>0;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
    }
}
