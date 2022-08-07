using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double FuelConsumptionConst = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + FuelConsumptionConst;
        }

        public string DriveEmpty(double distance)
        {
            if (FuelQuantity > FuelConsumption - FuelConsumptionConst * distance)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            FuelQuantity -= FuelConsumption - FuelConsumptionConst * distance;
            
            return $"{this.GetType().Name} travelled {distance} km";
        }
    }
}
