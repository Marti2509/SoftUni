﻿using System;

namespace P06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
