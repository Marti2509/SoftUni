using Microsoft.EntityFrameworkCore;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using ProductShop.Utils;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            using ProductShopContext context = new ProductShopContext();

            //string result = ImportUsers(context, File.ReadAllText("../../../Datasets/users.xml"));
            //string result = ImportProducts(context, File.ReadAllText("../../../Datasets/products.xml"));
            //string result = ImportCategories(context, File.ReadAllText("../../../Datasets/categories.xml"));
            //string result = ImportCategoryProducts(context, File.ReadAllText("../../../Datasets/categories-products.xml"));
            //string result = GetProductsInRange(context);
            //string result = GetSoldProducts(context);
            //string result = GetCategoriesByProductsCount(context);
            string result = GetUsersWithProducts(context);

            Console.WriteLine(result);
        }

        // Problem 1
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            XMLHelper helper = new XMLHelper();

            var deserialized = helper.Deserialize<List<ImportUsersDTO>>(inputXml, "Users");

            var users = new List<User>();

            foreach (var user in deserialized)
            {
                User currUser = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Age = user.Age,
                };

                users.Add(currUser);
            }

            context.Users.AddRange(users);
            int count = context.SaveChanges();

            return $"Successfully imported {count}";
        }

        // Problem 2
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            XMLHelper helper = new XMLHelper();

            var deserialized = helper.Deserialize<List<ImportProductsDTO>>(inputXml, "Products");

            var products = new List<Product>();

            foreach (var product in deserialized)
            {
                Product currProduct = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    BuyerId = product.BuyerId,
                    SellerId = product.SellerId,
                };

                products.Add(currProduct);
            }

            context.Products.AddRange(products);
            int count = context.SaveChanges();

            return $"Successfully imported {count}";
        }

        // Problem 3
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            XMLHelper helper = new XMLHelper();

            var deserialized = helper.Deserialize<List<ImportCategoriesDTO>>(inputXml, "Categories");

            var categories = new List<Category>();

            foreach (var category in deserialized)
            {
                if (string.IsNullOrEmpty(category.Name))
                {
                    continue;
                }

                Category currCategory = new Category
                {
                    Name = category.Name,
                };

                categories.Add(currCategory);
            }

            context.Categories.AddRange(categories);
            int count = context.SaveChanges();

            return $"Successfully imported {count}";
        }

        // Problem 4
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            XMLHelper helper = new XMLHelper();

            var deserialized = helper.Deserialize<List<ImportCategoriesProductsDTO>>(inputXml, "CategoryProducts")
                .Where(cp => context.Products.Any(p => p.Id == cp.ProductId) &&
                             context.Categories.Any(c => c.Id == cp.CategoryId))
                .ToList();

            var categoryProducts = new List<CategoryProduct>();

            foreach (var categoryProduct in deserialized)
            {
                CategoryProduct currCategoryProduct = new CategoryProduct
                {
                    CategoryId = categoryProduct.CategoryId,
                    ProductId = categoryProduct.ProductId
                };

                categoryProducts.Add(currCategoryProduct);
            }

            context.CategoryProducts.AddRange(categoryProducts);
            int count = context.SaveChanges();

            return $"Successfully imported {count}";
        }

        // Problem 5
        public static string GetProductsInRange(ProductShopContext context)
        {
            XMLHelper helper = new XMLHelper();

            var products = context.Products
                .AsNoTracking()
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new ExportProductsInRangeDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                })
                .OrderBy(p => p.Price)
                .Take(10)
                .ToList();

            var result = helper.Serialize<List<ExportProductsInRangeDTO>>(products, "Products")
                .Replace("<buyer> </buyer>", string.Empty);

            return Regex.Replace(result, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
        }

        // Problem 6
        public static string GetSoldProducts(ProductShopContext context)
        {
            XMLHelper helper = new XMLHelper();

            var users = context.Users
                .AsNoTracking()
                .Where(u => u.ProductsSold.Count >= 1)
                .Select(u => new ExportUsersSoldProducts
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold
                        .Select(p => new ExportSoldProducts
                        {
                            Name = p.Name,
                            Price = p.Price
                        })
                        .ToArray()
                })
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Take(5)
                .ToArray();

            return helper.Serialize(users, "Users");
        }

        // Problem 7
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            XMLHelper helper = new XMLHelper();

            var categories = context.Categories
                .AsNoTracking()
                .Select(c => new ExportCategoryProductsDTO
                {
                    Category = c.Name,
                    ProductsCount = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts.Average(x => x.Product.Price),
                    TotalRevenue = c.CategoryProducts.Sum(x => x.Product.Price)
                })
                .OrderByDescending(c => c.ProductsCount)
                .ThenBy(c => c.TotalRevenue)
                .ToList();

            return helper.Serialize(categories, "Categories");
        }

        // Problem 8
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            XMLHelper helper = new XMLHelper();

            var users = context.Users
                .Where(u => u.ProductsSold.Count > 0)
                .OrderByDescending(u => u.ProductsSold.Count)
                .Select(u => new ExportUsersCountDTO
                {
                    Count = 0
                })
                .ToList();

            var validUsers = context.Users
                .Where(u => u.ProductsSold.Count > 0)
                .OrderByDescending(u => u.ProductsSold.Count)
                .Select(u => new ExportUsersCountDTO
                {
                    Count = users.Select(u => u.Users).Count(),
                    Users = u.ProductsSold.Select(ps => new ExportUsersDTO
                    {
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Age = u.Age,
                        SoldProducts = u.ProductsSold.Select(ps => new ExportSoldProducts2
                        {
                            Count = u.ProductsSold.Count,
                            Products = u.ProductsSold.Select(ps => new ExportProducts
                            {
                                Name = ps.Name,
                                Price = ps.Price
                            })
                            .OrderByDescending(p => p.Price)
                            .ToList()
                        })
                        .ToList()
                    })
                    .ToList()
                })
                .Take(10)
                .ToList();

            return helper.Serialize(validUsers, "Users");
        }
    }
}