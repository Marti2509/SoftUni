using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] route = Console.ReadLine().Split("||").ToArray();
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < route.Length; i++)
            {
                List<string> command = route[i].Split(' ').ToList();

                if (command[0] == "Travel")
                {
                    int lightYears = int.Parse(command[1]);

                    if (lightYears <= fuel)
                    {
                        Console.WriteLine($"The spaceship travelled {lightYears} light-years.");

                        fuel -= lightYears;
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command[0] == "Enemy")
                {
                    int enemyPoint = int.Parse(command[1]);

                    if (ammunition >= enemyPoint)
                    {
                        ammunition -= enemyPoint;

                        Console.WriteLine($"An enemy with {enemyPoint} armour is defeated.");
                    }
                    else
                    {
                        if (fuel > enemyPoint * 2)
                        {
                            fuel -= enemyPoint * 2;
                            Console.WriteLine($"An enemy with {enemyPoint} armour is outmaneuvered.");
                        }
                        else
                        {
                        Console.WriteLine("Mission failed.");
                        return;
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    int add = int.Parse(command[1]);

                    ammunition += (add * 2);
                    Console.WriteLine($"Ammunitions added: {add * 2}.");

                    fuel += add;
                    Console.WriteLine($"Fuel added: {add}.");
                }
                else if (command[0] == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }
            }
        }
    }
}
