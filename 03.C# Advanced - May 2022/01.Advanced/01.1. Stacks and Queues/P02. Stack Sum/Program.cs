using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(input);

            string[] input2 = Console.ReadLine().ToLower().Split(' ');

            while (input2[0] != "end")
            {
                if (input2[0] == "add")
                {
                    int num1 = int.Parse(input2[1]);
                    int num2 = int.Parse(input2[2]);

                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (input2[0] == "remove")
                {
                    int n = int.Parse(input2[1]);

                    if (stack.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                input2 = Console.ReadLine().ToLower().Split(' ');
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
