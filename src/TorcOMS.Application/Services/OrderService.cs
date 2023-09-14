using TorcOMS.Domain.Interfaces;
using TorcOMS.Domain.Models;
using TorcOMS.Application.Interfaces;
using TorcOMS.Application.Models;

namespace TorcOMS.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order GetOrderById(long id)
        {
            return _orderRepository.GetOrderById(id);
        }

        public int CreateOrder(NewOrder order)
        {
            return _orderRepository.CreateOrder(order.CustomerId, order.ProductId, order.ProductQty);
        }
    }
}
