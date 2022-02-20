using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Route
{
    public class MovieRouter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
    }
}