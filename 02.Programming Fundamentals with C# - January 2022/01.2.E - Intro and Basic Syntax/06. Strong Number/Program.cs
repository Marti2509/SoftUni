using System;

namespace _06._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int sum = 0;
            int digetSum = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                int number = num[i] - 48;

                int factorial = 1;
                for (int j = 1; j <= number; j++)
                {
                    factorial = factorial * j;
                }

                sum += factorial;
            }

            if (sum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
