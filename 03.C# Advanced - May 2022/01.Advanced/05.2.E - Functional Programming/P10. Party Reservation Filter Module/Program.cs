using System;
using System.Collections.Generic;
using System.Linq;

namespace P10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine()
                 .Split(' ')
                 .ToList();
            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();
            string command = Console.ReadLine();
            while (command != "Print")
            {
                string[] cmndArgs = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string action = cmndArgs[0];
                string criteria = cmndArgs[1];
                string key = $"{cmndArgs[1]} {cmndArgs[2]}";
                if (action == "Add filter")
                {
                    if (!filters.ContainsKey(key))
                    {
                        filters.Add(key, GetFilter(command));
                    }
                }
                else if (action == "Remove filter")
                {
                    if (filters.ContainsKey(key))
                    {
                        filters.Remove(key);
                    }
                }


                command = Console.ReadLine();
            }
            foreach (var item in filters.Values)
            {
                invitations.RemoveAll(item);
            }
            Console.WriteLine(String.Join(" ", invitations));
        }
        private static Predicate<string> GetFilter(string command)
        {
            string[] cmndArgs = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
            string filterType = cmndArgs[1];
            string filterParam = cmndArgs[2];
            Predicate<string> predicate = null;
            if (filterType == "Starts with")
            {
                predicate = name => name.StartsWith(filterParam);
            }
            else if (filterType == "Ends with")
            {
                predicate = name => name.EndsWith(filterParam);
            }
            else if (filterType == "Length")
            {
                predicate = name => name.Length == int.Parse(filterParam);
            }
            else if (filterType == "Contains")
            {
                predicate = name => name.Contains(filterParam);
            }
            return predicate;
        }
    }
}