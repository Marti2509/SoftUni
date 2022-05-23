using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] line = command.Split(" ");
                string action = line[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(line[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(line[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(line[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                }
                else
                {
                    int numberToInsert = int.Parse(line[1]);
                    int index = int.Parse(line[2]);
                    numbers.Insert(index, numberToInsert);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
