using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.MovieOperations.Commands.CreateMovie;
using WebApi.Application.MovieOperations.Commands.DeleteMovie;
using WebApi.Application.MovieOperations.Commands.UpdateMovie;
using WebApi.Application.MovieOperations.Queries.GetMovieDetail;
using WebApi.Application.MovieOperations.Queries.GetMovies;
using WebApi.DbOperations;
using WebApi.Models.ViewModels.Create;
using WebApi.Models.ViewModels.Update;

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
            GetMoviesQuery query = new(_context, _mapper);
            var movies = query.Handle();
            return Ok(movies);
        }

        [HttpGet("id")]
        public IActionResult GetMovie(int id)
        {
            GetMovieDetailQuery query = new(_context, _mapper);
            GetMovieDetailQueryValidator validator = new();

            query.MovieId = id;

            validator.ValidateAndThrow(query);

            var movies = query.Handle();
            return Ok(movies);
        }

        [HttpPut("id")]
        public IActionResult UpdateMovie([FromBody] UpdateMovieModel updatedMovie, int id)
        {
            UpdateMovieCommand command = new(_context, _mapper);
            UpdateMovieCommandValidator validator = new();

            command.MovieId = id;
            command.Model = updatedMovie;

            validator.ValidateAndThrow(command);
            
            command.Handle();
            
            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult DeleteMovie(int id)
        {
            DeleteMovieCommand command = new(_context);
            DeleteMovieCommandValidator validator = new();

            command.MovieId = id;

            validator.ValidateAndThrow(command);
            
            command.Handle();
            
            return Ok();
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] CreateMovieModel newMovie)
        {
            CreateMovieCommand command = new(_context);
            CreateMovieCommandValidator validator = new();

            command.Model = newMovie;

            validator.ValidateAndThrow(command);

            command.Handle();
            
            return Ok();
        }
    }
}