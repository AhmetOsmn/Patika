using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.MovieOperations.Queries.GetMovieDetail;
using WebApi.Application.MovieOperations.Queries.GetMovies;
using WebApi.DbOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

         public MovieController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            GetMoviesQuery query = new GetMoviesQuery(_context, _mapper);
            var movies = query.Handle();
            return Ok(movies);
        }

        [HttpGet("id")]
        public IActionResult GetMovie(int id)
        {
            GetMovieDetailQuery query = new GetMovieDetailQuery(_context, _mapper);
            GetMovieDetailQueryValidator validator = new GetMovieDetailQueryValidator();

            query.MovieId = id;

            validator.ValidateAndThrow(query);

            var movies = query.Handle();
            return Ok(movies);
        }
    }
}