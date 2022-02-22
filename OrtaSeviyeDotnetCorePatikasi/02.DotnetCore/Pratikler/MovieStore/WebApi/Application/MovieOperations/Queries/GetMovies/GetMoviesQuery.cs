using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.Entities.Route;
using WebApi.Entities.ViewModels;

namespace WebApi.Application.MovieOperations.Queries.GetMovies
{
    public class GetMoviesQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetMoviesQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<MovieViewModel> Handle()
        {
            var movies = _context.Movies.Where(x => x.IsActive)
                                        .Include(x => x.Genre)
                                        .Include(x => x.Director)
                                        .Include(x => x.ActorsAndMovies)
                                        .ThenInclude(y => y.Actor)
                                        .OrderBy(x => x.Id).ToList<Movie>();

            ICollection<MovieViewModel> moviesVM = _mapper.Map<ICollection<MovieViewModel>>(movies);
            return moviesVM;
        }
    }

}