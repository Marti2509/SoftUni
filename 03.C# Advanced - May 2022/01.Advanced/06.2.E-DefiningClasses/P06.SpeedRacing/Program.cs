using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = info[1];
                double amountOfKm = double.Parse(info[2]);

                Car car = cars.Find(x => x.Model == model);

                car.Drive(car, amountOfKm);

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Travelleddistance}");
            }
        }
    }
}
