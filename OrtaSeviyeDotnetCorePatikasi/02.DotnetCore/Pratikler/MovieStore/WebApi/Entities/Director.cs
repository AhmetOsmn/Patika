using System.Collections.Generic;
using WebApi.Entities.Route;

namespace WebApi.Entities
{
    public class Director : Actor
    {
        public List<DirectedMovie> DirectedMoviesIds { get; set; }
    }
}