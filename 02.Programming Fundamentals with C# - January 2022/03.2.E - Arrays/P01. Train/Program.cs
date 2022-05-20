using System;
using System.Linq;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            //int[] arr2 = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            int sum = 0;

            foreach (int item in arr1)
            {
                sum += item;
            }

            Console.WriteLine(String.Join(' ', arr1));
            Console.WriteLine(sum);
        }
    }
}
