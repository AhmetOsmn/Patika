using AutoMapper;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.Entities.ViewModels;
using WebApi.Models.Entities.ViewModels.Detail;
using WebApi.Models.Entities.ViewModels.For;
using WebApi.Models.ViewModels.Create;
using WebApi.Models.ViewModels.Detail;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // GetGenres
            CreateMap<Genre, GenreViewModel>();

            // GetActors
            CreateMap<Actor, ActorViewModel>()
                .ForMember(
                    dest => dest.FullName, opt => opt.MapFrom(src => (src.Name + " " + src.Surname)))
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.ActorsAndMovies))
                .AfterMap((model, entity) =>
                {
                    foreach (var item in model.ActorsAndMovies)
                    {
                        item.Actor = model;
                    }
                });

            CreateMap<ActorAndMovie, MovieViewModelForActor>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));
            
            // GetDirectors
            CreateMap<Director, DirectorViewModel>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Name + " " + src.Surname)))
                .ForMember(dest => dest.ActedMovies, opt => opt.MapFrom(src => src.ActorsAndMovies))
                .AfterMap((model, entity) =>
                {
                    foreach (var item in model.ActorsAndMovies)
                    {
                        item.ActorId = model.Id;
                    }
                })
                .ForMember(dest => dest.DirectedMovies, opt => opt.MapFrom(src => src.DirectedMovies))
                .AfterMap((model, entity) =>
                {
                    foreach (var item in model.DirectedMovies)
                    {
                        item.Director = model;
                    }
                });

            CreateMap<DirectorAndMovie, MovieViewModelForActor>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));
            
            // GetCustomers
            CreateMap<Customer, CustomerViewModel>()
                .ForMember(
                    dest => dest.FullName, opt => opt.MapFrom(src => (src.Name + " " + src.Surname)))
                .ForMember(dest => dest.PurchasedMovies, opt => opt.MapFrom(src => src.PurchasedMovies))
                .AfterMap((model, entity) =>
                {
                    foreach (var item in model.PurchasedMovies)
                    {
                        item.Customer = model;
                    }
                })
                .ForMember(dest => dest.FavoriteGenres, opt => opt.MapFrom(src => src.FavoriteGenres))
                .AfterMap((model, entity) =>
                {
                    foreach (var item in model.FavoriteGenres)
                    {
                        item.Customer = model;
                    }
                });

            CreateMap<CustomerAndMovie, MovieViewModelForCustomer>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Movie.Name));

            CreateMap<CustomerAndGenre, GenreViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Genre.Name));

            // GetMovies
            CreateMap<Movie, MovieViewModel>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.ActorsAndMovies))
                .AfterMap((model, entity) =>
                {
                    foreach (var entityActorAndMovie in model.ActorsAndMovies)
                    {
                        entityActorAndMovie.Movie = model;
                    }
                })
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Directors))
                .AfterMap((model, entity) =>
                {
                    foreach (var entityActorAndMovie in model.ActorsAndMovies)
                    {
                        entityActorAndMovie.Movie = model;
                    }
                });

            CreateMap<ActorAndMovie, ActorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Actor.Name + " " + src.Actor.Surname)));

            CreateMap<DirectorAndMovie, DirectorViewModelForMovie>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => (src.Director.Name + " " + src.Director.Surname)));

            // GetActorDetail
            CreateMap<Actor, ActorDetailViewModel>()
                .ForMember(desc => desc.Movies, opt => opt.MapFrom(src => src.ActorsAndMovies));

            // GetCustomerDetail
            CreateMap<Customer, CustomerDetailViewModel>();

            // GetGenreDetail
            CreateMap<Genre, GenreDetailViewModel>();

            // GetMovieDetail
            CreateMap<Movie, MovieDetailViewModel>()
                .ForMember(desc => desc.Actors, opt => opt.MapFrom(src => src.ActorsAndMovies))
                .ForMember(desc => desc.Director, opt => opt.MapFrom(src => src.Directors));

            // CreateGenre
            CreateMap<CreateGenreModel, Genre>();

            // CreateActor
            CreateMap<CreateActorModel, Actor>();



        }
    }
}