using System;

namespace P03.Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //glp - godishen lihven procent

            double depsum = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double glp = double.Parse(Console.ReadLine());

            double sum = depsum + srok * ((depsum * (glp / 100)) / 12);

            Console.WriteLine(sum);
        }
    }
}
