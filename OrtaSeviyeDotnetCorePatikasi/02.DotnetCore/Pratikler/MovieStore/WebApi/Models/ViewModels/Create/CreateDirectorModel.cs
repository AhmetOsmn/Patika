using System.Collections.Generic;

namespace WebApi.Models.ViewModels.Create
{
    public class CreateDirectorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<int> DirectedMovies { get; set; }
        public List<int> ActedMovies { get; set; }
    }
}