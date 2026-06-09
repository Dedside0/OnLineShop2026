using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public interface ICartRepository
    {
        public Cart? TryGetByUserId(int userId);
        public void Increment(Product product, int idUser);

        public void Decrement(Product product, int idUser);
        public void Add(Product product, int idUser);
    }
}