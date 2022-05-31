using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Orders
{
    class Amount
    {
        public Amount(decimal price, uint quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public decimal Price { get; set; }
        public uint Quantity { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Amount> products = new Dictionary<string, Amount>();

            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] info = command.Split(' ');

                string name = info[0];
                decimal price = decimal.Parse(info[1]);
                uint quantity = uint.Parse(info[2]);

                if (products.ContainsKey(name))
                {
                    foreach (var item in products)
                    {
                        if (item.Key == name)
                        {
                            item.Value.Price = price;
                            item.Value.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    products.Add(name, new Amount(price, quantity));
                }

                command = Console.ReadLine();
            }

            foreach (var item in products)
            {
                decimal price = item.Value.Price * item.Value.Quantity;

                Console.WriteLine($"{item.Key} -> {price:f2}");
            }
        }
    }
}
