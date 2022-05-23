using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < array[1]; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }

            if (queue.Contains(array[2]) == true)
            {
                Console.WriteLine("true");
            }
            else if (queue.Count != 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
