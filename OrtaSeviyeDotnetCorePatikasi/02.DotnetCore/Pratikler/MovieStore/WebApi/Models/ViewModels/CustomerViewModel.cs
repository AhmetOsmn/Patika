using System.Collections.Generic;
using WebApi.Models.Entities.ViewModels.For;

namespace WebApi.Models.Entities.ViewModels
{
     public class CustomerViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<MovieViewModelForCustomer> PurchasedMovies { get; set; }
        public ICollection<GenreViewModel> FavoriteGenres { get; set; }
    }
}