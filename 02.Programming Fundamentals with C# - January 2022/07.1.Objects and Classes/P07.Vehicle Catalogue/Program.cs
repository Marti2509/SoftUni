using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.Vehicle_Catalogue
{
    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, uint horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public uint HorsePower { get; set; }
    }

    class Truck
    {
        public Truck(string brand, string model, uint weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public uint Weight { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (command != "end")
            {
                string carOrTruck = command.Split('/', StringSplitOptions.RemoveEmptyEntries)[0];
                string brand = command.Split('/', StringSplitOptions.RemoveEmptyEntries)[1];
                string model = command.Split('/', StringSplitOptions.RemoveEmptyEntries)[2];
                uint horsePowerOrWeight = uint.Parse(command.Split('/', StringSplitOptions.RemoveEmptyEntries)[3]);

                if (carOrTruck == "Car")
                {
                    Car newCar = new Car(brand, model, horsePowerOrWeight);

                    catalog.Cars.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck(brand, model, horsePowerOrWeight);

                    catalog.Trucks.Add(newTruck);
                }

                command = Console.ReadLine();
            }

            List<Car> sortedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();
            List<Truck> sortedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();


            Console.WriteLine("Cars:");

            foreach (Car car in sortedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");

            foreach (Truck truck in sortedTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
