using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.ViewModels.Get;

namespace WebApi.Application.OrderOperations.Queries.GetOrders
{
    public class GetOrdersQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetOrdersQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<OrderViewModel> Handle()
        {
            var orders = _context.Orders.Include(x => x.Customer)
                                        .Include(x => x.Movie)
                                        .Where(x => x.IsActive).OrderBy(x => x.Id).ToList();

            ICollection<OrderViewModel> ordersVM = _mapper.Map<ICollection<OrderViewModel>>(orders);
            return ordersVM;
        }
    }
}
