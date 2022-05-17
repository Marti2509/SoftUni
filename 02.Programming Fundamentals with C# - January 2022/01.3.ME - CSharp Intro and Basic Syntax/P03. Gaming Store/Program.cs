using System;

namespace P03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());

            decimal currentBalance = 0m;

            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                if (game == "OutFall 4")
                {
                    if (balance >= 39.99m)
                    {
                        Console.WriteLine($"Bought {game}");
                        currentBalance += 39.99m;
                        balance -= 39.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "CS: OG")
                {
                    if (balance >= 15.99m)
                    {
                        Console.WriteLine($"Bought {game}");
                        currentBalance += 15.99m;
                        balance -= 15.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (balance >= 19.99m)
                    {
                        Console.WriteLine($"Bought {game}");
                        currentBalance += 19.99m;
                        balance -= 19.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "Honored 2")
                {
                    if (balance >= 59.99m)
                    {
                        Console.WriteLine($"Bought {game}");
                        currentBalance += 59.99m;
                        balance -= 59.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (balance >= 29.99m)
                    {
                        Console.WriteLine($"Bought {game}");
                        currentBalance += 29.99m;
                        balance -= 29.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (balance >= 39.99m)
                    {
                        Console.WriteLine($"Bought {game}");
                        currentBalance += 39.99m;
                        balance -= 39.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${currentBalance:f2}. Remaining: ${balance:f2}");
        }
    }
}
