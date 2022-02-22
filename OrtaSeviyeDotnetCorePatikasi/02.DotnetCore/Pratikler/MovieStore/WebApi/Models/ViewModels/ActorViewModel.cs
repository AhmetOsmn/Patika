using System.Collections.Generic;
using WebApi.Models.Entities.ViewModels.For;

namespace WebApi.Models.Entities.ViewModels
{
     public class ActorViewModel
    {
        public string FullName { get; set; }
        // public string Surname { get; set; }
        public ICollection<MovieViewModelForActor> Movies { get; set; }
    }
}