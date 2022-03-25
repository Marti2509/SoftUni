using System;

namespace P08.In_time_for_the_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minsExam = int.Parse(Console.ReadLine());
            int hourThere = int.Parse(Console.ReadLine());
            int minsThere = int.Parse(Console.ReadLine());
            int examInMins = hourExam * 60 + minsExam;
            int thereInMins = hourThere * 60 + minsThere;
            int timeDiff = thereInMins - examInMins;

            if (timeDiff > 0)
            {
                Console.WriteLine("Late");

                if (timeDiff < 60)
                {
                    Console.WriteLine($"{timeDiff} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{timeDiff / 60}:{timeDiff % 60:d2} hours after the start");
                }
            }
            else if (timeDiff == 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                timeDiff = Math.Abs(timeDiff);

                if (timeDiff > 30)
                {
                    Console.WriteLine("Early");

                    if (timeDiff < 60)
                    {
                        Console.WriteLine($"{timeDiff} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{timeDiff / 60}:{timeDiff % 60:d2} hours before the start");
                    }
                }
                else if (timeDiff <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{timeDiff} minutes before the start");
                }
            }
        }
    }
}
