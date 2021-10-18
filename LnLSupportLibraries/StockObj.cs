//Manuel A Nunes 34551875
using System;
using NSDataModule;

namespace StockAndUtils
{
    public class StockObj
    {
        public string StockID, StockName, DateAcquired, CostPrice, ProfitMargin, CountInBar, CountInWareHouse;
        public StockObj() { }

        public StockObj(string stockID, string stockName, string dateAcquired, string costPrice, string profitMaring, string countInBar, string countInWareHouse)
        {
            StockID = stockID;
            StockName = stockName;
            DateAcquired = dateAcquired;
            CostPrice = costPrice;
            ProfitMargin = profitMaring;
            CountInBar = countInBar;
            CountInWareHouse = countInWareHouse;
        }
        public bool isFilled()
        {
            return (StockID != "");
        }
        public bool InsertSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"INSERT INTO tblStock (StockName,DateAcquired,CostPrice,ProfitMargin,CountInBar,CountInWarehouse) " +
                    $"VALUES ('{StockName}','{DateAcquired:yyyy-MM-dd}',{CostPrice},{ProfitMargin},{CountInBar},{CountInWareHouse}) ") > 0;
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
                return DataModule.ExecuteSQL($"DELETE FROM `tblStock` WHERE StockID = {StockID}") > 0;
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
                return DataModule.ExecuteSQL($"Update tblStock SET StockName ='{StockName}'," +
                    $"DateAcquired = '{DateTime.Parse(DateAcquired):yyyy-MM-dd}', CostPrice = {CostPrice}, ProfitMargin = {ProfitMargin},CountInBar = {CountInBar}," +
                    $" CountInWarehouse = {CountInWareHouse} WHERE StockID = '{StockID}'") > 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool LoadFromDB(string StockID)
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT StockID,StockName,DateAcquired,CostPrice,ProfitMargin,CountInBar,CountInWarehouse FROM tblStock WHERE StockID = {StockID}", new int[] {0,1,2,3,4,5,6 })[0];
                if (Row.Length <= 0)
                    return false;
                this.StockID = Row[0];
                this.StockName = Row[1];
                this.DateAcquired = Row[2];
                this.CostPrice = Row[3];
                this.ProfitMargin  = Row[4];
                this.CountInBar = Row[5];
                this.CountInWareHouse = Row[6];
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
