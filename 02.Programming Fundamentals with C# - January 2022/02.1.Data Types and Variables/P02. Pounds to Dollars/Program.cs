using System;

namespace P02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal poundsToDollars = 1.31m;
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dollars = pounds * poundsToDollars;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
