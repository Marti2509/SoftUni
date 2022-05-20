using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int[] roundedNumbers = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedNumbers.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {roundedNumbers[i]}");
            }
        }
    }
}
