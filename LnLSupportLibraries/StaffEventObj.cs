//Manuel A Nunes 34551875
using System;

using NSDataModule;
using StaffObjAndUtils;
using BookingUtil;

namespace StaffEventObjUtil
{
    public class StaffEventObj
    {
        public BookingObject Event;
        public StaffObj Staff;
        public StaffEventObj() { }

        public StaffEventObj(BookingObject @event, StaffObj staff)
        {
            Event = @event;
            Staff = staff;
        }
        public bool isFilled()
        {
            return this.Staff.IsValid() && this.Event.isFilled();
        }
        public bool LoadFromDB(string StaffID, string EventID)
        {
            try
            {
                this.Staff = new StaffObj();
                this.Staff.LoadFromDB(StaffID);
                this.Event = new BookingObject();
                this.Event.LoadFromDB(EventID);
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
                return DataModule.ExecuteSQL($"INSERT INTO tblStaffEvent(StaffID, EventID) VALUES ({Staff.StaffID},{Event.BookingID})")>0;
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
                return DataModule.ExecuteSQL($"DELETE FROM tblStaffEvent WHERE (StaffID = {Staff.StaffID}) AND (EventID = {Event.BookingID})") > 0;
            }
            catch (Exception E)
            {
                return false;
                throw E;
            }
        }
    }
}
