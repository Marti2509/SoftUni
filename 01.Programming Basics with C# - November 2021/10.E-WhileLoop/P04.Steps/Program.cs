using System;

namespace P04.Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;

            string command = Console.ReadLine();

            while (steps < 10000)
            {
                if (command == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    steps += lastSteps;

                    break;
                }

                int currSteps = int.Parse(command);

                steps += currSteps;

                command = Console.ReadLine();
            }

            if (steps == 10000)
                Console.WriteLine("Goal reached! Good job!");
            else if (steps > 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
            else
                Console.WriteLine($"{Math.Abs(steps - 10000)} more steps to reach goal.");
        }
    }
}
