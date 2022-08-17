using System;

namespace P02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumberOfBadGrades = int.Parse(Console.ReadLine());
            int counterForBadGrades = 0;

            double grades = 0;
            double counter = 0;
            string lastProblem = string.Empty;

            string name = Console.ReadLine();

            while (name != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    counterForBadGrades++;

                    if (counterForBadGrades >= maxNumberOfBadGrades)
                    {
                        Console.WriteLine($"You need a break, {counterForBadGrades} poor grades.");
                        return;
                    }
                }

                grades += grade;
                counter++;
                lastProblem = name;

                name = Console.ReadLine();
            }

            double avGrade = grades / counter;

            Console.WriteLine($"Average score: {avGrade:f2}");
            Console.WriteLine($"Number of problems: {counter}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
