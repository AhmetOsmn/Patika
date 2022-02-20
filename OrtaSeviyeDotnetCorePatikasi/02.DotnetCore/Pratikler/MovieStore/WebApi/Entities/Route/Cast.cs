using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities.Route
{
    public class Cast
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ActorId { get; set; }
    }
}