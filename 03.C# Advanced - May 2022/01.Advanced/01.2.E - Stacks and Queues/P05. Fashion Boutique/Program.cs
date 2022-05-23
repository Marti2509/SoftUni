using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(arr);

            int n = int.Parse(Console.ReadLine());

            int rack = n;
            int counter = 1;

            while (stack.Count != 0)
            {
                if (rack >= stack.Peek())
                {
                    rack -= stack.Pop();
                }
                else
                {
                    rack = n;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
