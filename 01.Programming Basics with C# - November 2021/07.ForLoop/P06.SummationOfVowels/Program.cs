﻿using System;

namespace P06.Summation_of_vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (letter == 'a')
                {
                    sum = sum + 1;
                }

                if (letter == 'e')
                {
                    sum += 2;
                }

                if (letter == 'i')
                {
                    sum += 3;
                }

                if (letter == 'o')
                {
                    sum += 4;
                }

                if (letter == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
