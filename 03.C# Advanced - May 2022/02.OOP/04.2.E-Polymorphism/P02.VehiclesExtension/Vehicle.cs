using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity 
        {
            get { return fuelQuantity; }
            set 
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value; 
                }
            }
        }

        public virtual double FuelConsumption { get; protected set; }

        public double TankCapacity { get; protected set; }

        public string Drive(double distance)
        {
            if (FuelQuantity < FuelConsumption * distance)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            FuelQuantity -= FuelConsumption * distance;

            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (TankCapacity <= fuel + FuelQuantity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
