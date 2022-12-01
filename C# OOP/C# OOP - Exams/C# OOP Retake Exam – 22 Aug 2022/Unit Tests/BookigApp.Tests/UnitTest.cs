using FrontDeskApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BookigApp.Tests
{
    public class Tests
    {
        private Room room;

        private Booking booking;

        private Hotel hotel;

        [SetUp]
        public void Setup()
        {
            room = new Room(2, 10);

            booking = new Booking(1, room, 6);

            hotel = new Hotel("Hotel Choki", 3);
        }

        [Test]
        public void If_Hotel_Constructor_Works()
        {
            Assert.AreEqual("Hotel Choki", hotel.FullName);

            Assert.AreEqual(3, hotel.Category);

            Assert.IsNotNull(hotel.Rooms);

            Assert.IsNotNull(hotel.Bookings);
        }

        [Test]
        public void If_Booking_Constructor_Works()
        {
            Assert.AreEqual(1, booking.BookingNumber);

            Assert.AreSame(room, booking.Room);

            Assert.AreEqual(6, booking.ResidenceDuration);
        }

        [Test]
        public void If_Room_Constructor_Works()
        {
            Assert.AreEqual(2, room.BedCapacity);

            Assert.AreEqual(10, room.PricePerNight);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void If_BedCapacity_Works(int value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                room = new Room(value, 10);
            });
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(double.MinValue)]
        public void If_PricePerNight_Works(double value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                room = new Room(2, value);
            });
        }

        [TestCase(-1)]
        [TestCase(20)]
        [TestCase(int.MaxValue)]
        public void If_Category_Works(int value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel = new Hotel("Ceci Paradise", value);
            });
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void If_FullName_Works(string value)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                hotel = new Hotel(value, 5);
            });
        }
        [Test]
        public void If_Add_Method_Works()
        {
            hotel.AddRoom(room);

            List<Room> roomsSecond = new List<Room>() { room };

            CollectionAssert.AreEqual(roomsSecond, hotel.Rooms);

            CollectionAssert.AreEquivalent(roomsSecond, hotel.Rooms);

            Assert.AreEqual(1, hotel.Rooms.Count);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void If_BookRoom_Method_Works_With_Adults(int value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(value, 2, 4, 1.5);
            });
        }

        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void If_BookRoom_Method_Works_With_Children(int value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(2, value, 3, 2.5);
            });
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void If_BookRoom_Method_Works_With_Duration(int value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(2, 4, value, 3.5);
            });
        }

        [Test]
        public void If_BookRoom_Method_Should_Work()
        {
            Room firstRoom = new Room(4, 5);

            hotel.AddRoom(firstRoom);

            hotel.BookRoom(2, 2, 5, 2000);

            Assert.AreEqual(1,hotel.Bookings.Count);

            Assert.AreEqual(25, hotel.Turnover);
        }
    }
}