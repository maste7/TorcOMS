using TorcOMS.Domain.Models;

namespace TorcOMS.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
