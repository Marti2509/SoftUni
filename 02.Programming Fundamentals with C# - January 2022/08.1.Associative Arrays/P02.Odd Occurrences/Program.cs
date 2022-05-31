using System;
using System.Collections.Generic;

namespace P02.Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (string wordOrigin in text)
            {
                string word = wordOrigin.ToLower();

                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            foreach (var item in words)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{ item.Key} ");
                }
            }
        }
    }
}
