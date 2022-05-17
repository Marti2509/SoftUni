using System;
using System.Collections.Generic;

namespace P01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            foreach (char ch in stack)
            {
                Console.Write(ch);
            }
        }
    }
}
