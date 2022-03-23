using System;

namespace P06.Combining_Text_And_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are " + firstName + " " + lastName + ", a " + age + "-years old person from " + town + ".");
        }
    }
}
