using System;

namespace _03.Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentBalance = double.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();
            var totalSpent = 0.0;
            var boughtGame = false;
            while (gameName != "Game Time")
            {
                switch (gameName)
                {
                    case "OutFall 4":
                        if (currentBalance >= 39.99)
                        {
                            if (currentBalance == 39.99)
                            {
                                Console.WriteLine($"Bought {gameName}");
                                Console.WriteLine("Out of money!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Bought {gameName}");
                                totalSpent += 39.99;
                                boughtGame = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (currentBalance >= 15.99)
                        {
                            if (currentBalance == 15.99)
                            {
                                Console.WriteLine($"Bought {gameName}");
                                Console.WriteLine("Out of money!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Bought {gameName}");
                                totalSpent += 15.99;
                                boughtGame = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalance >= 19.99)
                        {
                            if (currentBalance == 19.99)
                            {
                                Console.WriteLine($"Bought {gameName}");
                                Console.WriteLine("Out of money!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Bought {gameName}");
                                totalSpent += 19.99;
                                boughtGame = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (currentBalance >= 59.99)
                        {
                            if (currentBalance == 59.99)
                            {
                                Console.WriteLine($"Bought {gameName}");
                                Console.WriteLine("Out of money!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Bought {gameName}");
                                totalSpent += 59.99;
                                boughtGame = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (currentBalance >= 29.99)
                        {
                            if (currentBalance == 29.99)
                            {
                                Console.WriteLine($"Bought {gameName}");
                                Console.WriteLine("Out of money!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Bought {gameName}");
                                totalSpent += 29.99;
                                boughtGame = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalance >= 39.99)
                        {
                            if (currentBalance == 39.99)
                            {
                                Console.WriteLine($"Bought {gameName}");
                                Console.WriteLine("Out of money!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Bought {gameName}");
                                totalSpent += 39.99;
                                boughtGame = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                gameName = Console.ReadLine();
            }
            if (boughtGame)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${(currentBalance - totalSpent):f2}");
            }
        }
    }
}
