using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class AdminController : Controller
    {
        IProductRepository productsRepository;

        public AdminController(IProductRepository prodRep)
        {
            this.productsRepository = prodRep;
        }
        public IActionResult Index()
        {
            return View(productsRepository.GetAll());
        }


        [HttpGet]
        public IActionResult EditProduct(Guid id)
        {
            Product product = productsRepository.TryGetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            productsRepository.Edit(product);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productsRepository.Add(product);
            return RedirectToAction("Index");

        }
    }
}
