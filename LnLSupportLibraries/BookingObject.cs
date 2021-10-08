//M Tolmay 33784507 Manuel A Nunes 34551875
using NSDataModule;
namespace BookingUtil
{
    public class BookingObject
    {
        public string BookingID, DateOfBooking, TimeOfBooking, Location, ClientID, EventType;
        public BookingObject() { }


        public BookingObject(string bookingID, string dateOfBooking, string timeOfBooking, string location, string clientID, string eventType)
        {
            BookingID = bookingID;
            DateOfBooking = dateOfBooking;
            TimeOfBooking = timeOfBooking;
            Location = location;
            ClientID = clientID;
            EventType = eventType;
        }
        public bool LoadFromDB(string BookingID)
        {
            try
            {
                string[][] Data = DataModule.GetValues($"SELECT EventID,DATE_FORMAT(DateOfBooking,'%Y-%m-%d'),TIME_FORMAT( TimeOfBooking,'%H:%i'),LocationID,ClientID,EventType FROM tblEvent WHERE EventID = {BookingID} ", new int[] {0,1,2,3,4,5});
                foreach(string[] Row in Data)
                {
                    BookingID = Row[0];
                    DateOfBooking = Row[1];
                    TimeOfBooking = Row[2];
                    Location = Row[3];
                    ClientID = Row[4];
                    EventType = Row[5];
                }
                return true;
            }
            catch (System.Exception)
            {
                return false;
                throw;
            }

        }
        public string toString()
        {
            return $"Info: {DateOfBooking,-11} {TimeOfBooking,-8} {Location,-5} {EventType,-5}";
        }
        public bool UpdateSelfInEvent()
        {
            try
            {
                return DataModule.ExecuteSQL($"UPDATE tblEvent SET DateOfBooking = '{DateOfBooking}', TimeOfBooking= '{TimeOfBooking}', " +
                    $"LocationID = {Location}, ClientID = {ClientID},EventType = {EventType} FROM tblEvent WHERE EventID = {BookingID}") > 0;
            }
            catch
            {
                return false;
                throw;
            }
        }
        public string[] MoveToEventTable()
        {
            string Delete = $"DELETE FROM tblBooking WHERE BookingID = {BookingID}";
            string InsertToConfirmed = $"INSERT INTO tblEvent (DateOfBooking,TimeOfBooking,LocationID,ClientID,EventType) VALUES (" +
                $"'{DateOfBooking}','{TimeOfBooking}',{Location},{ClientID},{EventType})";
            return new string[2] { Delete,InsertToConfirmed};
        }
    }
}
