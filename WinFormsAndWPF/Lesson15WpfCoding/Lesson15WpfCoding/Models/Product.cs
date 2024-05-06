using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15WpfCoding.Models
{
    public class Product
    {
        // CRUD (Create, Read, Update, Delete)
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Price { get; set; }


        public Product Clone() => new() { Id = Id, Name = Name, Price = Price, Quantity = Quantity };
    }
}
