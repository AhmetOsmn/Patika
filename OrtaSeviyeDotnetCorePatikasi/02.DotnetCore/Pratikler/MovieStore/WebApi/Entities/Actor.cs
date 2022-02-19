using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Actor : Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public List<int> StarringMoviesIds { get; set; }
    }
}