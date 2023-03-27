using ProductShop.Data;
using ProductShop.Models;
using ProductShop.DTOs.Import;

using Newtonsoft.Json;
using ProductShop.DTOs.Export;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            using ProductShopContext context = new ProductShopContext();

            //string result = ImportUsers(context, File.ReadAllText(@"../../../Datasets/users.json"));
            //string result = ImportProducts(context, File.ReadAllText(@"../../../Datasets/products.json"));
            //string result = ImportCategories(context, File.ReadAllText(@"../../../Datasets/categories.json"));
            //string result = ImportCategoryProducts(context, File.ReadAllText(@"../../../Datasets/categories-products.json"));
            //string result = GetProductsInRange(context);
            //string result = GetSoldProducts(context);
            //string result = GetCategoriesByProductsCount(context);
            string result = GetUsersWithProducts(context);

            Console.WriteLine(result);
        }

        // Problem 1
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            List<UserDTO>? deserializedUsers = JsonConvert.DeserializeObject<List<UserDTO>>(inputJson);

            List<User> users = new List<User>();
            foreach (UserDTO user in deserializedUsers)
            {
                users.Add(new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Age = user.Age
                });
            }

            context.Users.AddRange(users);
            int count = context.SaveChanges();

            return $"Successfully imported {count}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            List<ProductDTO>? deserializedProducts = JsonConvert.DeserializeObject<List<ProductDTO>>(inputJson);

            List<Product> products = new List<Product>();
            foreach (ProductDTO product in deserializedProducts)
            {
                products.Add(new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    SellerId = product.SellerId,
                    BuyerId = product.BuyerId
                });
            }

            context.Products.AddRange(products);
            int count = context.SaveChanges();

            return $"Successfully imported {count}";
        }

        // Problem 3
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            List<CategoryDTO>? deserializedCategories = JsonConvert.DeserializeObject<List<CategoryDTO>>(inputJson);

            List<Category> categories = new List<Category>();
            foreach (CategoryDTO category in deserializedCategories)
            {
                if (category.Name != null)
                {
                    categories.Add(new Category
                    {
                        Name = category.Name
                    });
                }
            }

            context.Categories.AddRange(categories);
            int count = context.SaveChanges();

            return $"Successfully imported {count}";
        }

        // Problem 4
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            List<CategoryProductDTO>? deserializedCategoriesProducts = JsonConvert.DeserializeObject<List<CategoryProductDTO>>(inputJson);

            List<CategoryProduct> categoriesProducts = new List<CategoryProduct>();
            foreach (CategoryProductDTO categoryProduct in deserializedCategoriesProducts)
            {
                categoriesProducts.Add(new CategoryProduct
                {
                    CategoryId = categoryProduct.CategoryId,
                    ProductId = categoryProduct.ProductId
                });
            }

            context.CategoriesProducts.AddRange(categoriesProducts);
            int count = context.SaveChanges();

            return $"Successfully imported {count}";
        }

        // Problem 5
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .AsNoTracking()
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new ProductsInRangeDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    Seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                })
                .OrderBy(p => p.Price)
                .ToList();

            return JsonConvert.SerializeObject(products, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }

        // Problem 6
        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                .AsNoTracking()
                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                .Select(u => new UserSoldProducts
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold
                        .Select(p => new SoldProducts
                        {
                            Name = p.Name,
                            Price = p.Price,
                            BuyerFirstName = p.Buyer.FirstName,
                            BuyerLastName = p.Buyer.LastName
                        })
                        .ToList()
                })
                .OrderBy(u => u.FirstName)
                .ThenBy(u => u.LastName)
                .ToList();

            return JsonConvert.SerializeObject(users, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }

        // Problem 7
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .AsNoTracking()
                .Select(c => new CategoryProductsDTO
                {
                    Category = c.Name,
                    ProductsCount = c.CategoriesProducts.Count,
                    AveragePrice = (c.CategoriesProducts.Select(x => x.Product.Price).Sum() / c.CategoriesProducts.Count).ToString("F2"),
                    TotalRevenue = (c.CategoriesProducts.Select(x => x.Product.Price).Sum()).ToString("F2")
                })
                .OrderByDescending(c => c.ProductsCount)
                .ToList();

            return JsonConvert.SerializeObject(categories, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }

        // Problem 8
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .AsNoTracking()
                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                .Select(u => new UsersDTO
                {
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = u.ProductsSold.Select(p => new CountProductsDTO
                    {
                        Count = u.ProductsSold.Count(ps => ps.Buyer != null),
                        Products = u.ProductsSold
                        .Where(ps => ps.Buyer != null)
                        .Select(p => new ProductsDTO
                        {
                            Name = p.Name,
                            Price = p.Price
                        })
                        .ToList()
                    })
                    .ToList()
                })
                .OrderByDescending(u => u.SoldProducts.Count)
                .ToList();

            var result = new
            {
                UsersCount = users.Count,
                Users = users
            };

            return JsonConvert.SerializeObject(result, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }

        //UsersDTO
        //CountProductsDTO
        //ProductsDTO
    }
}