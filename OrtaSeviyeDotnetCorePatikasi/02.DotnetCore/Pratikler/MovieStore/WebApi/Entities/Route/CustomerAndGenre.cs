
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Route
{
    public class CustomerAndGenre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int CustomerId { get; set; }
        public Genre Genre { get; set; }
        public Customer Customer { get; set; }
    }
}