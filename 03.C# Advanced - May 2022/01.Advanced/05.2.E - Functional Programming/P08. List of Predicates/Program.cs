using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> nums = new List<int>();
            List<int> print = new List<int>();

            Predicate<int> isDividable = null;

            for (int i = 1; i <= n; i++)
            {
                nums.Add(i);
            }

            foreach (int num in nums)
            {
                bool isCurrNumDividable = true;

                foreach (int div in dividers)
                {
                    isDividable = x => x % div == 0;

                    if (!isDividable(num))
                    {
                        isCurrNumDividable = false;
                        break;
                    }
                }

                if (isCurrNumDividable)
                {
                    print.Add(num);
                }
            }

            Console.WriteLine(string.Join(' ', print));
        }
    }
}
