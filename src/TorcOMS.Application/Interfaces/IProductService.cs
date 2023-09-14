using TorcOMS.Domain.Models;

namespace TorcOMS.Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
