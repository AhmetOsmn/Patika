using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models.Entities.Route;
using WebApi.Models.Entities.ViewModels;
using WebApi.Models.Entities.ViewModels.For;

namespace WebApi.Models.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsActive { get; set; } = true;
        public List<CustomerAndMovie> PurchasedMovies{ get; set; }
        public int MovieId { get; set; }
        public List<CustomerAndGenre> FavoriteGenres { get; set; }
        public int GenreId { get; set; }
    }
}