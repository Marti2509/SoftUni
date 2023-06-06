using DemoASPNET.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace DemoASPNET.Controllers
{
    public class ProductController : Controller
    {
        private IEnumerable<ProductViewModel> _products = new List<ProductViewModel>()
        { 
            new ProductViewModel()
            {
                Id = 1,
                Name = "Cheese",
                Price = 6.80m
            },
            new ProductViewModel()
            {
                Id = 2,
                Name = "Ham",
                Price = 5.50m
            },
            new ProductViewModel()
            {
                Id = 3,
                Name = "Bread",
                Price = 1.99m
            },
            new ProductViewModel()
            {
                Id = 4,
                Name = "Ice Cream",
                Price = 5.99m
            }
        };

        public IActionResult AllProducts(string keyword)
        {
            if (keyword != null)
            {
                var products = _products.Where(x => x.Name.ToLower().Contains(keyword.ToLower()));
                return View(products);
            }

            return View(_products);
        }

        public IActionResult ProductById(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return BadRequest();
            }

            return View(product);
        }

        public IActionResult AllProductsAsJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            return Json(_products, options);
        }

        public IActionResult AllProductsAsText()
        {
            var text = string.Empty;
            foreach (var product in _products)
            {
                text += $"Product {product.Id}: {product.Name} - {product.Price}lv.";
                text += "\r\n";
            }
            return Content(text);
        }

        public IActionResult AllProductsAsTextFile()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in _products)
            {
                sb.AppendLine($"Product {product.Id}: {product.Name} - {product.Price}lv.");
            }

            Response.Headers.Add(HeaderNames.ContentDisposition, @"attachment;filename=products.txt");

            return File(Encoding.UTF8.GetBytes(sb.ToString().Trim()), "text/plain");
        }


    }
}
