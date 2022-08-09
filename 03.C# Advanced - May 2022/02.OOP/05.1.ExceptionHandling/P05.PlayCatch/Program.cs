using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int count = 0;

            while (count < 3)
            {
                try
                {
                    ReplaceOrShowOrPrint(array);
                }
                catch (FormatException fe)
                {
                    count++;

                    Console.WriteLine(fe.Message);
                }
                catch (IndexOutOfRangeException ioore)
                {
                    count++;

                    Console.WriteLine(ioore.Message);
                }
                finally
                {
                    if (count == 3)
                    {
                        Console.WriteLine(string.Join(", ", array));
                    }
                }
            }
        }

        private static void ReplaceOrShowOrPrint(int[] array)
        {
            string[] command = Console.ReadLine().Split(' ');

            if (command[0] == "Replace")
            {
                if (!int.TryParse(command[1], out int index) || !int.TryParse(command[2], out int element))
                {
                    throw new FormatException("The variable is not in the correct format!");
                }
                else if (index < 0 || index > array.Length - 1)
                {
                    throw new IndexOutOfRangeException("The index does not exist!");
                }

                array[index] = element;
            }
            else if (command[0] == "Show")
            {
                if (!int.TryParse(command[1], out int index))
                {
                    throw new FormatException("The variable is not in the correct format!");
                }
                else if (index < 0 || index > array.Length - 1)
                {
                    throw new IndexOutOfRangeException("The index does not exist!");
                }

                Console.WriteLine(array[index]);
            }
            else if (command[0] == "Print")
            {
                if (!int.TryParse(command[1], out int startIndex) || !int.TryParse(command[2], out int endIndex))
                {
                    throw new FormatException("The variable is not in the correct format!");
                }
                else if (startIndex < 0 || endIndex > array.Length - 1)
                {
                    throw new IndexOutOfRangeException("The index does not exist!");
                }

                List<int> list = new List<int>();

                for (int i = startIndex; i <= endIndex; i++)
                {
                    list.Add(array[i]);
                }

                Console.WriteLine(string.Join(", ", list));
            }
        }
    }
}
