using System.Collections.Generic;
using WebApi.Models.Entities.ViewModels.For;

namespace WebApi.Models.Entities.ViewModels.Detail
{
    public class DirectorDetailViewModel
    {
        public string Fullname { get; set; }
        public ICollection<MovieViewModelForActor> DirectedMovies { get; set; }
        public ICollection<MovieViewModelForActor> ActedMovies { get; set; }
    }
}