using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Models.Entities.ViewModels.Detail;

namespace WebApi.Application.GenreOperations.Queries.GetGenreDetail
{
    public class GetGenreDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int GenreId {get; set;}

        public GetGenreDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GenreDetailViewModel Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x =>x.IsActive &&  x.Id == GenreId);
            if(genre is null)
            {
                throw new InvalidOperationException("Aranan film türü bulunamadı.");
            }
            return _mapper.Map<GenreDetailViewModel>(genre);
        }
    }

}