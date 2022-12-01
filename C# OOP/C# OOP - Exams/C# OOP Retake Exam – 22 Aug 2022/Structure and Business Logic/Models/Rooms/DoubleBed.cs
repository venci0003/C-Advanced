namespace BookingApp.Models.Rooms
{
    public class DoubleBed : Room
    {
        private const int CAPACITY_INCREMENT = 2;
        public DoubleBed() : base(CAPACITY_INCREMENT)
        {
        }
    }
}
