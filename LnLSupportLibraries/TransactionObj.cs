//Manuel A Nunes 34551875
using System;
using NSDataModule;
using PaymentObjAndUtil;

namespace TranscationUtils
{
    public class TransactionObj
    {
        public string TranscationID, Amount, Reason, DateOfTransaction;
        public PaymentMethodObj Payment;
        public TransactionObj() { }
        public TransactionObj(string TranscationID,string Amount, string Reason, string DateOfTransaction, PaymentMethodObj Payment) 
        {
            this.TranscationID = TranscationID;
            this.Amount = Amount;
            this.Reason = Reason;
            this.DateOfTransaction = DateOfTransaction;
            this.Payment = Payment;
        }
        public bool isFilled()
        {
            return !String.IsNullOrEmpty(TranscationID)&&!String.IsNullOrEmpty(Amount)&& Payment.isFilled();
        }
        public bool LoadFromDB(string TracID)
        {
            try
            {
                string[] Data = DataModule.GetValues($"SELECT TransactionID, Amount, Reason, DateOfTransaction, MethodID FROM tblTransaction WHERE TransactionID = {TracID}",new int[] { 0,1,2,3,4})[0];
                this.TranscationID = Data[0];
                this.Amount = Data[1];
                this.Reason = Data[2];
                this.DateOfTransaction = Data[3];
                this.Payment = new PaymentMethodObj();
                this.Payment.LoadFromDB(Data[4]);
                return isFilled();
            }
            catch (Exception E)
            {

                throw new Exception(E.ToString());
            }
        }

        public bool UpdateSelf()
        {
            try
            {
                return DataModule.ExecuteSQL($"UPDATE tblTransaction SET Amount={this.Amount:F2},Reason='{this.Reason}'," +
                    $"DateOfTransaction='{this.DateOfTransaction:yyyy-MM-dd}',MethodID={this.Payment.ID} WHERE 1")>0;
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
                return DataModule.ExecuteSQL($"INSERT INTO tblTransaction(Amount, Reason, DateOfTransaction, MethodID) VALUES " +
                    $"({this.Amount:F2},'{this.Reason}','{DateOfTransaction:yyyy-MM-dd}',{this.Payment.ID})") > 0;
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
                return DataModule.ExecuteSQL($"DELETE FROM `tblTransaction` WHERE TransactionID = {this.TranscationID}")>0;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
    }
}
