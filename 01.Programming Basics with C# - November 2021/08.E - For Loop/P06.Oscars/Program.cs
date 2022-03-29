using System;

namespace P06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double point = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                point = point + ((name.Length * points) / 2);

                if (point > 1250.5)
                {
                    break;
                }
            }

            if (point > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {point:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - point):f1} more!");
            }
        }
    }
}
