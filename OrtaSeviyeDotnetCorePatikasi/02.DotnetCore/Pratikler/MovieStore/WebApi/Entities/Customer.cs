using System.Collections.Generic;
using WebApi.Entities.Route;

namespace WebApi.Entities
{
    public class Customer : Person
    {
        public List<PurchasedMovie> PurchasedMoviesIds { get; set; }
        public List<FavoriteGenre> FavoriteGenresIds { get; set; }
    }
}