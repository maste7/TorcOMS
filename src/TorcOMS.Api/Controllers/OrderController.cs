using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TorcOMS.Domain.Models;
using TorcOMS.Application.Interfaces;
using TorcOMS.Application.Models;

namespace TorcOMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("GetOrderById/{id}")]
        public ActionResult<Order> GetOrderById(long id)
        {
            var order = _orderService.GetOrderById(id);

            if(order == null) 
                return NotFound("Order was not found.");

            return Ok(order);
        }

        [HttpPost]
        [Route("Create")]
        [Authorize]
        public IActionResult CreateOrder([FromBody] NewOrder newOrder)
        {
            if (_orderService.CreateOrder(newOrder) < 1)
                return BadRequest("Invalid order, please verify information."); 

            return Ok("Order created");
        }
    }
}
