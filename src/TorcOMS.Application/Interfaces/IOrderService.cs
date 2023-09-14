using TorcOMS.Domain.Models;
using TorcOMS.Application.Models;

namespace TorcOMS.Application.Interfaces
{
    public interface IOrderService
    {
        Order GetOrderById(long id);
        int CreateOrder(NewOrder order);
    }
}
