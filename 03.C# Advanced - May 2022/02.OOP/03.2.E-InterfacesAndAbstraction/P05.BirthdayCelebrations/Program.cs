using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> list = new List<IBirthable>();

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "End")
            {
                if (command[0] == "Citizen")
                {
                    list.Add(new Citizens(command[1], int.Parse(command[2]), command[3], command[4]));
                }
                else if (command[0] == "Pet")
                {
                    list.Add(new Pet(command[1], command[2]));
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string year = Console.ReadLine();

            List<string> years = new List<string>();

            foreach (IBirthable item in list)
            {
                if (item.Birthdate.EndsWith(year))
                {
                    years.Add(item.Birthdate);
                }
            }

            Console.WriteLine(string.Join('\n', years));
        }
    }
}
