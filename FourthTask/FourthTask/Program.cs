using System;
using System.Collections.Generic;
using System.Linq;

namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductName = "Dell Laptop", ProductPrice = 1200 },
                new Product { ProductName = "HP Laptop", ProductPrice = 850 },
                new Product { ProductName = "Lenovo Laptop", ProductPrice = 950 },
                new Product { ProductName = "Asus Laptop", ProductPrice = 1100 },
                new Product { ProductName = "Acer Laptop", ProductPrice = 700 },
                new Product { ProductName = "MacBook Air", ProductPrice = 1300 },
                new Product { ProductName = "MacBook Pro", ProductPrice = 2000 },
                new Product { ProductName = "MSI Laptop", ProductPrice = 1500 },
                new Product { ProductName = "Razer Blade", ProductPrice = 2200 },
                new Product { ProductName = "Samsung Galaxy Book", ProductPrice = 1000 }
            };

            var orderedProducts = products.Where(p => p.ProductPrice > 1000);

            foreach (var product in orderedProducts)
            {
                Console.WriteLine($"Product: {product.ProductName}      Price: {product.ProductPrice}");
            }
        }
    }
}