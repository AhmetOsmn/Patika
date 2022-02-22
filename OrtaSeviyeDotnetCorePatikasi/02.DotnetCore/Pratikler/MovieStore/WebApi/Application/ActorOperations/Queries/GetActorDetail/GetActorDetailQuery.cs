using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Models.Entities.ViewModels.Detail;

namespace WebApi.Application.ActorOperations.Queries.GetActorDetail
{
    public class GetActorDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;   
        public int AcorId {get; set;}

        public GetActorDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ActorDetailViewModel Handle()
        {
            var actor = _context.Actors.Include(x => x.ActorsAndMovies)
                                        .ThenInclude(y => y.Movie)
                                        .SingleOrDefault(x => x.IsActive && x.Id == AcorId);
                                        
            if(actor is null)
            {
                throw new InvalidOperationException("Aranan aktör bulunamadı.");
            }
            return _mapper.Map<ActorDetailViewModel>(actor);
        }
    }
} 