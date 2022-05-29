using System;
using System.Collections.Generic;

namespace P04.Students
{

    class Student
    {
        public Student(string name, string lastName, uint age, string homeTown)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }
        public string HomeTown { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string studentName = command.Split(' ')[0];
                string StudentlLastName = command.Split(' ')[1];
                uint StudentAge = uint.Parse(command.Split(' ')[2]);
                string StudentHomeTown = command.Split(' ')[3];

                Student student = new Student
                    (
                    studentName, 
                    StudentlLastName, 
                    StudentAge, 
                    StudentHomeTown
                    );

                students.Add(student);

                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (city == student.HomeTown)
                {
                    Console.WriteLine($"{student.Name} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
