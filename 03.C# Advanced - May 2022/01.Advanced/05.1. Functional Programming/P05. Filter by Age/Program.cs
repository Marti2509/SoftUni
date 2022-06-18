using System;
using System.Collections.Generic;

namespace P05._Filter_by_Age
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static public void OnlyName(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }
        }

        static public void OnlyAge(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.Age);
            }
        }

        static public void Both(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();
            List<Person> filtered = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = info[0];
                int age = int.Parse(info[1]);

                people.Add(new Person(name, age));
            }

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if (condition == "younger")
            {
                foreach (Person person in people)
                {
                    if (person.Age < ageThreshold)
                        filtered.Add(person);
                }
            }
            else
            {
                foreach (Person person in people)
                {
                    if (person.Age >= ageThreshold)
                        filtered.Add(person);
                }
            }

            if (format == "name")
                OnlyName(filtered);
            else if (format == "age")
                OnlyAge(filtered);
            else if (format == "name age")
                Both(filtered);
        }
    }
}
