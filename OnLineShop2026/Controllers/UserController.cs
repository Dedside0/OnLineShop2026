using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController(IUserRepository userRepository) : Controller
    {
        public IActionResult Index(Guid id)
        {
            User? user = userRepository.TryGetById(id);
            return View(user);
        }

        public IActionResult Catalog()
        {
            var users = userRepository.GetAll();
            return View(users);
        }
    }
}
