using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, uint> counter = new Dictionary<char, uint>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                counter.TryAdd(input[i], 0);
                counter[input[i]]++;
            }

            foreach (var item in counter.OrderBy(x => x.Key).ToArray())
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
