using Microsoft.EntityFrameworkCore;
using TorcOMS.Data.Context;
using TorcOMS.Domain.Interfaces;
using TorcOMS.Domain.Models;

namespace TorcOMS.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TorcOMSDbContext _torcOMSDbContext;

        public OrderRepository(TorcOMSDbContext torcOMSDbContext)
        {
            _torcOMSDbContext = torcOMSDbContext;
        }

        public Order GetOrderById(long id)
        {
            return _torcOMSDbContext.Orders.FirstOrDefault(o => o.Id == id);
        }

        public int CreateOrder(long customerId, long productId, int productQty)
        {
            return _torcOMSDbContext.Database.ExecuteSqlInterpolated(
                $"EXEC CreateOrder @CustomerId={customerId}, @ProductId={productId}, @ProductQty={productQty}");
        }
    }
}
