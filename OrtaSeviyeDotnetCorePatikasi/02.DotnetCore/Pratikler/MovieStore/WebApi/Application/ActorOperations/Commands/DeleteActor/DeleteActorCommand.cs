using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.Application.ActorOperations.Commands.DeleteActor
{
    public class DeleteActorCommand
    {
        private readonly IMovieStoreDbContext _context;
        public int ActorId {get; set;}

        public DeleteActorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle(){

            var actor = _context.Actors.SingleOrDefault(x => x.IsActive && x.Id == ActorId);
            
            if(actor is null)
            {
                throw new InvalidOperationException("Silinecek aktör bulunamadı");
            }

            actor.IsActive = false; 
            _context.SaveChanges();
        }
    }
}