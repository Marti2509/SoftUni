using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Refuel Car 50

            string[] vehicleOneInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] vehicleTwoInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(vehicleOneInfo[1]), double.Parse(vehicleOneInfo[2]));
            Vehicle truck = new Truck(double.Parse(vehicleTwoInfo[1]), double.Parse(vehicleTwoInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Drive" && command[1] == "Car")
                {
                    Console.WriteLine(car.Drive(double.Parse(command[2])));
                }
                else if (command[0] == "Drive" && command[1] == "Truck")
                {
                    Console.WriteLine(truck.Drive(double.Parse(command[2])));
                }
                else if (command[0] == "Refuel" && command[1] == "Car")
                {
                    car.Refuel(double.Parse(command[2]));
                }
                else if (command[0] == "Refuel" && command[1] == "Truck")
                {
                    truck.Refuel(double.Parse(command[2]));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
