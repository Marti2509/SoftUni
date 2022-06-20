using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                people.Add(person);
            }

            List<Person> sorted = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (Person person in sorted)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
