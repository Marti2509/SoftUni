using System;

namespace P03.New_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int buget = int.Parse(Console.ReadLine());

            double price = 0.00;

            if (typeOfFlowers == "Roses")
            {
                price = quantity * 5.00;
                if (quantity > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                price = quantity * 3.80;
                if (quantity > 90)
                {
                    price = price - price * 0.15;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                price = quantity * 2.80;
                if (quantity > 80)
                {
                    price = price - price * 0.15;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                price = quantity * 3.00;
                if (quantity < 120)
                {
                    price = price + price * 0.15;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                price = quantity * 2.50;
                if (quantity < 80)
                {
                    price = price + price * 0.20;
                }
            }

            if (buget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {typeOfFlowers} and {(buget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - buget):f2} leva more.");
            }
        }
    }
}
