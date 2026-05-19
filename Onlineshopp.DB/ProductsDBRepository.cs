using Microsoft.EntityFrameworkCore;

namespace OnlineShopp.DB
{
    public class ProductsDBRepository: IProductsDBRepository
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

        void IProductsDBRepository.Add(ProductDB product)
        {
            throw new NotImplementedException();
        }

        List<ProductDB> IProductsDBRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        ProductDB IProductsDBRepository.TryGetById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IProductsDBRepository.Update(ProductDB product)
        {
            throw new NotImplementedException();
        }
    }
}
