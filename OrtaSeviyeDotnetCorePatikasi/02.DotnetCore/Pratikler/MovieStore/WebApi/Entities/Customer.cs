using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Entities.Route;

namespace WebApi.Entities
{
    public class Customer 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsActive { get; set; } = true;
        public List<CustomerAndMovie> CustomerAndMovies { get; set; }
        public List<CustomerAndGenre> CustomerAndGenres { get; set; }
    }
}