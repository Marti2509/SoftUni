using System;

namespace P02.Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            VowelsCount(word);
        }

        static void VowelsCount(string word)
        {
            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char curChar = word[i];

                if (curChar == 'a')
                {
                    counter++;
                }
                else if (curChar == 'e')
                {
                    counter++;
                }
                else if (curChar == 'i')
                {
                    counter++;
                }
                else if (curChar == 'o')
                {
                    counter++;
                }
                else if (curChar == 'u')
                {
                    counter++;
                }
                else if (curChar == 'y')
                {
                    counter++;
                }
                else if (curChar == 'A')
                {
                    counter++;
                }
                else if (curChar == 'E')
                {
                    counter++;
                }
                else if (curChar == 'I')
                {
                    counter++;
                }
                else if (curChar == 'O')
                {
                    counter++;
                }
                else if (curChar == 'U')
                {
                    counter++;
                }
                else if (curChar == 'Y')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
