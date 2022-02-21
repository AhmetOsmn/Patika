using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Route
{
    public class ActorAndMovie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Actor Actor { get; set; }
    }
}