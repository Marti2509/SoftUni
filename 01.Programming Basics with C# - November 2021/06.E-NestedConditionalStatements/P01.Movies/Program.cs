using System;

namespace P01.Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double price = 0.0;
            if (projection == "Premiere")
            {
                price = (r * c) * 12.00;
            }
            else if (projection == "Normal")
            {
                price = (c * r) * 7.50;
            }
            else if (projection == "Discount")
            {
                price = (c * r) * 5.00;
            }

            Console.WriteLine($"{price:f2} leva");
        }
    }
}
