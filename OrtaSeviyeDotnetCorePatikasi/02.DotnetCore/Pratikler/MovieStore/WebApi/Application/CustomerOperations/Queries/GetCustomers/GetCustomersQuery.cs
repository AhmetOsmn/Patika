using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.Entities.ViewModels;

namespace WebApi.Application.CustomerOperations.Queries.GetCustomers
{
    public class GetCustomersQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<CustomerViewModel> Handle()
        {
            var customers =   _context.Customers.Where(x => x.IsActive)
                                                .Include(x => x.FavoriteGenres)
                                                .Include(x => x.PurchasedMovies)
                                                .OrderBy(x => x.Id).ToList<Customer>();

            ICollection<CustomerViewModel> listCVM = _mapper.Map<ICollection<CustomerViewModel>>(customers);

            return listCVM;
        }
    }
}