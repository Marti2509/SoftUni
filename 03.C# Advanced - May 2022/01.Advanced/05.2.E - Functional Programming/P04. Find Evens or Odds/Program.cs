using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bound = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string oddOrEven = Console.ReadLine();

            List<int> nums = new List<int>();

            int lower = bound[0];
            int upper = bound[1];

            Predicate<int> predicate = null;
            
            if (oddOrEven == "odd")
            {
                predicate = n => n % 2 != 0;

                for (int i = lower; i <= upper; i++)
                {
                    if (predicate(i))
                    {
                        nums.Add(i);
                    }
                }

                Console.WriteLine(string.Join(' ', nums));
            }
            else if (oddOrEven == "even")
            {
                predicate = n => n % 2 == 0;

                for (int i = lower; i <= upper; i++)
                {
                    if (predicate(i))
                    {
                        nums.Add(i);
                    }
                }

                Console.WriteLine(string.Join(' ', nums));
            }
        }
    }
}
