using System;
using System.Collections.Generic;

namespace P06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);

            string command = Console.ReadLine();

            while (queue.Count != 0)
            {
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string song = command.Substring(4);

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
