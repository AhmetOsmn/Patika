using System;
using System.Linq;
using WebApi.DbOperations;
using WebApi.Models.Entities.Route;
using WebApi.Models.ViewModels.Update;

namespace WebApi.Application.ActorOperations.Commands.UpdateActor
{
    public class UpdateActorCommand
    {
        public int ActorId { get; set; }
        public UpdateActorModel Model { get; set; }
        private readonly IMovieStoreDbContext _context;

        public UpdateActorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.Id == ActorId);
            if (actor is null || actor.IsActive == false)
            {
                throw new InvalidOperationException("Güncellenecek aktör bulunamadı.");
            }
            else if (_context.Actors.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Surname.ToLower() == Model.Surname.ToLower() && x.Id != ActorId && x.IsActive))
            {
                throw new InvalidOperationException("Aynı isim ve soyisimli aktör mevcut.");
            }
            else
            {
                actor.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? actor.Name : Model.Name;
                actor.Surname = string.IsNullOrEmpty(Model.Surname.Trim()) ? actor.Surname : Model.Surname;

                // Bu kisim refactor edilebilir - bu hali ile temizleme yapmiyor
                actor.ActorsAndMovies.Clear(); // bos listeye esitlenip, alt kisimda tekrar doldurulabilir

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
                _context.SaveChanges();
            }
        }
    }
}