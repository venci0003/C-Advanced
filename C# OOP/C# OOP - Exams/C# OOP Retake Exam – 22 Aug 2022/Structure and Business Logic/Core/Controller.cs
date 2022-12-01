using BookingApp.Core.Contracts;
using BookingApp.Models.Bookings;
using BookingApp.Models.Hotels;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories;
using BookingApp.Repositories.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BookingApp.Core
{
    public class Controller : IController
    {
        private IRepository<IHotel> hotels;

        public Controller()
        {
            hotels = new HotelRepository();
        }

        public string AddHotel(string hotelName, int category)
        {

            IHotel hotel = hotels.Select(hotelName);

            if (hotel != null)
            {
                return string.Format(OutputMessages.HotelAlreadyRegistered, hotelName);
            }
            else
            {
                hotel = new Hotel(hotelName, category);

                hotels.AddNew(hotel);

                return string.Format(OutputMessages.HotelSuccessfullyRegistered, category, hotelName);
            }
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            List<IHotel> secondHotel = hotels.All().Where(h => h.Category == category).OrderBy(h => h.FullName).ToList();

            if (secondHotel.Count == 0)
            {
                return string.Format(OutputMessages.CategoryInvalid, category);
            }

            foreach (IHotel hotel in secondHotel)
            {
                foreach (IRoom room in hotel.Rooms.All().Where(h => h.PricePerNight > 0).OrderBy(r => r.BedCapacity))
                {
                    if (room.BedCapacity >= adults + children)
                    {

                        int bookingNumber = hotel.Bookings.All().Count + 1;

                        hotel.Bookings.AddNew(new Booking(room, duration, adults, children, bookingNumber));

                        return string.Format(OutputMessages.BookingSuccessful, bookingNumber, hotel.FullName);
                    }
                }
            }
            return string.Format(OutputMessages.RoomNotAppropriate);
        }

        public string HotelReport(string hotelName)
        {
            IHotel hotel = hotels.Select(hotelName);

            if (hotel == null)
            {
                return string.Format(OutputMessages.HotelNameInvalid, hotelName);
            }
            else
            {
                string result = hotel.ToString();

                return result;
            }
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            IHotel hotel = hotels.Select(hotelName);

            if (hotel == null)
            {
                return string.Format(OutputMessages.HotelNameInvalid, hotelName);
            }

            if (!ValidateRoomType(roomTypeName))
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }

            if (hotel.Rooms.Select(roomTypeName) == null)
            {
                return string.Format(OutputMessages.RoomTypeNotCreated);
            }

            IRoom room = hotel.Rooms.Select(roomTypeName);

            if (room.PricePerNight != 0)
            {
                throw new InvalidOperationException(ExceptionMessages.PriceAlreadySet);
            }

            room.SetPrice(price);

            return string.Format(OutputMessages.PriceSetSuccessfully, roomTypeName, hotelName);
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            IHotel hotel = hotels.Select(hotelName);

            if (hotel == null)
            {
                return string.Format(OutputMessages.HotelNameInvalid, hotelName);
            }

            if (hotel.Rooms.Select(roomTypeName) != null)
            {
                return string.Format(OutputMessages.RoomTypeAlreadyCreated);
            }

            if (!ValidateRoomType(roomTypeName))
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }

            IRoom room;

            if (roomTypeName == "Apartment")
            {
                room = new Apartment();
            }
            else if (roomTypeName == "DoubleBed")
            {
                room = new DoubleBed();
            }
            else
            {
                room = new Studio();
            }

            hotel.Rooms.AddNew(room);

            return string.Format(OutputMessages.RoomTypeAdded, roomTypeName, hotelName);
        }


        private bool ValidateRoomType(string roomType)
        {
            Type type = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.BaseType == typeof(Room)).FirstOrDefault(x => x.Name == roomType);

            bool result = type == null ? false : true;
            return result;
        }
    }
}
