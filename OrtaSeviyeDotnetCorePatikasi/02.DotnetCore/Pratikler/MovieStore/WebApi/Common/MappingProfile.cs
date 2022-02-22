using AutoMapper;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.Entities.ViewModels;
using WebApi.Models.Entities.ViewModels.Detail;
using WebApi.Models.Entities.ViewModels.For;

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

            CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.ActorsAndMovies));


            CreateMap<Movie, MovieViewModelForActor>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            //ACTOR
            CreateMap<Actor, ActorViewModel>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => (src.Name + " " + src.Surname)))
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.ActorsAndMovies))
                .AfterMap((model, entity) =>
                {
                    foreach (var entityActorAndMovie in model.ActorsAndMovies)
                    {
                        entityActorAndMovie.Actor = model;
                    }
                });

            //DIRECTOR    
            CreateMap<Director, DirectorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Name + " " + src.Surname)));


            //ACTORANDMOVIE
            CreateMap<ActorAndMovie, MovieViewModel>()
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<ActorAndMovie, ActorViewModel>()
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Actor.Name));

            CreateMap<ActorAndMovie, MovieViewModelForActor>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<ActorAndMovie, ActorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Actor.Name + " " + src.Actor.Surname)));
        }
    }
}