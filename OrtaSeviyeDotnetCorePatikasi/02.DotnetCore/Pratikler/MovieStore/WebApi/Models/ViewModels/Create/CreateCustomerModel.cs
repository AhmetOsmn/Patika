using System.Collections.Generic;

namespace WebApi.Models.ViewModels.Create
{
    public class CreateCustomerModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<int> PurchasedMovies { get; set; }
        public List<int> FavoriteGenres { get; set; }
    }
}