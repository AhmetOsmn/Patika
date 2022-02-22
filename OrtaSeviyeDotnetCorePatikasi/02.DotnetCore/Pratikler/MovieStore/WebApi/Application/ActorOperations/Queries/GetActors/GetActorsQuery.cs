using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.Entities.ViewModels;

namespace WebApi.Application.ActorOperations.Queries.GetActors
{
    public class GetActorsQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetActorsQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<ActorViewModel> Handle()
        {
            var actors = _context.Actors.Where(x => x.IsActive)
                                        .Include(x => x.ActorsAndMovies)
                                        .ThenInclude(y => y.Movie)
                                        .OrderBy(x => x.Id).ToList<Actor>();

            ICollection<ActorViewModel> actorsVM = _mapper.Map<ICollection<ActorViewModel>>(actors);

            return actorsVM;
        }
    }

   

    
}