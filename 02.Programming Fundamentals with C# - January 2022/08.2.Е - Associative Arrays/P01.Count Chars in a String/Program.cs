using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> chars = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    chars.Add(input[i]);
                }
            }

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char @char in chars)
            {
                if (count.ContainsKey(@char))
                {
                    count[@char]++;
                }
                else
                {
                    count.Add(@char, 1);
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
