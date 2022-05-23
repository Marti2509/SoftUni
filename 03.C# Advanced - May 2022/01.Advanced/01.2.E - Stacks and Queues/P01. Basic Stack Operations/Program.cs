using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array[0]; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < array[1]; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Contains(array[2]) == true)
            {
                Console.WriteLine("true");
            }
            else if (stack.Count != 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
