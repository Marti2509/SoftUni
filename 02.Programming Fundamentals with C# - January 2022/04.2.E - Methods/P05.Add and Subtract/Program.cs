using System;

namespace P05.Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            int sub = Sub(sum, num3);

            Console.WriteLine(sub);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Sub(int sum, int num3)
        {
            return sum - num3;
        }
    }
}
