using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.SoftUni_Parking
{
    internal class Program
    {
        static string LicencePlate(Dictionary<string, string> parking, string name)
        {
            foreach (var item in parking)
            {
                if (item.Key == name)
                {
                    return item.Value;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = info[0];

                if (type == "register")
                {
                    string name = info[1];
                    string carPlate = info[2];

                    if (parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {LicencePlate(parking, name)}");
                    }
                    else
                    {
                        parking.Add(name, carPlate);

                        Console.WriteLine($"{name} registered {carPlate} successfully");
                    }
                }
                else if (type == "unregister")
                {
                    string name = info[1];

                    if (parking.ContainsKey(name) == false)
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        foreach (var item in parking)
                        {
                            if (item.Key == name)
                            {
                                parking.Remove(item.Key);

                                Console.WriteLine($"{name} unregistered successfully");
                            }
                        }
                    }
                }
            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
