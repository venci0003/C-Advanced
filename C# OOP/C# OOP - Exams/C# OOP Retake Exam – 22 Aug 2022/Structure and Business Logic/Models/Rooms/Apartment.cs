namespace BookingApp.Models.Rooms
{
    public class Apartment : Room
    {
        private const int CAPACITY_INCREMENT = 6;

        public Apartment() : base(CAPACITY_INCREMENT)
        {
        }
    }
}
