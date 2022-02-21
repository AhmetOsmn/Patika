using AutoMapper;
using WebApi.Application.ActorOperations.Queries.GetActors;
using WebApi.Application.GenreOperations.Queries.GetGenreDetail;
using WebApi.Application.GenreOperations.Queries.GetGenres;
using WebApi.Entities;
using WebApi.Entities.Route;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();

            CreateMap<Actor, ActorViewModel>()
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.ActorsAndMovies))
                .AfterMap((model, entity) =>
                {
                    foreach (var entityActorAndMovie in model.ActorsAndMovies)
                    {
                        entityActorAndMovie.Actor = model;
                    }
                });

            CreateMap<ActorAndMovie, MovieViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
                
        }
    }
}