using System;

namespace P05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double price = 0.0;
            string type = "";

            if (buget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = buget * 0.3;
                    type = "Camp";
                }
                else
                {
                    price = buget * 0.7;
                    type = "Hotel";
                }
            }
            else if (buget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = buget * 0.4;
                    type = "Camp";
                }
                else
                {
                    price = buget * 0.8;
                    type = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                type = "Hotel";
                price = buget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
