using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Models.Entities.ViewModels.Detail;

namespace WebApi.Application.DirectorOperations.Queries.GetDirectorDetail
{
    public class GetDirectorDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int DirectorId { get; set; }

        public GetDirectorDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public DirectorDetailViewModel Handle()
        {
            var director = _context.Directors.Include(x => x.DirectedMovies)
                                             .ThenInclude(y => y.Movie)
                                             .Include(x => x.ActedMovies)
                                             .ThenInclude(y => y.Movie)
                                             .SingleOrDefault(x => x.IsActive && x.Id == DirectorId);

            if (director is null)
            {
                throw new InvalidOperationException("Aranan yönetmen bulunamadı.");
            }
            return _mapper.Map<DirectorDetailViewModel>(director);
        }
    }
}