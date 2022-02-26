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


        }
    }
}