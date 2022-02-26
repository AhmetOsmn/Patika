using AutoMapper;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.Entities.ViewModels;
using WebApi.Models.Entities.ViewModels.Detail;
using WebApi.Models.Entities.ViewModels.For;
using WebApi.Models.ViewModels.Create;
using WebApi.Models.ViewModels.Detail;
using WebApi.Models.ViewModels.Update;

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

            CreateMap<Movie, MovieDetailViewModel>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.ActorsAndMovies));

            CreateMap<CreateMovieModel, Movie>();

            CreateMap<UpdateMovieModel, Movie>();

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

            CreateMap<Actor, ActorDetailViewModel>()
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.ActorsAndMovies));


            //DIRECTOR    
            CreateMap<Director, DirectorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Name + " " + src.Surname)));

            
            //CUSTOMER
            CreateMap<Customer, CustomerViewModel>()
                .ForMember(dest => dest.FavoriteGenres, opt => opt.MapFrom(src => src.FavoriteGenres)) 
                .ForMember(dest => dest.PurchasedMovies, opt => opt.MapFrom(src => src.PurchasedMovies)); 

            CreateMap<Customer, CustomerDetailViewModel>(); 
            CreateMap<CreateCustomerModel, Customer>();

            CreateMap<CustomerAndMovie, MovieViewModelForActor>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<CustomerAndGenre, GenreViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Genre.Name));

            //ACTORANDMOVIE
            CreateMap<ActorAndMovie, MovieViewModel>()
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<ActorAndMovie, MovieViewModelForActor>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<ActorAndMovie, ActorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Actor.Name + " " + src.Actor.Surname)));

            CreateMap<DirectorAndMovie, DirectorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Director.Name+ " " + src.Director.Surname)));
            
        }
    }
}