using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models.Entities.Route;

namespace WebApi.Models.Entities
{
    public class Actor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<ActorAndMovie> ActorsAndMovies { get; set; } = new List<ActorAndMovie>();
        public int MovieId { get; set; }

    }
}