using System;
using System.Linq;

namespace P03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(x => x).ToArray();

            if (numbers.Length <= 3)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
