namespace BookingApp.Models.Rooms
{
    using System;
    using Contracts;
    using Utilities.Messages;
    public abstract class Room : IRoom
    {
        private int bedCapacity;

        private double pricePerNight;

        protected Room(int bedCapacity)
        {
            BedCapacity = bedCapacity;
            PricePerNight = 0;
        }

        public int BedCapacity
        {
            get
            {
                return bedCapacity;
            }
            private set
            {
                bedCapacity = value;
            }
        }

        public double PricePerNight
        {
            get
            {
                return pricePerNight;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.PricePerNightNegative);
                }
                pricePerNight = value;
            }
        }

        public void SetPrice(double price)
        {
            PricePerNight = price;
        }
    }
}
