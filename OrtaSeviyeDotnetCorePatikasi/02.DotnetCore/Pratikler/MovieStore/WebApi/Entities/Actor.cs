using System.Collections.Generic;
using WebApi.Entities.Route;

namespace WebApi.Entities
{
    public class Actor : Person
    {
        public List<StarringMovie> StarringMoviesIds { get; set; }
    }
}