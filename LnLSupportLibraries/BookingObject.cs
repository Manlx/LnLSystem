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
        public string[] MoveToEventTable()
        {
            string Delete = $"DELETE FROM tblBooking WHERE BookingID = {BookingID}";
            string InsertToConfirmed = $"INSERT INTO tblEvent (DateOfBooking,TimeOfBooking,LocationID,ClientID,EventType) VALUES (" +
                $"'{DateOfBooking}','{TimeOfBooking}',{Location},{ClientID},{EventType})";
            return new string[2] { Delete,InsertToConfirmed};
        }
    }
}
