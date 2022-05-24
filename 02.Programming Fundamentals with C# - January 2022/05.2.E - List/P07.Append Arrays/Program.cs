using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> result = new List<int>();

            foreach (string item in list)
            {
                int[] arr = item
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    result.Insert(0, arr[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
