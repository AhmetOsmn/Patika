using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models.Entities.Route;

namespace WebApi.Models.Entities
{
    public class Director
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsActive { get; set; } = true;
        public List<DirectorAndMovie> DirectedMovies { get; set; }
        public int MovieId { get; set; }
        public List<ActorAndMovie> ActedMovies { get; set; }
    }
}