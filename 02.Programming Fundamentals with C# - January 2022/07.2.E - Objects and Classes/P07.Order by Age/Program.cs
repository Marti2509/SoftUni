using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (line[0] != "End")
            {
                string currName = line[0];
                string currId = line[1];
                int currAge = int.Parse(line[2]);

                if (DoesIdExists(currId, people) == true)
                {
                    foreach (Person person in people)
                    {
                        if (person.Id == currId)
                        {
                            person.Name = currName;
                            person.Age = currAge;
                        }
                    }
                }
                else
                {
                    Person newPerson = new Person(currName, currId, currAge);
                    people.Add(newPerson);
                }

                line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            List<Person> sortedList = people.OrderBy(x => x.Age).ToList();

            foreach (Person person in sortedList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }

        public static bool DoesIdExists(string id, List<Person> people)
        {
            foreach (Person person in people)
            {
                if (person.Id == id)
                {
                    return true;
                }
                //else
                //{
                //    return false;
                //}

                //return false;
            }

            return false;
        }
    }
}
