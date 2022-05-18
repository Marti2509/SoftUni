using System;
using System.Numerics;

namespace P01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            BigInteger sum = ((num1 + num2) / num3) * num4;

            Console.WriteLine(sum);
        }
    }
}
