using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string read = Console.ReadLine();


            while (read != "end")
            {
                List<string> seperated = read.Split(' ').ToList();

                if (seperated[0] == "Chat")
                {
                    list.Add(seperated[1]);
                }
                else if (seperated[0] == "Delete")
                {
                    list.Remove(seperated[1]);
                }
                else if (seperated[0] == "Edit")
                {
                    string message = seperated[1];

                    int count = -1;

                    if (list.Contains(message))
                    {
                        foreach (string item in list)
                        {
                            count++;

                            if (item == message)
                            {
                                break;
                            }
                        }

                        list.Remove(message);
                        list.Insert(count, seperated[2]);
                    }
                }
                else if (seperated[0] == "Pin")
                {
                    string message = seperated[1];

                    if (list.Contains(message))
                    {
                        list.Remove(message);
                        list.Add(message);
                    }
                }
                else if (seperated[0] == "Spam")
                {
                    foreach (string item in seperated)
                    {
                        if (item == "Spam")
                        {
                            continue;
                        }
                        else
                        {
                            list.Add(item);
                        }
                    }
                }

                seperated.Clear();
                read = Console.ReadLine();
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
