using System;
using System.Linq;
using WebApi.DbOperations;
using WebApi.Models.ViewModels.Update;

namespace WebApi.Application.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommand
    {
        public int GenreId { get; set; }
        public UpdateGenreModel Model { get; set; }
        private readonly IMovieStoreDbContext _context;

        public UpdateGenreCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.Id == GenreId);
            if (genre is null || genre.IsActive == false)
            {
                throw new InvalidOperationException("Güncellenecek film türü bulunamadı.");
            }
            else if (_context.Genres.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Id != GenreId && x.IsActive))
            {
                throw new InvalidOperationException("Aynı isimli film türü mevcut.");
            }
            else
            {
                genre.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? genre.Name : Model.Name;
                _context.SaveChanges();
            }
        }
    }
}