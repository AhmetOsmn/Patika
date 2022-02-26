using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Models.ViewModels.Detail;

namespace WebApi.Application.CustomerOperations.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int CustomerId {get; set;}

        public GetCustomerDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CustomerDetailViewModel Handle()
        {
            var customer = _context.Customers.SingleOrDefault(x =>x.IsActive &&  x.Id == CustomerId);
            if(customer is null)
            {
                throw new InvalidOperationException("Aranan müşteri bulunamadı.");
            }
            return _mapper.Map<CustomerDetailViewModel>(customer);
        }
    }
}