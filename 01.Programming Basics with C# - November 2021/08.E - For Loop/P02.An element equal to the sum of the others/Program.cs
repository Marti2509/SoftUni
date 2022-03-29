using System;

namespace P02.An_element_equal_to_the_sum_of_the_others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
                sum += number;
            }
            int diff = sum - max;

            if (diff == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Math.Abs(diff)}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff - max)}");
            }
        }
    }
}
