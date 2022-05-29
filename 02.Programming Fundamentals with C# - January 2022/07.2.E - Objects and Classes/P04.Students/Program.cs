using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    class Student
    {
        public Student(string name, string lastName, double grade)
        {
            FirstName = name;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = info[0];
                string lastName = info[1];
                double grade = double.Parse(info[2]);

                Student newStudent = new Student(name, lastName, grade);

                students.Add(newStudent);
            }

            List<Student> sortedList = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in sortedList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
