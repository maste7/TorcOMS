using TorcOMS.Data.Context;
using TorcOMS.Domain.Interfaces;
using TorcOMS.Domain.Models;

namespace TorcOMS.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly TorcOMSDbContext _torcOMSDbContext;

        public ProductRepository(TorcOMSDbContext torcOMSDbContext)
        {
            _torcOMSDbContext = torcOMSDbContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _torcOMSDbContext.Products;
        }
    }
}
