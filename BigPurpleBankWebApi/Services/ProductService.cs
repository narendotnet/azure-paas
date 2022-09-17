using BigPurpleBankWebApi.Models;

namespace BigPurpleBankWebApi.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => Data.products.ToList();
    }
}
