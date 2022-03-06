using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.OrderOperations.Commands.CreateOrder;
using WebApi.Application.OrderOperations.Commands.DeleteOrder;
using WebApi.Application.OrderOperations.Queries.GetOrderDetail;
using WebApi.Application.OrderOperations.Queries.GetOrders;
using WebApi.DbOperations;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class OrderController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public OrderController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            GetOrdersQuery query = new(_context, _mapper);
            var customers = query.Handle();
            return Ok(customers);
        }

        [HttpGet("id")]
        public IActionResult GetOrder(int id)
        {
            GetOrderDetailQuery query = new(_context, _mapper);
            GetOrderDetailQueryValidator validator = new();

            query.OrderId = id;

            validator.ValidateAndThrow(query);

            var order = query.Handle();
            return Ok(order);
        }

        [HttpDelete("id")]
        public IActionResult DeleteOrder(int id)
        {
            DeleteOrderCommand command = new(_context);
            DeleteOrderCommandValidator validator = new();

            command.OrderId = id;

            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] CreateOrderModel newOrder)
        {
            CreateOrderCommand command = new(_context);
            CreateOrderCommandValidator validator = new();

            command.Model = newOrder;

            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }
    }
}
