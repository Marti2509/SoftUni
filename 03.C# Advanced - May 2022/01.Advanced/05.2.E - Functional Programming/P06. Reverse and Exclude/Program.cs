using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            nums.Reverse();

            int n = int.Parse(Console.ReadLine());

            List<int> removed = new List<int>(); 

            Predicate<int> isDivisableByTwo = x => x % n != 0;

            foreach (int num in nums)
            {
                if (isDivisableByTwo(num))
                {
                    removed.Add(num);
                }
            }

            Console.WriteLine(string.Join(' ', removed));
        }
    }
}
