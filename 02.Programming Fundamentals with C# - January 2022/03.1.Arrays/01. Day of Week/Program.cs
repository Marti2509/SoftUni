using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //if (number > 0 && number < 8)
            //{
            //    Console.WriteLine(dayOfWeek[number - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");
            //}

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int printThisDay = int.Parse(Console.ReadLine());

            if (printThisDay > 0 && printThisDay < 8)
                Console.WriteLine(daysOfWeek[printThisDay - 1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
