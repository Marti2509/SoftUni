using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string input = Console.ReadLine();

            bool isFalse = false;

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];

                if (currCh == '(' || currCh == '[' || currCh == '{')
                {
                    stack.Push(currCh);
                }
                else if (stack.Count > 0)
                {
                    if (stack.Peek() == '(' && ')' == currCh)
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '[' && ']' == currCh)
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == '{' && '}' == currCh)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    isFalse = true;
                }
            }

            if ((!isFalse) && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
