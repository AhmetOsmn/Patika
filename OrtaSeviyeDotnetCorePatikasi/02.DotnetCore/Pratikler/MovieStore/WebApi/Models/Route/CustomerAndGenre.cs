
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models.Entities.Route
{
    public class CustomerAndGenre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}