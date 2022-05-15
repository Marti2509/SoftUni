using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();

            double sumOfCoins = 0;

            while (coins != "Start")
            {
                if (double.Parse(coins) != 0.1 &&
                    double.Parse(coins) != 0.2 &&
                    double.Parse(coins) != 0.5 &&
                    double.Parse(coins) != 1 &&
                    double.Parse(coins) != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    sumOfCoins += double.Parse(coins);
                }

                coins = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product != "Nuts" &&
                    product != "Water" &&
                    product != "Crisps" &&
                    product != "Soda" &&
                    product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else if (product == "Nuts")
                {
                    if (sumOfCoins >= 2.0)
                    {
                        Console.WriteLine($"Purchased nuts");
                        sumOfCoins -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (sumOfCoins >= 0.7)
                    {
                        Console.WriteLine($"Purchased water");
                        sumOfCoins -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (sumOfCoins >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        sumOfCoins -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sumOfCoins >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        sumOfCoins -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    if (sumOfCoins >= 1.0)
                    {
                        Console.WriteLine($"Purchased coke");
                        sumOfCoins -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumOfCoins:f2}");
        }
    }
}
