using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>(); 
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                string[] parts = input.Split(' ');

                Tire tire1 = new Tire(int.Parse(parts[0]), double.Parse(parts[1]));
                Tire tire2 = new Tire(int.Parse(parts[2]), double.Parse(parts[3]));
                Tire tire3 = new Tire(int.Parse(parts[4]), double.Parse(parts[5]));
                Tire tire4 = new Tire(int.Parse(parts[6]), double.Parse(parts[7]));

                Tire[] fourTires = new Tire[4];
                fourTires[0] = tire1;
                fourTires[1] = tire2;
                fourTires[2] = tire3;
                fourTires[3] = tire4;

                tires.Add(fourTires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                for (int i = 0; i < 2; i++)
                {
                    int horsePower = int.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[i]);
                    double cubicCapacity = double.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[i += 1]);

                    engines.Add(new Engine(horsePower, cubicCapacity));
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string make = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                string model = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                int year = int.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                double fuelQuantity = double.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[3]);
                double fuelConsumption = double.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[4]);
                int engineIndex = int.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[5]);
                int tiresIndex = int.Parse(input.Split(' ', StringSplitOptions.RemoveEmptyEntries)[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));

                input = Console.ReadLine();
            }

            cars = cars.Where(x => x.Year >= 2017)
                .Where(x => x.Engine.HorsePower > 330)
                .Where(x => x.Tires.Select(x => x.Pressure).Sum() > 9)
                .Where(x => x.Tires.Select(x => x.Pressure).Sum() < 10)
                .ToList();

            foreach (Car car in cars)
            {
                double needFuel = car.FuelConsumption / 100 * 20;
                if (car.FuelQuantity >= needFuel)
                {
                    car.FuelQuantity -= needFuel;
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
