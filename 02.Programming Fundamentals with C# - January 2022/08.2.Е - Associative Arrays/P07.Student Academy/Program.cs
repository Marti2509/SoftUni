using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }

                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                int count = student.Value.Count;

                double avGrade = student.Value.Sum(x => x) / count;

                if (avGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {avGrade:f2}");
                }
            }
        }
    }
}
