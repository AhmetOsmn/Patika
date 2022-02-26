using System.Collections.Generic;
using WebApi.Models.Entities.ViewModels;
using WebApi.Models.Entities.ViewModels.For;

namespace WebApi.Models.ViewModels.Detail
{
    public class CustomerDetailViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public ICollection<MovieViewModelForCustomer> PurchasedMovies { get; set; }
        public ICollection<GenreViewModel> FavoriteGenres { get; set; }
    }
}