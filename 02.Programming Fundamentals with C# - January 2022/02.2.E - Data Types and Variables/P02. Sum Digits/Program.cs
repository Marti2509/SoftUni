using System;

namespace P02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                sum += number[i] - 48;
            }

            Console.WriteLine(sum);
        }
    }
}
