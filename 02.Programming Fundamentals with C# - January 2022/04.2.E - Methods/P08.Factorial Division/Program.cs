using System;

namespace P08.Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = int.Parse(Console.ReadLine());
            decimal num2 = int.Parse(Console.ReadLine());

            decimal result = Num1Fac(num1) / Num2Fac(num2);

            Console.WriteLine($"{result:f2}");
        }

        static decimal Num1Fac(decimal num)
        {
            decimal fac = 1;

            for (int i = 1; i <= num; i++)
            {
                fac *= i;
            }

            return fac;
        }

        static decimal Num2Fac(decimal num)
        {
            decimal fac = 1;

            for (int i = 1; i <= num; i++)
            {
                fac *= i;
            }

            return fac;
        }
    }
}
