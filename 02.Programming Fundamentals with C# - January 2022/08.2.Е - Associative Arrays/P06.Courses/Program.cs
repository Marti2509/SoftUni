using System;
using System.Collections.Generic;

namespace P06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] info = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = info[0];
                string studentName = info[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(studentName);

                command = Console.ReadLine();
            }

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
