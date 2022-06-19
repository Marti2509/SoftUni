using System;
using System.Linq;

namespace P03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int minNum = int.MaxValue;

            Func<int, bool> func = x => x < minNum;

            foreach (int number in numbers)
            {
                if (func(number))
                {
                    minNum = number;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
