//Manuel A Nunes 34551875
using System;
using NSDataModule;
using BankObjAndUtil;
using SupplierAndUtils;
namespace SupplierBankUtils
{
    public class SupplierBankObj
    {
        public BankObj Bank;
        public SupplierObj Supplier;
        public string BankBranch, AccountNumber;
        public SupplierBankObj() { }
        public SupplierBankObj(BankObj Bank, SupplierObj Supplier,string BankBranch,string AccountNumber)
        {
            this.Bank = Bank;
            this.Supplier = Supplier;
            this.BankBranch = BankBranch;
            this.AccountNumber = AccountNumber;
        }
        public bool isFilled()
        {
            return !String.IsNullOrEmpty(BankBranch) && !String.IsNullOrEmpty(AccountNumber);
        }
        public bool LoadFromDB(string BankID, string SupplierID)
        {
            try
            {
                this.Bank = new BankObj();
                this.Bank.LoadFromDB(BankID);
                this.Supplier = new SupplierObj();
                this.Supplier.LoadFromDB(SupplierID);
                string[] Row = DataModule.GetValues($"SELECT BankBranch, AccountNumber FROM tblSupplierBank WHERE (BankID = {Bank.BankID}) AND (SupplierID = {Supplier.SupplierID})", new int[] { 0, 1 })[0];
                this.BankBranch = Row[0];
                this.AccountNumber = Row[1];
                return isFilled();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool InsertSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"INSERT INTO tblSupplierBank (SupplierID,BankID,BankBranch,AccountNumber) VALUES ({Supplier.SupplierID},{Bank.BankID},'{BankBranch}','{AccountNumber}') ") > 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool LoadFromDB(BankObj Bank, SupplierObj Supplier)
        {
            try
            {
                this.Bank = Bank;
                this.Supplier = Supplier;
                string[] Row = DataModule.GetValues($"SELECT BankBranch, AccountNumber FROM tblSupplierBank WHERE (BankID = {Bank.BankID}) AND (SupplierID = {Supplier.SupplierID})",new int[] {0,1 })[0];
                this.BankBranch = Row[0];
                this.AccountNumber = Row[1];
                return isFilled();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
