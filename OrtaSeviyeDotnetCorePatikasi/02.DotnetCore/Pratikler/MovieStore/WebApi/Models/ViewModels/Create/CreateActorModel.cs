using System.Collections.Generic;

namespace WebApi.Models.ViewModels.Create
{
    public class CreateActorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<int> ActedMovies { get; set; }
    }
}