//Manuel A Nunes 34551875
using System;
using NSDataModule;
namespace SupplierAndUtils
{
    public class SupplierObj
    {
        public string SupplierID, Name, Balance, PhoneNumber, Website, WarehouseContactName;
        public SupplierObj() { }

        public SupplierObj(string supplierID, string name, string balance, string phoneNumber, string website, string warehouseContactName)
        {
            SupplierID = supplierID;
            Name = name;
            Balance = balance;
            PhoneNumber = phoneNumber;
            Website = website;
            WarehouseContactName = warehouseContactName;
        }
        public bool isFilled()
        {
            return (SupplierID != "");
        }
        public bool InsertSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"INSERT INTO tblSupplier (Name,Balance,PhoneNumber,Website,WarehouseContactName) " +
                    $"VALUES ('{Name}',{Balance:F2},'{PhoneNumber}','{Website}','{WarehouseContactName}') ") > 0;
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
                return DataModule.ExecuteSQL($"UPDATE SET tblSupplier Name = '{Name}',Balance = {Balance:F2},PhoneNumber = '{PhoneNumber}',Website = '{Website}',WarehouseContactName = '{WarehouseContactName}' WHERE SupplierID = {SupplierID}")>0 ;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool LoadFromDB(string SupplierID)
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT SupplierID,Name,Balance,PhoneNumber,Website,WarehouseContactName FROM tblSupplier WHERE SupplierID = {SupplierID}",new int[] {0,1,2,3,4,5 })[0];
                if (Row.Length <= 0)
                    return false;
                this.SupplierID = Row[0];
                this.Name = Row[1];
                this.Balance = Row[2];
                this.PhoneNumber = Row[3];
                this.Website = Row[4];
                this.WarehouseContactName = Row[5];
                return isFilled();
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
                return DataModule.ExecuteSQL($"DELETE FROM tblSupplier WHERE SupplierID = {SupplierID}")>0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
