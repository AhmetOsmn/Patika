using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Route
{
    public class CustomerAndMovie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public Movie Movie { get; set; }
        public Customer Customer { get; set; }
    }
}