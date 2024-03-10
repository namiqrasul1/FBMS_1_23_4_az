using Lesson16.Data;
using Lesson16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Repositories
{
    public class Repository<T>
    {
        private readonly AppDbContext _context;

        public Repository()
        {
            _context = new AppDbContext();
        }

        public List<Product> GetAllProducts() => _context.Products;
        public Product? GetProduct(string id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public bool RemoveProduct(string id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product is null) return false;

            _context.Products.Remove(product);
            return true;
        }
    }
}
