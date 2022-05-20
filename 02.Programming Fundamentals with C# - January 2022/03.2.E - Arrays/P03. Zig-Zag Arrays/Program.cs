using System;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < arr1.Length; i++)
            {
                int[] currentNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

                int firstNum = currentNums[0];
                int secondNum = currentNums[1];

                if (i % 2 == 0)
                {
                    arr1[i] = firstNum;
                    arr2[i] = secondNum;
                }
                else
                {
                    arr1[i] = secondNum;
                    arr2[i] = firstNum;
                }
            }

            Console.WriteLine(String.Join(' ', arr1));
            Console.WriteLine(String.Join(' ', arr2));
        }
    }
}
