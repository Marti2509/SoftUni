using System;

namespace P11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (@operator == "+")
            {
                Console.WriteLine(Sum(num1, num2));
            }
            else if (@operator == "-")
            {
                Console.WriteLine(Sub(num1, num2));
            }
            else if (@operator == "*")
            {
                Console.WriteLine(Mult(num1, num2));
            }
            else
            {
                Console.WriteLine(Div(num1, num2));
            }
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
