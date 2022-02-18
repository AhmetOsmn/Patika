using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly IBookStoreDbContext _context;

        public int BookId { get; set; }

        public DeleteBookCommand(IBookStoreDbContext contex)
        {
            _context = contex;
        }

        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == BookId);
            if (book is null)
            {
                throw new InvalidOperationException("Silinecek kitap bulunamadı.");
            }
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}