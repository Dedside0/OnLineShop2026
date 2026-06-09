using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class CartController : Controller
    {

        IProductRepository productRepository;
        ICartRepository cartRepository;
        int idUser = 0; 

        public CartController(IProductRepository prodRep, ICartRepository cartRep)
        {
            this.productRepository = prodRep;
            this.cartRepository = cartRep;
        }

        public IActionResult Index(int idUser)
        {
            var userCart = cartRepository.TryGetByUserId(idUser);
            return View(userCart);
        }

        public IActionResult Add(Guid idProduct)
        {
            var product = productRepository.TryGetById(idProduct);
            cartRepository.Add(product, idUser);
            return RedirectToAction("Index"); 
        }
        public IActionResult Increment(Guid id)
        {
            var product = productRepository.TryGetById(id);
            cartRepository.Increment(product, idUser);
            return RedirectToAction("Index");
        }

        public IActionResult Decrement(Guid id)
        {
            var product = productRepository.TryGetById(id);
            cartRepository.Decrement(product, idUser);
            return RedirectToAction("Index");
        }
    }
}
