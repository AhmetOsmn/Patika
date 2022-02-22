using System.Collections.Generic;
using WebApi.Models.Entities.ViewModels.For;

namespace WebApi.Models.Entities.ViewModels.Detail
{
    public class ActorDetailViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<MovieViewModelForActor> Movies { get; set; }        
    }
}