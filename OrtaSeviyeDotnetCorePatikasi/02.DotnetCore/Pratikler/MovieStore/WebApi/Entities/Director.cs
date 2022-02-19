using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Director : Actor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public List<int> DirectedMoviesIds { get; set; }

    }
}