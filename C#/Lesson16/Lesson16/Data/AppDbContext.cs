using Lesson16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson16.Data
{
    public class AppDbContext
    {
        public AppDbContext()
        {
            if (File.Exists("products.json"))
            {
                var productJson = File.ReadAllText("products.json");
                Products = JsonSerializer.Deserialize<List<Product>>(productJson) ?? new();
            }
            else
                Products = new();
        }

        public List<Product> Products { get; set; }

        public void SaveChanges()
        {
            var productsJson = JsonSerializer.Serialize(Products);
            File.WriteAllText("products.json", productsJson);
        }
    }
}
