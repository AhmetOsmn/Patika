using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        public int AuthorId { get; set; }
        private readonly IBookStoreDbContext _context;

        public DeleteAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var author = _context.Authors.FirstOrDefault(x => x.Id == AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Silinecek yazar bulunamadı.");
            }
            if ((_context.Books.FirstOrDefault(book => book.AuthorId == author.Id)) is not null)
            {
                throw new InvalidOperationException("Kitabı yayında olan yazar silinemez.");
            }
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}