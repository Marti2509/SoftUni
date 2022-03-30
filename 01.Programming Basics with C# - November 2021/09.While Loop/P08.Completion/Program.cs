using System;

namespace P08.Completion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int @class = 1;
            double grades = 0.0;

            int exclude = 0;

            while (@class <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    @class++;
                    grades += grade;
                }
                else
                {

                    exclude++;

                    if (exclude == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {@class} grade");
                        return;
                    }

                }
            }

            @class--;

            double averageGrade = grades / @class;

            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
