using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            Travelleddistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double Travelleddistance { get; set; }

        public void Drive(Car car, double amountOfKm)
        {
            double need = car.FuelConsumptionPerKilometer * amountOfKm;

            if (car.FuelAmount >= need)
            {
                car.FuelAmount -= need;
                car.Travelleddistance += amountOfKm;
            }
            else
                Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
