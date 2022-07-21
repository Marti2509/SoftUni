using System;

namespace P07.Hotel_room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartamentPrice = 0;


            if (mounth == "May" || mounth == "October")
            {
                studioPrice = nights * 50;
                apartamentPrice = nights * 65;

                if (nights > 14)
                {
                    apartamentPrice = apartamentPrice - apartamentPrice * 0.10;
                    studioPrice = studioPrice - studioPrice * 0.30;
                }
                else if (nights > 7)
                {
                    studioPrice = studioPrice - studioPrice * 0.05;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                studioPrice = nights * 75.20;
                apartamentPrice = nights * 68.70;

                if (nights > 14)
                {
                    apartamentPrice = apartamentPrice - apartamentPrice * 0.10;
                    studioPrice = studioPrice - studioPrice * 0.20;
                }
            }
            else
            {
                studioPrice = nights * 76;
                apartamentPrice = nights * 77;
                if (nights > 14)
                {
                    apartamentPrice = apartamentPrice - apartamentPrice * 0.10;
                }
            }

            Console.WriteLine($"Apartment: {apartamentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
