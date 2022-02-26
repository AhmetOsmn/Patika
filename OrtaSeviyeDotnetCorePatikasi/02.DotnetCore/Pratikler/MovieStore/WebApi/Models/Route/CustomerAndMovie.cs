using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models.Entities.Route
{
    public class CustomerAndMovie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Customer Customer { get; set; }
    }
}