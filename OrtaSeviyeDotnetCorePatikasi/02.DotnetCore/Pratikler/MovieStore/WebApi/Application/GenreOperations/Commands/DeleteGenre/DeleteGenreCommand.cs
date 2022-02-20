using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.Application.GenreOperations.Commands.DeleteGenre
{
    public class DeleteGenreCommand
    {
        private readonly IMovieStoreDbContext _context;
        public int GenreId {get; set;}

        public DeleteGenreCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle(){

            var genre = _context.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenreId);
            
            // Db'de yoksa
            if(genre is null)
            {
                throw new InvalidOperationException("Silinecek film türü bulunamadı");
            }

            // varsa
            // _context.Genres.Remove(genre); // Db'den gercek silme
            genre.IsActive = false; // Silme işlemi yapmadan pasif yaptık
            _context.SaveChanges();
        }
    }
}