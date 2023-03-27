﻿namespace ProductShop.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        public Product()
        {
            CategoriesProducts = new List<CategoryProduct>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        [ForeignKey(nameof(Seller))]
        public int SellerId { get; set; }
        public User Seller { get; set; } = null!;

        [ForeignKey(nameof(Buyer))]
        public int? BuyerId { get; set; }
        public User? Buyer { get; set; }

        public ICollection<CategoryProduct> CategoriesProducts { get; set; }
    }
}