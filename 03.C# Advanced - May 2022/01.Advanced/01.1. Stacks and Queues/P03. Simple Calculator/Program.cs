using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            array = array.Reverse().ToArray();

            Stack<string> stack = new Stack<string>(array);

            int result = int.Parse(stack.Pop());

            while (stack.Count != 0)
            {
                char currOperator = char.Parse(stack.Pop());
                int currNum = int.Parse(stack.Pop());

                if (currOperator == '+')
                {
                    result = result + currNum;
                }
                else if (currOperator == '-')
                {
                    result -= currNum;
                }
            }

            Console.WriteLine(result);
        }
    }
}
