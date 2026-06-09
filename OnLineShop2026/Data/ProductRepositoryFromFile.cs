using OnLineShop2026.Models;
using System.Text.Json;

namespace OnLineShop2026.Data
{
    public class ProductRepositoryFromFile : IProductRepository
    {
        private static List<Product> products = new List<Product>();

        public ProductRepositoryFromFile()
        {
            string jsonString = File.ReadAllText("Data/products.json");
            products = JsonSerializer.Deserialize<List<Product>>(jsonString);
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product? TryGetById(Guid id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Edit(Product product)
        {
            Product editProduct = TryGetById(product.Id);
            editProduct.Name = product.Name;
            editProduct.Description = product.Description;
            editProduct.PathImage = product.PathImage;
        }
    }
}
