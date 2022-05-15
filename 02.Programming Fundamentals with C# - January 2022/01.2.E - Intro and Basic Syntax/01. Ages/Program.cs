using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string end = "";
            
            if (age < 3)
            {
                end = "baby";
            }
            else if (age < 14)
            {
                end = "child";
            }
            else if (age < 20)
            {
                end = "teenager";
            }
            else if (age < 66)
            {
                end = "adult";
            }
            else
            {
                end = "elder";
            }

            Console.WriteLine(end);
        }
    }
}
