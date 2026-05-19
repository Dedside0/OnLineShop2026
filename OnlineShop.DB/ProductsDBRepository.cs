using Microsoft.EntityFrameworkCore;

namespace OnlineShop.DB
{
    public class ProductsDBRepository:IProductsDBRepository
    {
        private readonly DatabaseContext dbContext;
        public ProductsDBRepository(DatabaseContext dbContext)
        {
            dbContext = dbContext;
        }

        public List<ProductDB> GetAll()
        {
            return dbContext.ProductDBs.ToList();
        }

    }
}
