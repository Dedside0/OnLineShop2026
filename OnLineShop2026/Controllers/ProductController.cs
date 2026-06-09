using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class ProductController : Controller
    {
    
        IProductRepository productRepository;

        public ProductController(IProductRepository prodRep)
        {
            this.productRepository = prodRep;
        }

        public IActionResult Index(Guid id)
        {
            var product = productRepository.TryGetById(id);
            if (product == null) return null;
            return View(product);
        }

        //public IActionResult Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    ViewData["pie"] = pie;
        //    return View();
        //}

        //public IActionResult Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    ViewBag.Pie = pie;
        //    return View();
        //}

        //public string Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    return pie.ToString();
        //}
    }
}
