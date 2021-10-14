//Manuel A Nunes 34551875
using System;
using NSDataModule;
using SupplierAndUtils;
using StockAndUtils;
using TranscationUtils;

namespace OrderObjUtils
{
    public class OrderObj
    {
        public string OrderID, Quantity, DateOfCommision;
        public SupplierObj Supplier;
        public StockObj Stock;
        public TransactionObj Transcation;
        public OrderObj() { }

        public OrderObj(string orderID, string quantity, string dateOfCommision, SupplierObj supplier, StockObj stock, TransactionObj transcation)
        {
            OrderID = orderID;
            Quantity = quantity;
            DateOfCommision = dateOfCommision;
            Supplier = supplier;
            Stock = stock;
            Transcation = transcation;
        }
        public bool isValid()
        {
            return Transcation.isFilled() && Stock.isFilled() && Supplier.isFilled() && !String.IsNullOrEmpty(OrderID);
        }
        public bool LoadFromDB(string OrderID )
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT OrderID, Quantity, SupplierID, StockID, DateOfCommision, TransactionID FROM tblOrder WHERE OrderID = {OrderID}",new int[] {0,1,2,3,4,5 })[0];
                this.OrderID = Row[0];
                this.Quantity = Row[1];
                this.Supplier = new SupplierObj();
                this.Supplier.LoadFromDB(Row[2]);
                this.Stock = new StockObj();
                this.Stock.LoadFromDB(Row[3]);
                this.DateOfCommision = Row[4];
                this.Transcation = new TransactionObj();
                this.Transcation.LoadFromDB(Row[5]);
                return isValid();
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
                return DataModule.ExecuteSQL($"DELETE FROM tblOrder WHERE OrderID = {this.OrderID}") > 0;
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
                return DataModule.ExecuteSQL($"UPDATE tblOrder SET OrderID={OrderID},Quantity={Quantity:F2},SupplierID={this.Supplier.SupplierID}," +
                    $" StockID={this.Stock.StockID},DateOfCommision='{DateOfCommision:yyyy-MM-dd}',TransactionID={this.Transcation.TranscationID} WHERE OrderID= {OrderID}") > 0;
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
                return DataModule.ExecuteSQL($"INSERT INTO tblOrder(Quantity, SupplierID, StockID, DateOfCommision, TransactionID)" +
                    $" VALUES ({this.Quantity},{this.Supplier.SupplierID},{this.Stock.StockID},'{this.DateOfCommision:yyyy-MM-dd}',{this.Transcation.TranscationID})")>0;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
    }
}
