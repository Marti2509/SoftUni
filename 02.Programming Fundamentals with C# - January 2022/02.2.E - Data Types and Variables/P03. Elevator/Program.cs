using System;

namespace P03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityForOneCourse = int.Parse(Console.ReadLine());

            if (numberOfPeople <= capacityForOneCourse)
            {
                Console.WriteLine(1);
            }
            else if (numberOfPeople % capacityForOneCourse == 0)
            {
                Console.WriteLine(numberOfPeople / capacityForOneCourse);
            }
            else
            {
                Console.WriteLine((numberOfPeople / capacityForOneCourse) + 1);
            }


        }
    }
}
