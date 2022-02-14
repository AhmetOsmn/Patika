using System;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;
using static WebApi.BookOperations.GetBooks.GetBooksQuery;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBookById
    {
        private readonly BookStoreDbContext _context;

        public GetBookById(BookStoreDbContext context)
        {
            _context = context;
        }

        public BooksViewModel Handle(int id)
        {
            var book = _context.Books.Where(book => book.Id == id).SingleOrDefault();
            if(book is null)
            {
                throw new InvalidOperationException("Aranan kitap bulunamadı.");
            }
            
            BooksViewModel requestedBook = new BooksViewModel();
            requestedBook.Title = book.Title;
            requestedBook.Genre = ((GenreEnum)book.GenreId).ToString();
            requestedBook.PageCount = book.PageCount;
            requestedBook.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyy");
            return requestedBook;
        }

    }
}