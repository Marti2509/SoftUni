using System;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {

                if (command[0] == "Create")
                    listyIterator = new ListyIterator<string>(command.Skip(1).ToArray());
                else if (command[0] == "Move")
                    Console.WriteLine(listyIterator.Move());
                else if (command[0] == "Print")
                    listyIterator.Print();
                else if (command[0] == "HasNext")
                    Console.WriteLine(listyIterator.HasNext());
                else if (command[0] == "PrintAll")
                    listyIterator.PrintAll();

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
