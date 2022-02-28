using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.ViewModels.Update;

namespace WebApi.Application.MovieOperations.Commands.UpdateMovie
{
    public class UpdateMovieCommand
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int MovieId;
        public UpdateMovieModel Model;

        public UpdateMovieCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var movie = _context.Movies.SingleOrDefault(x => x.IsActive && x.Id == MovieId);

            if (movie is null || movie.IsActive == false)
            {
                throw new InvalidOperationException("Güncellenecek film bulunamadı.");
            }
            else if (_context.Movies.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Year == Model.Year && x.Id != MovieId && x.IsActive))
            {
                throw new InvalidOperationException("Aynı film mevcut.");
            }
            else
            {
                movie.Name = Model.Name != default ? Model.Name : movie.Name;
                movie.DirectorId = Model.DirectorId != default ? Model.DirectorId : movie.DirectorId;
                movie.GenreId = Model.GenreId != default ? Model.GenreId : movie.GenreId;
                movie.Price = Model.Price != default ? Model.Price.ToString() : movie.Price.ToString();
                movie.Year = Model.Year != default ? Model.Year : movie.Year;

                _context.ActorAndMovies.Where(x => x.MovieId == MovieId).ToList().ForEach(x => _context.ActorAndMovies.Remove(x));                

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
            
                _context.SaveChanges();
            }
        }
    }
}