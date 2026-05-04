using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            var listProducts = productRepository.GetAll();
            return View(listProducts);
        }

    }
}
