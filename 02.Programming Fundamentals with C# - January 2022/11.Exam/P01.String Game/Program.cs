using System;

namespace P01.String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string line = Console.ReadLine();

            while (line != "Done")
            {
                string[] command = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];

                if (action == "Change")
                {
                    char ch = char.Parse(command[1]);
                    char replacement = char.Parse(command[2]);

                    text = text.Replace(ch, replacement);

                    Console.WriteLine(text);
                }
                else if (action == "Includes")
                {
                    string substring = command[1];

                    if (text.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "End")
                {
                    string substring = command[1];

                    if (text.EndsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "Uppercase")
                {
                    text = text.ToUpper();

                    Console.WriteLine(text);
                }
                else if (action == "FindIndex")
                {
                    char ch = char.Parse(command[1]);

                    char charFromText = (char)text.IndexOf(ch);

                    Console.WriteLine((int)charFromText);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int length = int.Parse(command[2]);

                    text = text.Substring(startIndex, length);

                    Console.WriteLine(text);
                }

                line = Console.ReadLine();
            }
        }
    }
}
