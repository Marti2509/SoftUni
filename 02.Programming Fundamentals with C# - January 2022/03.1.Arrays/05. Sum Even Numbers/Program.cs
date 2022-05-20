using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
