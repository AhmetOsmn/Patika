using System.Collections.Generic;

namespace WebApi.Entities.ViewModels
{
    public class DirectorViewModel
    {
        public string Fullname { get; set; }
        public ICollection<MovieViewModelForActor> DirectedMovies { get; set; }
        public ICollection<MovieViewModelForActor> ActedMovies { get; set; }

        
    }
}