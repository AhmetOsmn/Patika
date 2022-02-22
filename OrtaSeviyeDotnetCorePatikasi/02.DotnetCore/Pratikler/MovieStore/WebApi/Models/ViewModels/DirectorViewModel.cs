using System.Collections.Generic;
using WebApi.Models.Entities.ViewModels.For;

namespace WebApi.Models.Entities.ViewModels
{
    public class DirectorViewModel
    {
        public string Fullname { get; set; }
        public ICollection<MovieViewModelForActor> DirectedMovies { get; set; }
        public ICollection<MovieViewModelForActor> ActedMovies { get; set; }

        
    }
}