using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Queries.GetBooks
{
    public class GetAuthorQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorQuery(IMapper mapper, BookStoreDbContext context = null)
        {
            _mapper = mapper;
            _context = context;
        }

        public List<AuthorsViewModel> Handle(){
            var authorList = _context.Authors.OrderBy(author => author.Id).ToList<Author>();
            List<AuthorsViewModel> vm = _mapper.Map<List<AuthorsViewModel>>(authorList);

            return vm;
        }
    }

    public class AuthorsViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
    }
}