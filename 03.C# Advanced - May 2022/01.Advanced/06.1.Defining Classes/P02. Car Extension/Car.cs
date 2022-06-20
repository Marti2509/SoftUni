using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double consumption = distance * FuelConsumption;
            if (consumption <= FuelQuantity)
                FuelQuantity -= consumption;
            else
                Console.WriteLine("Not enough fuel to perform this trip!");
        }

        public void WhoAmI()
        {
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}");
        }
    }
}
