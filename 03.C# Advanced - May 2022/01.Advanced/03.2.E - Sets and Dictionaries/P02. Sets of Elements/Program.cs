using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();

            HashSet<int> both = new HashSet<int>();

            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int numN = input[0];
            int numM = input[1];

            for (int i = 0; i < numN; i++)
            {
                n.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < numM; i++)
            {
                m.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int num in n)
            {
                foreach (int currNum in m)
                {
                    if (currNum == num)
                    {
                        both.Add(currNum);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', both));
        }
    }
}
