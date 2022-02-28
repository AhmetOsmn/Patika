using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.ActorOperations.Commands.CreateActor;
using WebApi.Application.ActorOperations.Commands.DeleteActor;
using WebApi.Application.ActorOperations.Commands.UpdateActor;
using WebApi.Application.ActorOperations.Queries.GetActorDetail;
using WebApi.Application.ActorOperations.Queries.GetActors;
using WebApi.Application.DirectorOperations.Commands.CreateDirector;
using WebApi.Application.DirectorOperations.Commands.DeleteDirector;
using WebApi.Application.DirectorOperations.Commands.UpdateDirector;
using WebApi.Application.DirectorOperations.Queries;
using WebApi.Application.DirectorOperations.Queries.GetDirectorDetail;
using WebApi.DbOperations;
using WebApi.Models.ViewModels.Create;
using WebApi.Models.ViewModels.Update;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class DirectorController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public DirectorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetDirectors()
        {
            GetDirectorsQuery query = new GetDirectorsQuery(_context, _mapper);
            var directors = query.Handle();
            return Ok(directors);
        }

        [HttpGet("id")]
        public IActionResult GetDirector(int id)
        {
            GetDirectorDetailQuery query = new GetDirectorDetailQuery(_context, _mapper);
            GetDirectorDetailQueryValidator validator = new GetDirectorDetailQueryValidator();

            query.DirectorId = id;

            validator.ValidateAndThrow(query);

            var director = query.Handle();

            return Ok(director);
        }

        [HttpPost]
        public IActionResult AddDirector([FromBody] CreateDirectorModel newDirector)
        {
            CreateDirectorCommand command = new CreateDirectorCommand(_context, _mapper);
            CreateDirectorCommandValidator validator = new CreateDirectorCommandValidator();

            command.Model = newDirector;

            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPut("id")]
        public IActionResult UpdateDirector(int id, [FromBody] UpdateDirectorModel updatedDirector)
        {
            UpdateDirectorCommand command = new UpdateDirectorCommand(_context);
            UpdateDirectorCommandValidator validator = new UpdateDirectorCommandValidator();

            command.DirectorId = id;
            command.Model = updatedDirector;

            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult DeleteDirector(int id)
        {
            DeleteDirectorCommand command = new DeleteDirectorCommand(_context);
            DeleteDirectorCommandValidator validator = new DeleteDirectorCommandValidator();

            command.DirectorId = id;

            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }
    }
}