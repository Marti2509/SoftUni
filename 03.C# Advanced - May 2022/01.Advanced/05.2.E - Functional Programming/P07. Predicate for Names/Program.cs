using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Predicate<string> isLenght = x => x.Length <= n;

            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => isLenght(x))
                .ToList();

            Console.WriteLine(string.Join('\n', names));
        }
    }
}
