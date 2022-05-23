using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(order);

            int biggest = queue.Max();
            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                if (foodQuantity >= queue.Peek())
                {
                    foodQuantity -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine(biggest);

                    Console.Write("Orders left: ");

                    Console.Write(string.Join(' ', queue));

                    return;
                }
            }

            Console.WriteLine(biggest);
            Console.WriteLine("Orders complete");
        }
    }
}
