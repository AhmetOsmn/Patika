using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        public int AuthorId { get; set; }
        private readonly BookStoreDbContext _context;

        public DeleteAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle(){
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if(author is null){
                throw new InvalidOperationException("Silinecek yazar bulunamadı.");
            }
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}