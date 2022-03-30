using System;

namespace P04.Row_From_Numbers_2n___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int k = 1;

            while (k <= n)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
