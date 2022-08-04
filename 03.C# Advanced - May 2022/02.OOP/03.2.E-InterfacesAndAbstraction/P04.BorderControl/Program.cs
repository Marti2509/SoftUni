using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> list = new List<IIdentifiable>();

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "End")
            {
                if (command.Length == 3)
                {
                    list.Add(new Citizens(command[0], int.Parse(command[1]), command[2]));
                }
                else if (command.Length == 2)
                {
                    list.Add(new Robot(command[0], command[1]));
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string fakeLastThreeDigets = Console.ReadLine();

            List<string> denied = new List<string>();

            foreach (IIdentifiable item in list)
            {
                if (item.Id.EndsWith(fakeLastThreeDigets))
                {
                    denied.Add(item.Id);
                }
            }

            Console.WriteLine(string.Join('\n', denied));
        }
    }
}
