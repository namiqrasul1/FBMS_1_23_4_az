using Lesson16.Data;
using Lesson16.Models;
using Lesson16.Repositories;

namespace Lesson16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AppDbContext db = new();

            ////Product product = new()
            ////{
            ////    Name = "Fanta",
            ////    Description = "Sari kola 0.5",
            ////    Price = 1
            ////};


            ////db.Products.Add(product);
            //db.SaveChanges();

            //foreach (var item in db.Products)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name} {item.Description} {item.Price}");
            //}

            //// afc53ebf-20cc-41b4-8827-58687c6ca735
            //// 1c08b6e7-1031-4c5f-81f9-29f469e8d7bc
            //// 1c08b6e7-1031-4c5f-81f9-29f469e8d7bc

            //var p = db.Products.FirstOrDefault(p => p.Id == "afc53ebf-20cc-41b4-8827-58687c6ca735");
            //var p1 = db.Products.FirstOrDefault(p => p.Id == "1c08b6e7-1031-4c5f-81f9-29f469e8d7bc");
            //db.Products.Remove(p);
            //db.Products.Remove(p1);
            //db.SaveChanges();
            //Console.WriteLine("after delete");
            //foreach (var item in db.Products)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name} {item.Description} {item.Price}");
            //}

            //Repository<Product> repo = new();

            //foreach(var item in repo.GetAllProducts())
            //{
            //    Console.WriteLine(item);
            //}

            //repo.RemoveProduct("7f4e571f-354f-4e46-97b8-945f6ef4f8e8");

            //Console.WriteLine("after deletion");

            //foreach (var item in repo.GetAllProducts())
            //{
            //    Console.WriteLine(item);
            //}

            Type type = typeof(Product);
            Console.WriteLine(type.Name);
        }
    }
}