using AutoMapper;
using WebApi.Entities;
using WebApi.Entities.Route;
using WebApi.Entities.ViewModels;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // GENRE
            CreateMap<Genre, GenreViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();

            //MOVIE
            CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.ActorsAndMovies))
                .AfterMap((model, entity) =>
                {
                    foreach (var entityActorAndMovie in model.ActorsAndMovies)
                    {
                        entityActorAndMovie.Movie = model;
                    }
                });

            CreateMap<ActorAndMovie, MovieViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));


            //ACTOR
            CreateMap<Actor, ActorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Name + " " + src.Surname)));

            CreateMap<Actor, ActorViewModel >()
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.ActorsAndMovies))
                    .AfterMap((model, entity) =>
                    {
                        foreach (var entityActorAndMovie in model.ActorsAndMovies)
                        {
                            entityActorAndMovie.Actor = model;
                        }
                    });
                

            CreateMap<ActorAndMovie, MovieViewModelForActor>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<Movie, MovieViewModelForActor>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            //DIRECTOR    
            CreateMap<Director, DirectorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Name + " " + src.Surname)));

        }
    }
}