//Manuel A Nunes 34551875
using System;
using StockAndUtils;
using TabObjAndUtil;
using NSDataModule;
namespace CreditSaleUtils
{
    public class CreditSaleObj
    {
        public StockObj Stock;
        public TabObj Tab;
        public string Count;
        public CreditSaleObj() { }
        public CreditSaleObj(StockObj Stock,TabObj Tab, int Count)
        {
            this.Stock = Stock;
            this.Tab = Tab;
            this.Count = Count.ToString();
        }
        public bool isFilled()
        {
            return this.Stock.isFilled() && this.Tab.IsValid();
        }
        public bool LoadFromDB(string StockID,string TabID)
        {
            try
            {
                this.Stock = new StockObj();
                this.Stock.LoadFromDB(StockID);
                this.Tab = new TabObj();
                this.Tab.LoadFromDB(TabID);
                this.Count = DataModule.GetValue(0,$"SELECT Count FROM tblCreditSale WHERE (TabID = {this.Tab.TabID}) AND (StockID = {this.Stock.StockID})");
                return this.isFilled();
            }
            catch (Exception E)
            {
                return false;
                throw new Exception(E.ToString());
            }
        }
        public bool DeleteSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"DELETE FROM tblCreditSale WHERE (TabID = {this.Tab.TabID}) AND (StockID = {this.Stock.StockID})") > 0;
            }
            catch (Exception E)
            {
                return false;
                throw new Exception(E.ToString());
            }
        }
        public bool InsertSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"INSERT INTO tblCreditSale VALUE (Count,TabID,StockID) VALUES ({this.Count},{this.Tab.TabID},{this.Stock.StockID})") > 0;
            }
            catch (Exception E)
            {
                return false;
                throw new Exception(E.ToString());
            }
        }
        public bool UpdateSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"UPDATE tblCreditSale SET Count = {this.Count} WHERE (TabID = {this.Tab.TabID}) AND (StockID = {this.Stock.StockID})")>0;
            }
            catch (Exception E)
            {
                return false;
                throw new Exception(E.ToString());
            }
        }
    }
}
