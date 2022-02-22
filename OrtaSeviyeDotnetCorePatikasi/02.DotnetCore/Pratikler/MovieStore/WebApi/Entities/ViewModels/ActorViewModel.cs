using System.Collections.Generic;

namespace WebApi.Entities.ViewModels
{
     public class ActorViewModel
    {
        public string FullName { get; set; }
        // public string Surname { get; set; }
        public ICollection<MovieViewModelForActor> Movies { get; set; }
    }
}