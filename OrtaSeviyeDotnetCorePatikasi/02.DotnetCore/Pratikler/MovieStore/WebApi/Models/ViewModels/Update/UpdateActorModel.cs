using System.Collections.Generic;

namespace WebApi.Models.ViewModels.Update
{
    public class UpdateActorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<int> ActedMovies { get; set; }
    }
}
