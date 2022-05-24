using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            string action = command.Split(' ')[0];

            while (action != "end")
            {
                if (action == "Delete")
                {
                    int number = int.Parse(command.Split(' ')[1]);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == number)
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                else if (action == "Insert")
                {
                    int number1 = int.Parse(command.Split(' ')[1]);
                    int number2 = int.Parse(command.Split(' ')[2]);

                    list.Insert(number2, number1);
                }

                command = Console.ReadLine();

                action = command.Split(' ')[0];
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
