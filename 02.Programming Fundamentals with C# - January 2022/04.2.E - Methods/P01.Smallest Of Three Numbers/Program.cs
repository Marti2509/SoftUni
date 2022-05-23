using System;

namespace P01.Smallest_Of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            SmallestNumber(num1, num2, num3);
        }

        static void SmallestNumber(int num1, int num2, int num3)
        {
            int number = int.MaxValue;

            if (num1 < number)
            {
                number = num1;
            }
            
            if (num2 < number)
            {
                number = num2;
            }

            if (num3 < number)
            {
                number = num3;
            }

            Console.WriteLine(number);
        }
    }
}
