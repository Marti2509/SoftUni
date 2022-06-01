using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currStudent = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!students.ContainsKey(currStudent[0]))
                    students.Add(currStudent[0], new List<decimal>());
                students[currStudent[0]].Add(decimal.Parse(currStudent[1]));
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(' ', student.Value.Select(x => x.ToString("f2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
