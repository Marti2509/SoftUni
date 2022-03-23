using System;

namespace P01.Console_Converter___USD_To_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;

            Console.WriteLine(BGN);
        }
    }
}
