using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.ActorOperations.Commands.CreateActor;
using WebApi.Application.ActorOperations.Commands.DeleteActor;
using WebApi.Application.ActorOperations.Commands.UpdateActor;
using WebApi.Application.ActorOperations.Queries.GetActorDetail;
using WebApi.Application.ActorOperations.Queries.GetActors;
using WebApi.DbOperations;
using WebApi.Models.ViewModels.Create;
using WebApi.Models.ViewModels.Update;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ActorController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public ActorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetActors()
        {
            GetActorsQuery query = new GetActorsQuery(_context, _mapper);
            var actors = query.Handle();
            return Ok(actors);
        }

        [HttpGet("id")]
        public IActionResult GetActor(int id)
        {
            GetActorDetailQuery query = new GetActorDetailQuery(_context, _mapper);
            GetActorDetailQueryValidator validator = new GetActorDetailQueryValidator();

            query.AcorId = id;

            validator.ValidateAndThrow(query);

            var actor = query.Handle();

            return Ok(actor);
        }

        [HttpPost]
        public IActionResult AddActor([FromBody] CreateActorModel newActor)
        {
            CreateActorCommand command = new CreateActorCommand(_context, _mapper);
            CreateActorCommandValidator validator = new CreateActorCommandValidator();

            command.Model = newActor;

            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPut("id")]
        public IActionResult UpdateActor(int id, [FromBody] UpdateActorModel updatedActor)
        {
            UpdateActorCommand command = new UpdateActorCommand(_context);
            UpdateActorCommandValidator validator = new UpdateActorCommandValidator();

            command.ActorId = id;
            command.Model = updatedActor;

            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult DeleteActor(int id)
        {
            DeleteActorCommand command = new DeleteActorCommand(_context);
            DeleteActorCommandValidator validator = new DeleteActorCommandValidator();

            command.ActorId = id;

            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }
    }
}