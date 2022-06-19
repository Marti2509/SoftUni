using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<int, int> add = x => x + 1;
            Func<int, int> subtract = x => x - 1;
            Func<int, int> multiply = x => x * 2;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end") break;
                else if (command == "add")
                {
                    nums = nums.Select(x => add(x)).ToList();
                }
                else if (command == "subtract")
                {
                    nums = nums.Select(x => subtract(x)).ToList();
                }
                else if (command == "multiply")
                {
                    nums = nums.Select(x => multiply(x)).ToList();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(' ', nums));
                }
            }
        }
    }
}
