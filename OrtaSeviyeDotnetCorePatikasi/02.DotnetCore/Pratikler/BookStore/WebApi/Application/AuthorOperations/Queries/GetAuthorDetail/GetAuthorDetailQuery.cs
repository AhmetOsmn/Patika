using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQuery
    {
        private readonly IBookStoreDbContext _context;
        private IMapper _mapper;
        public int AuthorId { get; set; }

        public GetAuthorDetailQuery(IMapper mapper, IBookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public AuthorDetailViewModel Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if(author is null)
            {
                throw new InvalidOperationException("Aranan yazar bulunamadı.");
            }
            return _mapper.Map<AuthorDetailViewModel>(author);
        }
    }

    public class AuthorDetailViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDay { get; set; }
    }
}