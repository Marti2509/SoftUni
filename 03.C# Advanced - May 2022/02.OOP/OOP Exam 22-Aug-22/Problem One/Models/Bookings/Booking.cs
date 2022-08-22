using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Bookings
{
    public class Booking : IBooking
    {
        private readonly IRoom room;
        private int residenceDuration;
        private int adultsCount;
        private int childrenCount;
        private int bookingNumber;

        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {
            this.room = room;
            this.residenceDuration = residenceDuration;
            this.adultsCount = adultsCount;
            this.childrenCount = childrenCount;
            this.bookingNumber = bookingNumber;
        }

        public IRoom Room => this.room;

        public int ResidenceDuration
        {
            get => this.residenceDuration;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.DurationZeroOrLess);
                }

                this.residenceDuration = value;
            }
        }

        public int AdultsCount
        {
            get => this.adultsCount;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.AdultsZeroOrLess);
                }

                this.adultsCount = value;
            }
        }

        public int ChildrenCount
        {
            get => this.childrenCount;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.ChildrenNegative);
                }

                this.childrenCount = value;
            }
        }

        public int BookingNumber
        {
            get => this.bookingNumber;
            private set => this.bookingNumber = value;
        }

        public string BookingSummary()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Booking number: {BookingNumber}");
            sb.AppendLine($"Room type: {room.GetType().Name}");
            sb.AppendLine($"Adults: {AdultsCount} Children: {ChildrenCount}");
            sb.AppendLine($"Total amount paid: {TotalPaid():F2} $");

            return sb.ToString().TrimEnd();
        }

        private double TotalPaid()
        {
            double sum = Math.Round(ResidenceDuration * this.room.PricePerNight, 2);

            if (sum <= 0.00)
            {
                return 0.00;
            }

            return sum;
        }
    }
}
