using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.DeleteGenre
{
    public class DeleteGenreCommand
    {
        public int GenreId { get; set; }
        private readonly IBookStoreDbContext _context;

        public DeleteGenreCommand(IBookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(genre => genre.Id == GenreId);
            if (genre is null)
            {
                throw new InvalidOperationException("Silinecek kitap türü bulunamadı.");
            }

            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }

    }
}