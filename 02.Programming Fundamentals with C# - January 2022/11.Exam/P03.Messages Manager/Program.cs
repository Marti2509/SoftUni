using System;
using System.Collections.Generic;

namespace P03.Messages_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            int capacity = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            while (line != "Statistics")
            {
                string[] command = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];

                if (action == "Add")
                {
                    string name = command[1];
                    int sended = int.Parse(command[2]);
                    int recieved = int.Parse(command[3]);

                    if (!people.ContainsKey(name))
                    {
                        people[name] = sended + recieved;
                    }
                }
                else if (action == "Message")
                {
                    string sender = command[1];
                    string reveiver = command[2];

                    if (people.ContainsKey(sender) && people.ContainsKey(reveiver))
                    {
                        people[sender]++;
                        people[reveiver]++;
                    }

                    if (people[sender] >= capacity)
                    {
                        people.Remove(sender);
                        Console.WriteLine($"{sender} reached the capacity!");
                    }

                    if (people[reveiver] >= capacity)
                    {
                        people.Remove(reveiver);
                        Console.WriteLine($"{reveiver} reached the capacity!");
                    }
                }
                else if (action == "Empty")
                {
                    string name = command[1];

                    if (name == "All")
                    {
                        people.Clear();
                    }
                    else
                    {
                        people.Remove(name);
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {people.Count}");

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
        }
    }
}