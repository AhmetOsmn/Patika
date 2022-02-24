namespace WebApi.Models.ViewModels.Update
{
    public class UpdateMovieModel
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }
        public int DirectorId { get; set; }
        public decimal Price { get; set; }
        
    }
}