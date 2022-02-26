using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models.Entities.Route;

namespace WebApi.Models.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public List<CustomerAndMovie> PurchasedMovies{ get; set; } = new List<CustomerAndMovie>();
        public int MovieId { get; set; }
        public List<CustomerAndGenre> FavoriteGenres { get; set; }= new List<CustomerAndGenre>();
        public int GenreId { get; set; }
    }
}