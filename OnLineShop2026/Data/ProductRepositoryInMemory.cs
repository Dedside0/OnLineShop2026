using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class ProductRepositoryInMemory : IProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Пирожок", "с котятами", 50, "https://cs14.pikabu.ru/post_img/2022/03/21/6/1647856655122391644.jpg"),
            new Product("Чебурек", "с вишней", 80, "https://optim.tildacdn.com/tild3635-3764-4331-b832-633037643133/-/resize/340x/-/format/webp/cheb.png.webp"),
            new Product("Тортик", "медовик", 90, "/images/img_cake.jpg")
        };

        public List<Product> GetAll()
        { 
            return products;
        }

        public Product? TryGetById(Guid id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }
    }
}
