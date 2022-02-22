using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Entities.Route;

namespace WebApi.Entities
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public virtual ICollection<ActorAndMovie> ActorsAndMovies { get; set; } = new List<ActorAndMovie>();
        public int ActorId { get; set; }
        public string Price { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
