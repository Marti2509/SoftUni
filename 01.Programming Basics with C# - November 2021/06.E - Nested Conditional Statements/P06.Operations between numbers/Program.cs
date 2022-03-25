using System;

namespace P06.Operations_between_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if (operation == '+')
            {
                int result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2} - odd");
                }
            }
            else if (operation == '-')
            {
                int result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2} - odd");
                }
            }
            else if (num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (operation == '/')
            {
                double result = 1.0 * num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result:f2}");
            }
            else if (operation == '*')
            {
                int result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2} - odd");
                }
            }
            else if (operation == '%')
            {


                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");


            }
        }
    }
}
