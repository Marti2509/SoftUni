using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Tesla";
            car.Model = "Model 3";
            car.Year = 2022;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(200);

            car.WhoAmI();
        }
    }
}
