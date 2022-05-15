using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double priceForOne = 0;

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    priceForOne = 8.45;
                }
                else if (type == "Busness")
                {
                    priceForOne = 10.90;
                }
                else if (type == "Regular")
                {
                    priceForOne = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    priceForOne = 9.80;
                }
                else if (type == "Busness")
                {
                    priceForOne = 15.60;
                }
                else if (type == "Regular")
                {
                    priceForOne = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    priceForOne = 10.46;
                }
                else if (type == "Busness")
                {
                    priceForOne = 16;
                }
                else if (type == "Regular")
                {
                    priceForOne = 22.50;
                }
            }

            double price = double.Parse(Console.ReadLine());

            if (people >= 30)
            {
                price = priceForOne * people - (price * 0.15);
            }
            else if (people >= 100)
            {
                price = priceForOne * people - (priceForOne * 10);
            }
            else if (people >= 10 && people <= 20)
            {
                price = priceForOne * people - (price * 0.05);
            }

            Console.WriteLine($"Total price {price:f2}");
        }
    }
}
