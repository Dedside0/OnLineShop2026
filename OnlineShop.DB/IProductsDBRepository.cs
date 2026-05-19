namespace OnlineShopp.DB
{
    public interface IProductsDBRepository
    {
        List<ProductDB> GetAll();
        ProductDB TryGetById(Guid id);
        void Add(ProductDB product);
        void Update(ProductDB product);
    }
}
