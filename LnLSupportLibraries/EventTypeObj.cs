//Manuel A Nunes 34551875
using System;
using NSDataModule;

namespace EventTypeObj
{
    public class EventTypeObj
    {
        public string EventTypeID, Description;
        public EventTypeObj() { }
        public EventTypeObj(string EventTypeID, string Description)
        {
            this.EventTypeID = EventTypeID;
            this.Description = Description;
        }
        public bool isFilled()
        {
            return !String.IsNullOrEmpty(EventTypeID) && !String.IsNullOrEmpty(Description);
        }
        public bool LoadFromDB(string ETID)
        {
            try
            {
                string[] Row = DataModule.GetValues($"SELECT EventType, Description FROM tblEventType WHERE EventType = {ETID}", new int[] { 0, 1 })[0];
                this.EventTypeID = Row[0];
                this.Description = Row[1];
                return isFilled();   
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
                return DataModule.ExecuteSQL($"UPDATE tblEventType SET Description = '{this.Description}' WHERE EventType= {this.EventTypeID}") > 0;
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
                return DataModule.ExecuteSQL($"DELETE FROM tblEventType WHERE EventType= {this.EventTypeID}") > 0;
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
                return DataModule.ExecuteSQL($"INSERT INTO tblEventType  Description VALUES ('{this.Description}')") > 0;
            }
            catch (Exception E)
            {
                return false;
                throw new Exception(E.ToString());
            }
        }
    }
}
