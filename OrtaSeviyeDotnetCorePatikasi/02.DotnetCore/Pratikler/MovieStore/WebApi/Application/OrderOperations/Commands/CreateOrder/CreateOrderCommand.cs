using AutoMapper;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Application.OrderOperations.Commands.CreateOrder
{
    public class CreateOrderCommand
    {
        private readonly IMovieStoreDbContext _context;
        public CreateOrderModel Model { get; set; }

        public CreateOrderCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            Order order = new()
            {
                PurchasingCustomer = Model.PurchasingCustomer,
                PurchasedMovie = Model.PurchasedMovie,
                Price = Model.Price,
                PurchaseDate = Model.PurchaseDate
            };

            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
