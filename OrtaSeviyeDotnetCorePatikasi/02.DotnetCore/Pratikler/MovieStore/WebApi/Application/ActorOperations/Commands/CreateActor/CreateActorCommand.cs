using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Application.ActorOperations.Commands.CreateActor
{
    public class CreateActorCommand
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateActorModel Model { get; set; }

        public CreateActorCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.Name.ToLower() == Model.Name.ToLower() && x.Surname.ToLower() == Model.Surname.ToLower());

            if (actor is not null && actor.IsActive == false)
            {
                actor.IsActive = true;
                _context.SaveChanges();
            }
            else if (actor is not null)
            {
                throw new InvalidOperationException("Eklenecek aktör zaten mevcut.");
            }
            else
            {
                actor = _mapper.Map<Actor>(Model);

                foreach (var item in Model.ActedMovies)
                {
                    actor.ActorsAndMovies.Add(
                        new ActorAndMovie
                        {
                            ActorId = actor.Id,
                            MovieId = item
                        }
                    );
                }

                _context.Actors.Add(actor);
                _context.SaveChanges();
            }
        }

    }
}