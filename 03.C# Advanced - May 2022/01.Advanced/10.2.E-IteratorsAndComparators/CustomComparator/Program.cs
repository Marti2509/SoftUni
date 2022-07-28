using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            Func<int, int, int> sortFunction = (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1 : (x % 2 != 0 && y % 2 == 0) ? 1 : x > y ? 1 : x < y ? -1 : 0;

            numbers.Sort((x, y) => sortFunction(x, y));
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
