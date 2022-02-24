using System.Collections.Generic;

namespace WebApi.Models.ViewModels.Create
{
     public class CreateMovieModel
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }
        public int DirectorId { get; set; }
        public decimal Price { get; set; }
        public List<int> Actors { get; set; }
        

    }
}