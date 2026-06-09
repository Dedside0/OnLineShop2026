using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? TryGetById(Guid id);
        void Add(Product product);
        void Edit(Product product);
    }
}