using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.List_Manipulation_Advanced
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

            string[] line = command.Split(" ");
            string action = line[0];


            while (command != "end")
            {
                line = command.Split(" ");
                action = line[0];

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
                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(line[1]);
                    int index = int.Parse(line[2]);
                    numbers.Insert(index, numberToInsert);
                }
                else if (action == "Contains")
                {
                    int number = int.Parse(line[1]);
                    
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNums = new List<int>();

                    foreach (int item in numbers)
                    {
                        if (item % 2 == 0)
                        {
                            evenNums.Add(item);
                        }
                    }

                    Console.WriteLine(string.Join(' ', evenNums));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNums = new List<int>();

                    foreach (int item in numbers)
                    {
                        if (item % 2 == 1)
                        {
                            oddNums.Add(item);
                        }
                    }

                    Console.WriteLine(string.Join(' ', oddNums));
                }
                else if(action == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else
                {
                    string condition = line[1];
                    int number = int.Parse(line[2]);

                    if (condition == ">")
                    {
                        List<int> nums = numbers.FindAll(x => x > number);

                        Console.WriteLine(string.Join(' ', nums));
                    }
                    else if (condition == "<")
                    {
                        List<int> nums = numbers.FindAll(x => x < number);
                        Console.WriteLine(string.Join(' ', nums));
                    }
                    else if (condition == ">=")
                    {
                        List<int> nums = numbers.FindAll(x => x >= number);
                        Console.WriteLine(string.Join(' ', nums));
                    }
                    else
                    {
                        List<int> nums = numbers.FindAll(x => x <= number);
                        Console.WriteLine(string.Join(' ', nums));
                    }
                }

                command = Console.ReadLine();
            }

            if (action == "Add" || 
                action == "Remove" || 
                action == "RemoveAt" || 
                action == "Insert")
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
