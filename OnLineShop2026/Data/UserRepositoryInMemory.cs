using OnLineShop2026.Models;
using System.Text.Json;

namespace OnLineShop2026.Data
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private List<User> users = new()
        {
            new User("Имя1", "Фамилия1", "почта1"),
            new User("Имя2", "Фамилия2", "почта2"),
        };

        public List<User> GetAll()
        {
            return new List<User>(users);
        }

        public User? TryGetById(Guid id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
    }
}
