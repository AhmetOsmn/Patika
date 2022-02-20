
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Route
{
    public class FavoriteGenre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GenreId { get; set; }
    }
}