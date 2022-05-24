using System;
using System.Collections.Generic;

namespace P03.House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string name = command.Split(' ')[0];
                string isNot = command.Split(' ')[2];

                if (isNot == "not")
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
            }

            foreach (string name in guestList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
