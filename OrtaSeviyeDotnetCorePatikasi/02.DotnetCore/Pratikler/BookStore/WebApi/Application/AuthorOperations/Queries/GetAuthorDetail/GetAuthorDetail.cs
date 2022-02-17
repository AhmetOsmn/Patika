using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetail
    {
        private readonly BookStoreDbContext _context;
        private IMapper _mapper;
        public int AuthorId { get; set; }

        public GetAuthorDetail(IMapper mapper, BookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public AuthorDetailModel Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if(author is null)
            {
                throw new InvalidOperationException("Yazar bulunamadı.");
            }
            return _mapper.Map<AuthorDetailModel>(author);
        }
    }

    public class AuthorDetailModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDay { get; set; }
    }
}