using System;

namespace P07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine(NewString(text, times));
        }

        static string NewString(string text, int times)
        {
            string newString = string.Empty;

            for (int i = 0; i < times; i++)
            {
                newString += text;
            }

            return newString;
        }
    }
}
