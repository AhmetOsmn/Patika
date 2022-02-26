using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models.Entities.Route
{
    public class DirectorAndMovie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }
    }
}