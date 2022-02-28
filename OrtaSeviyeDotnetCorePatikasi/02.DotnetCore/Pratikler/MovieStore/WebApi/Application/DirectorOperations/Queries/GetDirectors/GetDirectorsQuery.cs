using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.Entities.ViewModels;

namespace WebApi.Application.DirectorOperations.Queries
{
    public class GetDirectorsQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetDirectorsQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<DirectorViewModel> Handle()
        {
            var directors = _context.Directors.Where(x => x.IsActive)
                                              .Include(x => x.DirectedMovies)
                                              .ThenInclude(y => y.Movie)
                                              .Include(x => x.ActorsAndMovies)
                                              .ThenInclude(y => y.Movie)
                                              .OrderBy(x => x.Id).ToList<Director>();

            ICollection<DirectorViewModel> directorsVM = _mapper.Map<ICollection<DirectorViewModel>>(directors);

            return directorsVM;
        }
    }
}