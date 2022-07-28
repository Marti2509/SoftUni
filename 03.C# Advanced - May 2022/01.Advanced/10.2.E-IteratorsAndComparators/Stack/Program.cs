using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x.TrimEnd(',')).ToArray();

            while (command[0] != "END")
            {
                if (command[0] == "Push")
                {
                    int[] ints = command.Skip(1).Select(int.Parse).ToArray();
                    stack.Push(ints);
                }
                else if (command[0] == "Pop")
                    stack.Pop();

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
