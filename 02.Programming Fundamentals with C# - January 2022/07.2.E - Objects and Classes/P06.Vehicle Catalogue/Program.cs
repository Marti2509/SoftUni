using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Vehicle_Catalogue
{
    //class Catalogue
    //{
    //    public Catalogue()
    //    {
    //        List<Car> cars = new List<Car>();
    //        List<Truck> trucks = new List<Truck>();
    //    }

    //    public List<Car> cars { get; set; }
    //    public List<Truck> trucks { get; set; }

    //    public void AddCar(Car car)
    //    {
    //        cars.Add(car);
    //    }
    //    public void AddTruck(Truck truck)
    //    {
    //        trucks.Add(truck);
    //    }
    //}

    class Car
    {
        public Car(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //Catalogue newCatalogue = new Catalogue();

            while (info[0] != "End")
            {
                string currType = info[0];
                string currModel = info[1];
                string currColor = info[2];
                int currHorsePower = int.Parse(info[3]);

                if (currType == "car")
                {
                    Car newCar = new Car(currModel, currColor, currHorsePower);

                    cars.Add(newCar);

                    //newCatalogue.AddCar(newCar);
                }
                else
                {
                    Truck newTruck = new Truck(currModel, currColor, currHorsePower);

                    trucks.Add(newTruck);

                    //newCatalogue.AddTruck(newTruck);
                }

                info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string line = Console.ReadLine();

            while (line != "Close the Catalogue")
            {
                foreach (Car car in cars)
                {
                    if (car.Model == line)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }

                foreach (Truck truck in trucks)
                {
                    if (truck.Model == line)
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }

                line = Console.ReadLine();
            }

            //int counterCars = 0;
            //int counterTrucks = 0;
            //int sumCars = 0;
            //int sumTrucks = 0;

            List<double> averageCars = new List<double>();
            List<double> averageTrucks = new List<double>();

            foreach (Car car in cars)
            {
                averageCars.Add(car.HorsePower);

                //counterCars++;
                //sumCars += car.HorsePower;
            }

            foreach (Truck truck in trucks)
            {
                averageTrucks.Add(truck.HorsePower);

                //counterTrucks++;
                //sumTrucks += truck.HorsePower;
            }

            //double averageCars = sumCars / counterCars * 0.1;
            //double averageTrucks = sumTrucks / counterTrucks;

            Console.WriteLine($"Cars have average horsepower of: {averageCars.Average():f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks.Average():f2}.");


        }
    }
}
