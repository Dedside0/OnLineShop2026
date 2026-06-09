using OnLineShop2026.Models;
using OnlineShopp.DB;

namespace OnLineShop2026.Helpers
{
    public class Mapping
    {
        public static Product ToProduct(ProductDB productDB)
        {
            var product = new Product
            {
                Id = productDB.Id,
                Name = productDB.Name,
                Description = productDB.Description,
                Cost = productDB.Cost,
                PathImage = productDB.PathPicture
            };
            return product;
        }

        public static List<Product> ToListProduct(List<ProductDB> list)
        {
           return list.Select(p => ToProduct(p)).ToList();
        }

    }
}
