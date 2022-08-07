using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; protected set; }

        public virtual double FuelConsumption { get; protected set; }

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
            FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
