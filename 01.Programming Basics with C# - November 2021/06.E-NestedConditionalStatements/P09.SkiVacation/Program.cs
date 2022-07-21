using System;

namespace P09.Ski_vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysThere = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            int nights = daysThere - 1;
            double price = 0.0;

            if (room == "room for one person")
            {
                price = nights * 18.00;

                if (rating == "positive")
                {
                    price += price * 0.25;
                }
                else
                {
                    price -= price * 0.10;
                }
            }
            else if (room == "apartment")
            {
                price = nights * 25.00;

                if (daysThere < 10)
                {
                    price -= price * 0.30;
                }
                else if (daysThere <= 15)
                {
                    price -= price * 0.35;
                }
                else
                {
                    price -= price * 0.50;
                }

                if (rating == "positive")
                {
                    price += price * 0.25;
                }
                else
                {
                    price -= price * 0.10;
                }
            }
            else
            {
                price = nights * 35.00;

                if (daysThere < 10)
                {
                    price -= price * 0.10;
                }
                else if (daysThere <= 15)
                {
                    price -= price * 0.15;
                }
                else
                {
                    price -= price * 0.20;
                }

                if (rating == "positive")
                {
                    price += price * 0.25;
                }
                else
                {
                    price -= price * 0.10;
                }
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
