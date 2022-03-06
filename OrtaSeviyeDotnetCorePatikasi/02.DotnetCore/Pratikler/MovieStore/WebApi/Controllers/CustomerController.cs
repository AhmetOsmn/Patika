using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.CustomerOperations.Commands.CreateCustomer;
using WebApi.Application.CustomerOperations.Commands.DeleteCustomer;
using WebApi.Application.CustomerOperations.Queries.GetCustomerDetail;
using WebApi.Application.CustomerOperations.Queries.GetCustomers;
using WebApi.DbOperations;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class CustomerController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

         public CustomerController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            GetCustomersQuery query = new(_context, _mapper);
            var customers = query.Handle();
            return Ok(customers);
        }

        [HttpGet("id")]
        public IActionResult GetCustomer(int id)
        {
            GetCustomerDetailQuery query = new(_context, _mapper);
            GetCustomerDetailQueryValidator validator = new();

            query.CustomerId = id;

            validator.ValidateAndThrow(query);

            var customer = query.Handle();
            return Ok(customer);
        }

        [HttpDelete("id")]
        public IActionResult DeleteCustomer(int id)
        {
            DeleteCustomerCommand command = new(_context);
            DeleteCustomerCommandValidator validator = new();

            command.CustomerId = id;

            validator.ValidateAndThrow(command);
            
            command.Handle();
            
            return Ok();
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] CreateCustomerModel newCustomer)
        {
            CreateCustomerCommand command = new(_context, _mapper);
            CreateCustomerCommandValidator validator = new();

            command.Model = newCustomer;

            validator.ValidateAndThrow(command);

            command.Handle();
            
            return Ok();
        }
    }
}