using System;
using System.Collections.Generic;
using System.Linq;

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
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];

                double tirePressure1 = double.Parse(info[5]);
                int tireAge1 = int.Parse(info[6]);
                double tirePressure2 = double.Parse(info[7]);
                int tireAge2 = int.Parse(info[8]);
                double tirePressure3 = double.Parse(info[9]);
                int tireAge3 = int.Parse(info[10]);
                double tirePressure4 = double.Parse(info[11]);
                int tireAge4 = int.Parse(info[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                
                Tire[] tires = new Tire[4];
                Tire tire1 = new Tire(tireAge1, tirePressure1);
                Tire tire2 = new Tire(tireAge2, tirePressure2);
                Tire tire3 = new Tire(tireAge3, tirePressure3);
                Tire tire4 = new Tire(tireAge4, tirePressure4);

                tires[0] = tire1;
                tires[1] = tire2;
                tires[2] = tire3;
                tires[3] = tire4;

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> sorted = cars.Where(x => x.Cargo.Type == "fragile").ToList();

                foreach (Car car in sorted)
                {
                    List<Tire> tires = car.Tires.ToList();

                    bool flag = false;

                    foreach (var tire in tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flammable")
            {
                List<Car> sorted = cars.Where(x => x.Cargo.Type == "flammable").Where(x => x.Engine.Power > 250).ToList();

                foreach (Car car in sorted)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
