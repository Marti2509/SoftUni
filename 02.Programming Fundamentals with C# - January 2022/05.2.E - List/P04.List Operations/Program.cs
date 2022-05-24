using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            string action = command.Split(' ')[0];

            while (action != "End")
            {
                if (action == "Add")
                {
                    int number = int.Parse(command.Split(' ')[1]);

                    list.Add(number);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(command.Split(' ')[1]);

                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Insert")
                {
                    int number1 = int.Parse(command.Split(' ')[1]);
                    int index = int.Parse(command.Split(' ')[2]);

                    if (index >= 0 && index < list.Count)
                    {
                        list.Insert(index, number1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Shift")
                {
                    string action2 = command.Split(' ')[1];
                    int n = int.Parse(command.Split(' ')[2]);

                    if (action2 == "left")
                    {
                        for (int i = 0; i < n; i++)
                        {
                            int firstNum = list[0];

                            list.RemoveAt(0);

                            list.Add(firstNum);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            int lastNum = list[list.Count - 1];

                            list.RemoveAt(list.Count - 1);

                            list.Insert(0, lastNum);
                        }
                    }
                }

                command = Console.ReadLine();
                action = command.Split(' ')[0];
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
