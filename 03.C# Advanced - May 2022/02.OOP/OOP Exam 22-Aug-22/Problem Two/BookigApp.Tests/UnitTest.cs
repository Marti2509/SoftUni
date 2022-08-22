using FrontDeskApp;
using NUnit.Framework;
using System;

namespace BookigApp.Tests
{
    public class Tests
    {
        [TestCase("ime", 3)]
        public void TestCtor1(string name, int star)
        {
            Hotel hotel = new Hotel(name, star);

            Assert.That(hotel.FullName, Is.EqualTo(name));
        }

        [TestCase("ime", 3)]
        public void TestCtor2(string name, int star)
        {
            Hotel hotel = new Hotel(name, star);

            Assert.That(hotel.Category, Is.EqualTo(star));
        }

        [TestCase(" ", 3)]
        [TestCase(null, 3)]
        public void TestCtor3(string name, int star)
        {
            Hotel hotel;

            Assert.Throws<ArgumentNullException>(() => hotel = new Hotel(name, star));
        }

        [TestCase("ime", -1)]
        [TestCase("ime", 8)]
        public void TestCtor4(string name, int star)
        {
            Hotel hotel;

            Assert.Throws<ArgumentException>(() => hotel = new Hotel(name, star));
        }

        [Test]
        public void TestAddRoom1()
        {
            Hotel hotel = new Hotel("ime", 3);
            hotel.AddRoom(new Room(2, 15));

            Assert.That(hotel.Rooms.Count, Is.EqualTo(1));
        }

        [Test]
        public void TestMakeBook1()
        {
            Hotel hotel = new Hotel("ime", 3);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(-1, 1, 2, 7000));
        }

        [Test]
        public void TestMakeBook2()
        {
            Hotel hotel = new Hotel("ime", 3);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(1, -1, 2, 7000));
        }

        [Test]
        public void TestMakeBook3()
        {
            Hotel hotel = new Hotel("ime", 3);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(1, 1, -1, 7000));
        }

        [Test]
        public void TestMakeBook4()
        {
            Hotel hotel = new Hotel("ime", 3);
            hotel.AddRoom(new Room(2, 15));
            hotel.BookRoom(1, 1, 3, 7000);

            Assert.That(hotel.Bookings.Count == 1);
        }

        [Test]
        public void TestRoomBookRoomWithValidData()
        {
            Hotel hotel = new Hotel("Prince", 4);
            Room room = new Room(3, 10);
            hotel.AddRoom(room);
            hotel.BookRoom(1, 1, 10, 1000);
            Assert.AreEqual(1, hotel.Bookings.Count);
            Assert.AreEqual(100, hotel.Turnover);
        }

        //[Test]
        //public void TestRoomConstructorWithValidData()
        //{
        //    Room room = new Room(3, 151.60);
        //    Assert.IsNotNull(room);
        //}

        //[Test]
        //public void TestRoomBedCapacityWithInvalidData()
        //{
        //    Assert.Throws<ArgumentException>(() => new Room(0, 100.0));
        //}

        //[Test]
        //public void TestRoomPricePerNightWithInvalidData()
        //{
        //    Assert.Throws<ArgumentException>(() => new Room(2, 0));
        //}
    }
}