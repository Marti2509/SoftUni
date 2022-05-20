using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }
                else
                {
                    oddSum += item;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
