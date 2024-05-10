using Lesson15WpfCoding.Models;
using System.Collections.ObjectModel;

namespace Lesson15WpfCoding.Data;

public  class AppDbContext
{
    public ObservableCollection<Product> Products { get; set; } = new() { new Product(), new Product() };

    public Product? GetProduct(string productId)
    {
        return Products.FirstOrDefault(p => p.Id == productId);
    }

    public void AddProduct(Product product) => Products.Add(product);

    public void RemoveProduct(Product product) => Products.Remove(product); 

    public void RemoveProduct(string id)
    {
        var product = Products.FirstOrDefault(x => x.Id == id);
        if(product is not null)
            Products.Remove(product);
    }

    public void UpdateProduct(Product product)
    {
        RemoveProduct(product.Id);
        Products.Add(product);
    }

}
