﻿namespace SimpleApp.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; }

        public static Product[] GetProducts()
        {
            Product Kayak = new Product
            {
                Name = "Kayak",
                Price = 275M
            };

            Product Lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            return new Product[] { Kayak, Lifejacket };
        }
    }
}
