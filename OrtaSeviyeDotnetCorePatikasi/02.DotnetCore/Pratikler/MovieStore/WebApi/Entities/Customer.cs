using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Customer : Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public List<int> PurchasedMoviesIds { get; set; }
        public List<int> FavoriteGenresIds { get; set; }
    }
}