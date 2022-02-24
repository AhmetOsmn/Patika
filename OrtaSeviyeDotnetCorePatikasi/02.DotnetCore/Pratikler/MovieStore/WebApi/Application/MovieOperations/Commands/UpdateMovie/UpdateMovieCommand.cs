using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Models.Entities;
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
                movie.Name = Model.Name == default ? movie.Name : Model.Name;
                movie.DirectorId = Model.DirectorId == default ? movie.DirectorId : Model.DirectorId;
                movie.GenreId = Model.GenreId == default ? movie.GenreId : Model.GenreId;
                movie.Price = Model.Price == default ? movie.Price : Model.Price.ToString();
                movie.Year = Model.Year == default ? movie.Year : Model.Year;
            
                _context.SaveChanges();
            }
        }
    }
}