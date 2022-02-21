using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Route
{
    public class DirectorAndMovie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int DirectorId { get; set; }
        public Movie Movie { get; set; }
        public Director Director { get; set; }
    }
}