using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;

namespace WebApi.Application.BookOperations.Queries.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public BookDetailViewModel Handle()
        {
            var book = _context.Books.Include(x => x.Genre).Include(x => x.Author).Where(book => book.Id == BookId).SingleOrDefault();
            if (book is null)
            {
                throw new InvalidOperationException("Aranan kitap bulunamadı.");
            }

            BookDetailViewModel requestedBook = _mapper.Map<BookDetailViewModel>(book);
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