using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Application.MovieOperations.Commands.CreateMovie
{
    public class CreateMovieCommand
    {
        private readonly IMovieStoreDbContext _context;
        public CreateMovieModel Model { get; set; }

        public CreateMovieCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var movie = _context.Movies.SingleOrDefault(x => x.Name.ToLower() == Model.Name.ToLower());

            if (movie is not null && movie.IsActive == false)
            {
                movie.IsActive = true;
                _context.SaveChanges();
            }
            else if (movie is not null)
            {
                throw new InvalidOperationException("Eklenecek film zaten mevcut.");
            }
            else
            {
                movie = new Movie
                {
                    Name = Model.Name,
                    Year = Model.Year,
                    GenreId = Model.GenreId,
                    Price = Model.Price.ToString()
                };

                foreach (var item in Model.Directors)
                {
                    movie.Directors.Add(
                        new DirectorAndMovie
                        {
                            DirectorId = item,
                            MovieId = movie.Id
                        }
                    );
                }

                foreach (var item in Model.Actors)
                {
                    movie.ActorsAndMovies.Add(
                        new ActorAndMovie
                        {
                            ActorId = item,
                            MovieId = movie.Id
                        }
                    );
                }

                _context.Movies.Add(movie);
                _context.SaveChanges();
            }
        }
    }
}
