using System;

namespace P04.Fishing_boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }

            if (fishers <= 6)
            {
                price = price - price * 0.10;
            }
            else if (fishers <= 11)
            {
                price = price - price * 0.15;
            }
            else if (fishers > 12)
            {
                price = price - price * 0.25;
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                price = price - price * 0.05;
            }

            if (buget >= price)
            {
                Console.WriteLine($"Yes! You have {(buget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - buget):f2} leva.");
            }
        }
    }
}
