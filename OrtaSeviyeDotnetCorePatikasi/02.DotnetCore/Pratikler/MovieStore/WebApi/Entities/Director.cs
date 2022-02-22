using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Entities.Route;

namespace WebApi.Entities
{
    public class Director
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsActive { get; set; } = true;
        public List<DirectorAndMovie> DirectedMovies { get; set; }
        public List<ActorAndMovie> ActedMovies { get; set; }
    }
}