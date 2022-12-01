namespace BookingApp.Models.Rooms
{
    public class Studio : Room
    {
        private const int CAPACITY_INCREMENT = 4;
        public Studio() : base(CAPACITY_INCREMENT)
        {
        }
    }
}
