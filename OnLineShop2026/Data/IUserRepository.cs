using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User? TryGetById(Guid id);
    }
}