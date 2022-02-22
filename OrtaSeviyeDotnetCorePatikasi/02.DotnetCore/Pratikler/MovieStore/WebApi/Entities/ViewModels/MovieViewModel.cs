using System;
using System.Collections.Generic;

namespace WebApi.Entities.ViewModels
{
    public class MovieViewModel
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public GenreViewModel Genre { get; set; }
        public DirectorViewModelForMovie Director { get; set; }
        public string Price { get; set; }
        public ICollection<ActorViewModelForMovie> Actors { get; set; }
    }
}