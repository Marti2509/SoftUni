using System;
using System.Collections.Generic;
using System.Text;

namespace P09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> old = new Stack<string>();
            Stack<int> numbers = new Stack<int>();

            string messege = string.Empty;
            old.Push(messege);

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input.Length == 1 && int.Parse(input) == 4)
                {
                    if (old.Count > 0)
                    {
                        if (numbers.Peek() != 4)
                        {
                            messege = old.Pop();
                        }
                        messege = old.Pop();
                    }

                    numbers.Push(int.Parse(input));
                }
                else if (int.Parse(input.Remove(1)) == 1)
                {
                    messege += input.Substring(2);
                    old.Push(messege);
                    numbers.Push(int.Parse(input.Remove(1)));
                }
                else if (int.Parse(input.Remove(1)) == 2)
                {
                    messege = messege.Remove(messege.Length - int.Parse(input.Substring(2)));
                    old.Push(messege);
                    numbers.Push(int.Parse(input.Remove(1)));
                }
                else if (int.Parse(input.Remove(1)) == 3)
                {
                    Console.WriteLine(messege[int.Parse(input.Substring(2)) - 1]);
                }
            }
        }
    }
}
