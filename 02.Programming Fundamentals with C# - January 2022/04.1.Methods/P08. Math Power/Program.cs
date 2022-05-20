using System;
using System.Numerics;

namespace P08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(@base, power));
        }

        static double MathPower(double @base, int power)
        {
            //double result = 1.0;

            //for (int i = 1; i <= power; i++)
            //{
            //    result *= @base;
            //}
            double result = Math.Pow(@base, power);

            return result;
        }
    }
}
