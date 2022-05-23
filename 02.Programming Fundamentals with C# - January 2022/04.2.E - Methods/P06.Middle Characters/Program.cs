using System;

namespace P06.Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MiddleChar(text);
        }

        static void MiddleChar(string text)
        {
            int length = text.Length;
            if (text.Length % 2 == 1)
            {
                int middleCharInt = length / 2;
                char middleChar = text[middleCharInt];

                Console.WriteLine(middleChar);
            }
            else
            {
                int middleCharInt = length / 2;
                char middleChar1 = text[middleCharInt - 1];
                char middleChar2 = text[middleCharInt];

                Console.Write(middleChar1);
                Console.WriteLine(middleChar2);
            }

            
        }
    }
}
