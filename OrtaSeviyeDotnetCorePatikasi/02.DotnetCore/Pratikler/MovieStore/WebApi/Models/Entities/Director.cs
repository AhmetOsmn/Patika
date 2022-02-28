using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models.Entities.Route;

namespace WebApi.Models.Entities
{
    public class Director : Actor
    {
        public ICollection<DirectorAndMovie> DirectedMovies { get; set; } = new List<DirectorAndMovie>();

    }
}