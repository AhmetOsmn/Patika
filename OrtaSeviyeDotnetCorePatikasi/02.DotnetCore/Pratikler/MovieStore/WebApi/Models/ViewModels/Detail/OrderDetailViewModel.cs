namespace WebApi.Models.ViewModels.Detail
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }
        public string PurchasingCustomer { get; set; }
        public string PurchasedMovie { get; set; }
        public decimal Price { get; set; }
        public string PurchaseDate { get; set; }
        public bool IsActive { get; set; }
    }
}
