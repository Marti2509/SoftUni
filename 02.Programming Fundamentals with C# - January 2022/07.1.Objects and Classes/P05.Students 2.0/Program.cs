using System;
using System.Collections.Generic;

namespace P05.Students_2._0
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
        static bool StudentExists(List<Student> students, string name, string lastName)
        {
            foreach (Student student in students)
            {
                if (name == student.Name && lastName == student.LastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetExistingStudent(List<Student> students, string name, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.Name == name && student.LastName == lastName)
                {
                    return student;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string studentName = command.Split(' ')[0];
                string StudentLastName = command.Split(' ')[1];
                uint StudentAge = uint.Parse(command.Split(' ')[2]);
                string StudentHomeTown = command.Split(' ')[3];

                if (StudentExists(students, studentName, StudentLastName))
                {
                    Student newStudent = GetExistingStudent(students, studentName, StudentLastName);

                    newStudent.Name = studentName;
                    newStudent.LastName = StudentLastName;
                    newStudent.Age = StudentAge;
                    newStudent.HomeTown = StudentHomeTown;
                }
                else
                {
                    Student student = new Student
                    (
                    studentName,
                    StudentLastName,
                    StudentAge,
                    StudentHomeTown
                    );

                    students.Add(student);
                }

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
