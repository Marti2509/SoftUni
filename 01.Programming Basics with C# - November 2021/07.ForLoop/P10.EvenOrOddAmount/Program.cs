using System;

namespace P10.Even_or_odd_amount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evens = 0;
            int odds = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evens += num;
                }
                else
                {
                    odds += num;
                }
            }

            if (evens == odds)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evens}");
            }
            else
            {
                int diff = Math.Abs(evens - odds);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
