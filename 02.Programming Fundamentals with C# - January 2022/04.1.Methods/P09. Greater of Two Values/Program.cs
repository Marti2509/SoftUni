using System;

namespace P09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            if (command == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(Greater(num1, num2));
            }
            else if (command == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());

                Console.WriteLine(Greater(char1, char2));
            }
            else if (command == "string")
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();

                Console.WriteLine(Greater(string1, string2));
            }
        }

        static int Greater(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }

            return num2;
        }

        static char Greater(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }

            return char2;
        }

        static string Greater(string string1, string string2)
        {
            if (string1.CompareTo(string2) >= 0)
            {
                return string1;
            }

            return string2;
        }
    }
}
