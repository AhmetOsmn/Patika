using System;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;
using static WebApi.BookOperations.GetBooks.GetBooksQuery;

namespace WebApi.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDbContext _context;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext context)
        {
            _context = context;
        }

        public BookDetailViewModel Handle()
        {
            var book = _context.Books.Where(book => book.Id == BookId).SingleOrDefault();
            if (book is null)
            {
                throw new InvalidOperationException("Aranan kitap bulunamadı.");
            }

            BookDetailViewModel requestedBook = new BookDetailViewModel();
            requestedBook.Title = book.Title;
            requestedBook.Genre = ((GenreEnum)book.GenreId).ToString();
            requestedBook.PageCount = book.PageCount;
            requestedBook.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyy");
            return requestedBook;
        }

    }

    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}