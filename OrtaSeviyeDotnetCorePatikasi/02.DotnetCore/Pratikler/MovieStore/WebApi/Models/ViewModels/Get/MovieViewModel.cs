using System.Collections.Generic;
using WebApi.Models.Entities.ViewModels.For;

namespace WebApi.Models.Entities.ViewModels
{
    public class MovieViewModel
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public GenreViewModel Genre { get; set; }
        public ICollection<DirectorViewModelForMovie> Director { get; set; }
        public string Price { get; set; }
        public ICollection<ActorViewModelForMovie> Actors { get; set; }
    }
}
