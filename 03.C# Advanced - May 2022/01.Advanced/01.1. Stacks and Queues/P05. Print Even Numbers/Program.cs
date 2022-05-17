using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    queue.Enqueue(num);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
