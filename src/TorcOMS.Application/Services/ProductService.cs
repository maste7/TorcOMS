using TorcOMS.Domain.Interfaces;
using TorcOMS.Domain.Models;
using TorcOMS.Application.Interfaces;

namespace TorcOMS.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
