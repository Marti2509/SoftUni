﻿using System;

namespace P04.Guess_The_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
