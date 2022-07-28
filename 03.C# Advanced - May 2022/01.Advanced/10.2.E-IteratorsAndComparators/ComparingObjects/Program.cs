using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (info[0] != "END")
            {
                people.Add(new Person(info[0], int.Parse(info[1]), info[2]));
                info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            int equal = 0;
            int notEqual = 0;

            int numForPerson = int.Parse(Console.ReadLine()) - 1;

            Person @this = people[numForPerson];

            foreach (Person person in people)
            {
                if (@this.CompareTo(person) == 0)
                    equal++;
                else
                    notEqual++;
            }

            if (equal > 1)
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            else
                Console.WriteLine("No matches");
        }
    }
}
