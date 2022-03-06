using System;

namespace WebApi.Models.ViewModels.Create
{
    public class CreateOrderModel
    {
        public int PurchasingCustomer { get; set; }
        public int PurchasedMovie { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
    }
}
