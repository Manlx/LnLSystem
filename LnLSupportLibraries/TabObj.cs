//Manuel A Nunes 345518175
using System;
using NSDataModule;

namespace TabObjAndUtil
{
    public class TabObj
    {
        public string TabID, ClientID;
        public double Balance, CutOffValue;
        public TabObj() { }
        public bool LoadFromDB(string ClientID)
        {
            if (!int.TryParse(ClientID, out int Temp))
                return false;
            try
            {
                string[][] Data = DataModule.GetValues($"SELECT TabID,ClientID,Balance,CutOffValue FROM tblTab WHERE ClientID = {Temp}", new int[] { 0, 1, 2, 3 });
                foreach (string[] Row in Data)
                {
                    TabID = Row[0];
                    this.ClientID = Row[1];
                    if (!Double.TryParse(Row[2], out Balance))
                        return false;
                    if (!Double.TryParse(Row[3], out CutOffValue))
                        return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool AdjustBalance(double Value,out bool QualForCapCrease,out double ChangeAmount)
        {
            try
            {
                if (QualForCapCrease = (Value > this.Balance && this.Balance > this.CutOffValue * 50 / 100))
                    this.CutOffValue += 100;
                if ((ChangeAmount = this.Balance - Value) < 0)
                    this.Balance = 0;
                else
                {
                    this.Balance = ChangeAmount;
                    ChangeAmount *= -1;
                }
                    
                return DataModule.ExecuteSQL($"UPDATE tblTab SET TabID = {TabID}, ClientID= {ClientID}, Balance = " +
                    $"{this.Balance:F2},CutOffValue = {this.CutOffValue:F2} WHERE (TabID = {TabID}) AND (ClientID = {ClientID})") > 0;
            }
            catch (Exception)
            {
                ChangeAmount = -1;
                return QualForCapCrease = false;
                throw;
            }
        }
        public bool IsValid()
        {
            return (TabID != "") && (ClientID != "");
        }
    }
}
