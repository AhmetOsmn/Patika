using System;

namespace WebApi.Models.ViewModels.Get
{
    public class OrderViewModel
    {
        public string PurchasingCustomer { get; set; }
        public string PurchasedMovie { get; set; }
        public decimal Price { get; set; }
        public string PurchaseDate { get; set; }
    }
}
