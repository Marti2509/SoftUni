using System;

namespace P01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double biggest = double.MinValue;
            double middle = double.MinValue;
            double smallest = double.MinValue;

            if (num1 >= num2 && num2 >= num3)
            {
                biggest = num1;
                middle = num2;
                smallest = num3;
            }
            else if (num1 >= num3 && num3 >= num2)
            {
                biggest = num1;
                middle = num2;
                smallest = num3;
            }
            else if (num2 >= num1 && num1 >= num3)
            {
                biggest = num2;
                middle = num1;
                smallest = num3;
            }
            else if (num3 >= num1 && num1 >= num2)
            {
                biggest = num3;
                middle = num1;
                smallest = num2;
            }
            else if (num2 >= num3 && num3 >= num1)
            {
                biggest = num2;
                middle = num3;
                smallest = num1;
            }
            else if (num3 >= num2 && num2 >= num1)
            {
                biggest = num3;
                middle = num2;
                smallest = num1;
            }

            Console.WriteLine(biggest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);
        }
    }
}
