using TorcOMS.Domain.Models;

namespace TorcOMS.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Order GetOrderById(long id);
        int CreateOrder(long customerId, long productId, int productQty);
    }
}
