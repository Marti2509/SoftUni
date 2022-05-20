using System;
using System.Linq;

namespace P06._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += numbers[j];
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sumRight += numbers[j];
                }
                
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
