//Manuel A Nunes 34551875
using System;
using NSDataModule;
namespace PaymentObjAndUtil
{
    public class PaymentMethodObj
    {
        public string ID, Description;
        public PaymentMethodObj() { }
        public PaymentMethodObj(string ID, string Description)
        {
            this.ID = ID;
            this.Description = Description;
        }
        public bool isFilled()
        {
            return ID != "" && Description != "";
        }
        public bool LoadFromDB(string ID)
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT PaymentID,Description FROM tblPaymentMethod WHERE PaymentID = {ID}", new int[] { 0, 1 })[0];
                if (Row.Length <= 0)
                    return false;
                this.ID = Row[0];
                this.Description = Row[1];
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
