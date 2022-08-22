using BookingApp.Core.Contracts;
using BookingApp.Models.Bookings;
using BookingApp.Models.Bookings.Contracts;
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
using System.Text;

namespace BookingApp.Core
{
    public class Controller : IController
    {
        private readonly HotelRepository hotels;

        public Controller()
        {
            hotels = new HotelRepository();
        }

        public string AddHotel(string hotelName, int category)
        {
            if (hotels.Select(hotelName) == null)
            {
                hotels.AddNew(new Hotel(hotelName, category));
                return $"{category} stars hotel {hotelName} is registered in our platform and expects room availability to be uploaded.";
            }

            return $"Hotel {hotelName} is already registered in our platform.";
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            List<IHotel> hotels = new List<IHotel>();

            foreach (var hotel in this.hotels.All())
            {
                hotels.Add(hotel);
            }

            List<IHotel> orderedHotels = hotels.OrderBy(x => x.FullName).ToList();

            bool flag = true;

            foreach (var hotel1 in orderedHotels)
            {
                if (hotel1.Category == category)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                return $"{category} star hotel is not available in our platform.";
            }

            List<IRoom> rooms = new List<IRoom>();

            foreach (var hotel in orderedHotels)
            {
                foreach (var room in hotel.Rooms.All())
                {
                    if (room.PricePerNight > 0)
                    {
                        rooms.Add(room);
                    }
                }
            }

            rooms = rooms.OrderBy(x => x.BedCapacity).ToList();
            List<IRoom> fitRooms = new List<IRoom>();
            bool flag2 = true;

            foreach (var room in rooms)
            {
                int sum = adults + children;

                if (room.BedCapacity >= sum)
                {
                    flag2 = false;
                    fitRooms.Add(room);
                }
            }

            if (flag2)
            {
                return "We cannot offer appropriate room for your request.";
            }

            IRoom bestRoom = fitRooms[0];
            string hotelName = string.Empty;

            foreach (var hotel in this.hotels.All())
            {
                foreach (var room in hotel.Rooms.All())
                {
                    if (room.Equals(bestRoom))
                    {
                        hotelName = hotel.FullName;
                    }
                }
            }

            int number = this.hotels.Select(hotelName).Bookings.All().Count + 1;

            this.hotels.Select(hotelName).Bookings.AddNew(new Booking(bestRoom, duration, adults, children, number));

            return $"Booking number {number} for {hotelName} hotel is successful!";
        }

        public string HotelReport(string hotelName)
        {
            StringBuilder sb = new StringBuilder();

            if (hotels.Select(hotelName) == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }

            sb.AppendLine($"Hotel name: {hotelName}");
            sb.AppendLine($"--{hotels.Select(hotelName).Category} stars hotel");
            sb.AppendLine($"--Turnover: {hotels.Select(hotelName).Turnover:F2} $");
            sb.AppendLine($"--Bookings:");

            sb.AppendLine();

            if (hotels.Select(hotelName).Bookings.All().Count > 0)
            {
                foreach (var booking in hotels.Select(hotelName).Bookings.All())
                {
                    sb.AppendLine(booking.BookingSummary());
                }

                sb.AppendLine();
            }
            else
            {
                sb.AppendLine("none");
            }

            return sb.ToString().TrimEnd();
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            if (hotels.Select(hotelName) == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            if (roomTypeName != "DoubleBed" && roomTypeName != "Studio" && roomTypeName != "Apartment")
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }
            if (hotels.Select(hotelName).Rooms.Select(roomTypeName) == null)
            {
                return "Room type is not created yet!";
            }
            if (hotels.Select(hotelName).Rooms.Select(roomTypeName).PricePerNight != 0)
            {
                throw new InvalidOperationException(ExceptionMessages.PriceAlreadySet);
            }

            hotels.Select(hotelName).Rooms.Select(roomTypeName).SetPrice(price);
            return $"Price of {roomTypeName} room type in {hotelName} hotel is set!";
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            if (hotels.Select(hotelName) == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            if (roomTypeName != "DoubleBed" && roomTypeName != "Studio" && roomTypeName != "Apartment")
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }
            if (hotels.Select(hotelName).Rooms.All().Any(x => x.GetType().Name == roomTypeName))
            {
                return $"Room type is already created!";
            }

            if (roomTypeName == "DoubleBed")
            {
                hotels.Select(hotelName).Rooms.AddNew(new DoubleBed());
            }
            else if (roomTypeName == "Studio")
            {
                hotels.Select(hotelName).Rooms.AddNew(new Studio());
            }
            else
            {
                hotels.Select(hotelName).Rooms.AddNew(new Apartment());
            }
            return $"Successfully added {roomTypeName} room type in {hotelName} hotel!";
        }
    }
}