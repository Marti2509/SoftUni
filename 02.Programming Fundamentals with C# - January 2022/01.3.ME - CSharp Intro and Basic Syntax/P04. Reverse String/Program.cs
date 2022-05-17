using System;

namespace P04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string reveredWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reveredWord += word[i];
            }

            Console.WriteLine(reveredWord);
        }
    }
}
