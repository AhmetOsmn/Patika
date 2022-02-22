using System;
using System.Linq;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommand
    {
        private readonly IMovieStoreDbContext _context;

        public CreateGenreCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public CreateGenreModel Model { get; set; }

        public void Handle()
        {

            var genre = _context.Genres.SingleOrDefault(x => x.Name.ToLower() == Model.Name.ToLower()); // Db'de aynı isimde genre var mı? Kontrolü
            // varsa
            if (genre is not null && genre.IsActive == false)
            {
                genre.IsActive = true;
                _context.SaveChanges();
            }
            else if (genre is not null)
            {
                throw new InvalidOperationException("Eklenecek film türü zaten mevcut.");
            }
            else
            {
                // yoksa
                genre = new Genre();
                genre.Name = Model.Name;
                _context.Genres.Add(genre); // Db'ye eklendi
                _context.SaveChanges();
            }
        }
    }
}
