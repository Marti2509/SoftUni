using System;

namespace P02.Weekend_or_working_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            if (day == "Monday" ||
                day == "Tuesday" ||
                day == "Wednesday" ||
                day == "Thursday" ||
                day == "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (day == "Saturday" ||
                     day == "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
