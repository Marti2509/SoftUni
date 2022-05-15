using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0 ; i--)
            {
                password = password + username[i];
            }

            string typedpass = Console.ReadLine();

            int counter = 0;

            while (typedpass != password)
            {
                counter++;

                if (counter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");

                typedpass = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
