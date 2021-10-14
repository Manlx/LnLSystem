//Manuel A Nunes 34551875
using System;

using NSDataModule;
using SupplierAndUtils;
using StockAndUtils;
namespace SupplierStockObjUtil
{
    public class SupplierStockObj
    {
        public StockObj Stock;
        public SupplierObj Supplier;

        public SupplierStockObj(StockObj stock, SupplierObj supplier)
        {
            Stock = stock;
            Supplier = supplier;
        }
        public SupplierStockObj()
        {
        }
        public bool isFilled()
        {
            return this.Supplier.isFilled() && this.Stock.isFilled();
        }
        public bool LoadFromDB(string StockID, string SupplierID)
        {
            try
            {
                this.Stock = new StockObj();
                this.Stock.LoadFromDB(StockID);
                this.Supplier = new SupplierObj();
                this.Supplier.LoadFromDB(SupplierID);
                return isFilled();
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
                return DataModule.ExecuteSQL($"INSERT INTO `tblSupplierStock`(`StockID`, `SupplierID`) VALUES ({this.Stock.StockID},{this.Supplier.SupplierID})") >0;
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
                return DataModule.ExecuteSQL($"DELETE FROM `tblSupplierStock` WHERE (SupplierID = {this.Supplier.SupplierID}) AND (StockID = {this.Stock.StockID})") > 0;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
    }
}
