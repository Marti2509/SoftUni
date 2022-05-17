using System;
using System.Collections.Generic;

namespace P07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(' ');

            Queue<string> queue = new Queue<string>(people);

            int n = int.Parse(Console.ReadLine());

            while (queue.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    string currPlayer = queue.Dequeue();
                    queue.Enqueue(currPlayer);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
