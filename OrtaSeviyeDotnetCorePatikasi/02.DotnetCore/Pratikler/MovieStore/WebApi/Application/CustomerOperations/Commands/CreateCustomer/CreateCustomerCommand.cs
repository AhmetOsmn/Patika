using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Application.CustomerOperations.Commands.CreateCustomer
{
    public class CreateCustomerCommand
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateCustomerModel Model { get; set; }

        public CreateCustomerCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Email.ToLower() == Model.Email.ToLower());

            if (customer is not null && customer.IsActive == false)
            {
                customer.IsActive = true;
                _context.SaveChanges();
            }
            else if (customer is not null)
            {
                throw new InvalidOperationException("Eklenecek müşteri zaten mevcut.");
            }
            else
            {
                customer = _mapper.Map<Customer>(Model);
                // foreach (var item in Model.PurchasedMovies)
                // {
                //     customer.PurchasedMovies.Add(
                //         new CustomerAndMovie
                //         {
                //             CustomerId = customer.Id,
                //             MovieId = item
                //         }
                //     );
                // }
                // foreach (var item in Model.FavoriteGenres)
                // {
                //     customer.FavoriteGenres.Add(
                //         new CustomerAndGenre
                //         {
                //             CustomerId = customer.Id,
                //             GenreId = item
                //         }
                //     );
                // }
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
        }
    }
}
