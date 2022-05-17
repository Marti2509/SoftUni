using System;

namespace P02._EN_Name_of_the_L_Diget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = number % 10;

            string name = "ne raboti";

            if (number == 1)
            {
                name = "one";
            }
            else if (number == 2)
            {
                name = "two";
            }
            else if (number == 3)
            {
                name = "three";
            }
            else if (number == 4)
            {
                name = "four";
            }
            else if (number == 5)
            {
                name = "five";
            }
            else if (number == 6)
            {
                name = "six";
            }
            else if (number == 7)
            {
                name = "seven";
            }
            else if (number == 8)
            {
                name = "eight";
            }
            else if (number == 9)
            {
                name = "nine";
            }
            else if (number == 0)
            {
                name = "zero";
            }

            Console.WriteLine(name);
        }
    }
}
