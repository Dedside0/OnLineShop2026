using Microsoft.EntityFrameworkCore;

namespace OnlineShopp.DB
{
    public class ProductsDBRepository: IProductsDBRepository
    {
        private readonly DatabaseContext dbContext;
        public ProductsDBRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        void IProductsDBRepository.Add(ProductDB product)
        {
            throw new NotImplementedException();
        }

        List<ProductDB> IProductsDBRepository.GetAll()
        {
            var temp = dbContext.ProductDBs;
            if (temp != null)
                return temp.ToList();
            return null;
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
