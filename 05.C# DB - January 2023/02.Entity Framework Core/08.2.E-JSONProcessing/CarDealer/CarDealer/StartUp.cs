using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Globalization;
using System.IO;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            using CarDealerContext context = new CarDealerContext();

            //string result = ImportSuppliers(context, File.ReadAllText("../../../Datasets/suppliers.json"));
            //string result = ImportParts(context, File.ReadAllText("../../../Datasets/parts.json"));
            //string result = ImportCars(context, File.ReadAllText("../../../Datasets/cars.json"));
            //string result = ImportCustomers(context, File.ReadAllText("../../../Datasets/customers.json"));
            //string result = ImportSales(context, File.ReadAllText("../../../Datasets/sales.json"));
            //string result = GetOrderedCustomers(context);
            //string result = GetCarsFromMakeToyota(context);
            //string result = GetCarsFromMakeToyota(context);
            //string result = GetLocalSuppliers(context);
            //string result = GetCarsWithTheirListOfParts(context);
            //string result = GetTotalSalesByCustomer(context);
            string result = GetSalesWithAppliedDiscount(context);

            Console.WriteLine(result);
        }

        // Problem 9
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            List<SupplierDTO>? deserializedSuppliers = JsonConvert.DeserializeObject<List<SupplierDTO>>(inputJson);

            List<Supplier> suppliers = new List<Supplier>();
            foreach (SupplierDTO supplier in deserializedSuppliers)
            {
                suppliers.Add(new Supplier
                {
                    Name = supplier.Name,
                    IsImporter = supplier.IsImporter,
                });
            }

            context.Suppliers.AddRange(suppliers);
            int count = context.SaveChanges();

            return $"Successfully imported {count}.";
        }

        // Problem 10
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            List<PartDTO>? deserializedParts = JsonConvert.DeserializeObject<List<PartDTO>>(inputJson);

            List<Part> parts = new List<Part>();
            foreach (PartDTO part in deserializedParts)
            {
                if (context.Suppliers.Find(part.SupplierId) != null)
                {
                    parts.Add(new Part
                    {
                        Name = part.Name,
                        Price = part.Price,
                        Quantity = part.Quantity,
                        SupplierId = part.SupplierId,
                    });
                }
            }

            context.Parts.AddRange(parts);
            int count = context.SaveChanges();

            return $"Successfully imported {count}.";
        }

        // Problem 11
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            List<CarDTO>? deserializedCars = JsonConvert.DeserializeObject<List<CarDTO>>(inputJson);

            var existingPartsId = context.Parts.Select(x => x.Id).ToHashSet();

            var validCars = new List<Car>();

            foreach (var carDto in deserializedCars)
            {
                var car = new Car
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TraveledDistance = carDto.TraveledDistance
                };

                foreach (var part in carDto.PartsId.Distinct())
                {
                    if (existingPartsId.Contains(part))
                    {
                        var currentCarPart = new PartCar
                        {
                            CarId = car.Id,
                            PartId = part
                        };

                        car.PartsCars.Add(currentCarPart);
                    }
                }

                validCars.Add(car);
            }

            context.Cars.AddRange(validCars);
            context.SaveChanges();

            return $"Successfully imported {validCars.Count}.";
        }

        // Problem 12
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            List<CustomerDTO>? deserializedCustomers = JsonConvert.DeserializeObject<List<CustomerDTO>>(inputJson);

            List<Customer> customers = new List<Customer>();
            foreach (CustomerDTO customer in deserializedCustomers)
            {
                customers.Add(new Customer
                {
                    Name = customer.Name,
                    BirthDate = customer.BirthDate,
                    IsYoungDriver = customer.IsYoungDriver
                });
            }

            context.Customers.AddRange(customers);
            int count = context.SaveChanges();

            return $"Successfully imported {count}.";
        }

        // Problem 13
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            List<SaleDTO>? deserializedSales = JsonConvert.DeserializeObject<List<SaleDTO>>(inputJson);

            List<Sale> sales = new List<Sale>();
            foreach (SaleDTO sale in deserializedSales)
            {
                sales.Add(new Sale
                {
                    Discount = sale.Discount,
                    CarId = sale.CarId,
                    CustomerId = sale.CustomerId
                });
            }

            context.Sales.AddRange(sales);
            int count = context.SaveChanges();

            return $"Successfully imported {count}.";
        }

        // Problem 14
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .AsNoTracking()
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new OrderedCustomersDTO
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToList();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }

        // Problem 15
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .AsNoTracking()
                .Where(c => c.Make == "Toyota")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .Select(c => new ToyotaCarDTO
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                })
                .ToList();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }

        // Problem 16
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .AsNoTracking()
                .Where(s => s.IsImporter == false)
                .Select(s => new LocalSuppliesDTO
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToList();

            return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
        }

        // Problem 17
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .AsNoTracking()
                .Select(c => new CarWithPartsDTO
                {
                    car = new CarsDTO
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TraveledDistance = c.TraveledDistance
                    },
                    parts = c.PartsCars.Select(p => new PartsDTO
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price.ToString("F2")
                    })
                    .ToList()
                })
                .ToList();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }

        // Problem 18
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .AsNoTracking()
                .Where(c => c.Sales.Count >= 1)
                .Select(c => new CustomerCarsDTO
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SpentMoney = c.Sales.Sum(s => s.Car.PartsCars.Sum(pc => pc.Part.Price))
                })
                .OrderByDescending(c => c.SpentMoney)
                .ThenByDescending(c => c.BoughtCars)
                .ToList();

            return JsonConvert.SerializeObject(customers, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }

        // Problem 19
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .AsNoTracking()
                .Take(10)
                .Select(s => new SalesDiscountDTO
                {
                    car = new SalesCarDTO
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TraveledDistance
                    },
                    customerName = s.Customer.Name,
                    discount = s.Discount.ToString("F2"),
                    price = s.Car.PartsCars.Sum(pc => pc.Part.Price).ToString("F2"),
                    priceWithDiscount = (s.Car.PartsCars.Sum(pc => pc.Part.Price) - s.Car.PartsCars.Sum(pc => pc.Part.Price) * (s.Discount / 100)).ToString("F2")
                })
            .ToList();

            return JsonConvert.SerializeObject(sales, Formatting.Indented);
        }
    }
}