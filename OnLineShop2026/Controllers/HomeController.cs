using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;
using OnlineShopp.DB;

namespace OnLineShop2026.Controllers
{
    public class HomeController : Controller
    {
        IProductsDBRepository productRepository;

        public HomeController(IProductsDBRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            List<ProductDB> listProducts = productRepository.GetAll();
            return View(listProducts);
        }

    }
}
