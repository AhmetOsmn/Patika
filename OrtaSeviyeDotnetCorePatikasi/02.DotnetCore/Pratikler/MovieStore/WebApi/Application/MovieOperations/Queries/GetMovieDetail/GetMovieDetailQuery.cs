using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Models.Entities.ViewModels.Detail;

namespace WebApi.Application.MovieOperations.Queries.GetMovieDetail
{
    public class GetMovieDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int MovieId { get; set; }

        public GetMovieDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public MovieDetailViewModel Handle()
        {
            var movie =  _context.Movies.Include(x => x.Director)
                                        .Include(x => x.Genre)
                                        .Include(x => x.ActorsAndMovies)
                                        .ThenInclude(y => y.Actor)
                                        .SingleOrDefault(x => x.IsActive && x.Id == MovieId);
            if (movie is null)
            {
                throw new InvalidOperationException("Aranan film bulunamadı.");
            }
            return _mapper.Map<MovieDetailViewModel>(movie);
        }
    }
}