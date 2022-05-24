using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int MaxInWagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            string action = command.Split(' ')[0];

            while (action != "end")
            {
                if (action == "Add")
                {
                    wagons.Add(int.Parse(command.Split(' ')[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currWagon = wagons[i];
                        int number = int.Parse(command.Split(' ')[0]);

                        if (currWagon + number <= MaxInWagon)
                        {
                            wagons[i] = currWagon + number;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();

                action = command.Split(' ')[0];
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
