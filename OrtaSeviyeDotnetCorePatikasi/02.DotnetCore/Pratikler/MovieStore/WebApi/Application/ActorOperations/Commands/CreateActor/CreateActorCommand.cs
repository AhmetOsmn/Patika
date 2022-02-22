using System;
using System.Linq;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Application.ActorOperations.Commands.CreateActor
{
    public class CreateActorCommand
    {
        private readonly IMovieStoreDbContext _context;
        public CreateActorModel Model { get; set; }

        public CreateActorCommand(IMovieStoreDbContext context)
        {
            _context = context;
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
                actor = new Actor();
                actor.Name = Model.Name;
                actor.Surname = Model.Surname;
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