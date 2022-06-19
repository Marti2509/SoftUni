using System;
using System.Collections.Generic;
using System.Linq;

namespace P09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> toRemove = new List<string>();
            List<string> toAdd = new List<string>();

            Predicate<string> predicate = null;

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Party!") break;
                else if (command[0] == "Remove")
                {
                    if (command[1] == "StartsWith")
                    {
                        predicate = x => x.StartsWith(command[2]);

                        foreach (string name in names)
                        {
                            if (predicate(name))
                                toRemove.Add(name);
                        }

                        for (int i = 0; i < toRemove.Count; i++)
                        {
                            names.Remove(toRemove[i]);
                        }

                        toRemove.Clear();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        predicate = x => x.EndsWith(command[2]);

                        foreach (string name in names)
                        {
                            if (predicate(name))
                                toRemove.Add(name);
                        }

                        for (int i = 0; i < toRemove.Count; i++)
                        {
                            names.Remove(toRemove[i]);
                        }

                        toRemove.Clear();
                    }
                    else if (command[1] == "Length")
                    {
                        predicate = x => x.Length == int.Parse(command[2]);

                        foreach (string name in names)
                        {
                            if (predicate(name))
                                toRemove.Add(name);
                        }

                        for (int i = 0; i < toRemove.Count; i++)
                        {
                            names.Remove(toRemove[i]);
                        }

                        toRemove.Clear();
                    }
                }
                else if (command[0] == "Double")
                {
                    if (command[1] == "StartsWith")
                    {
                        predicate = x => x.StartsWith(command[2]);

                        foreach (string name in names)
                        {
                            if (predicate(name))
                                toAdd.Add(name);
                        }

                        for (int i = 0; i < toAdd.Count; i++)
                        {
                            names.Add(toAdd[i]);
                        }

                        toAdd.Clear();
                    }
                    else if (command[1] == "EndsWith")
                    {
                        predicate = x => x.EndsWith(command[2]);

                        foreach (string name in names)
                        {
                            if (predicate(name))
                                toAdd.Add(name);
                        }

                        for (int i = 0; i < toAdd.Count; i++)
                        {
                            names.Add(toAdd[i]);
                        }

                        toAdd.Clear();
                    }
                    else if (command[1] == "Length")
                    {
                        predicate = x => x.Length == int.Parse(command[2]);

                        foreach (string name in names)
                        {
                            if (predicate(name))
                                toAdd.Add(name);
                        }

                        for (int i = 0; i < toAdd.Count; i++)
                        {
                            names.Add(toAdd[i]);
                        }

                        toAdd.Clear();
                    }
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(string.Join(", ", names));
                Console.WriteLine(" are going to the party!");
            }
        }
    }
}
