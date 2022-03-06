using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApi.DbOperations;
using WebApi.Models.ViewModels.Detail;

namespace WebApi.Application.OrderOperations.Queries.GetOrderDetail
{
    public class GetOrderDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int OrderId { get; set; }

        public GetOrderDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public OrderDetailViewModel Handle()
        {
            var order = _context.Orders.Include(x => x.Customer)
                                        .Include(x => x.Movie)
                                        .SingleOrDefault(x => x.IsActive && x.Id == OrderId);
            if (order is null)
            {
                throw new InvalidOperationException("Aranan sipariş bulunamadı.");
            }

            var result = _mapper.Map<OrderDetailViewModel>(order);
            return result;
        }
    }
}
