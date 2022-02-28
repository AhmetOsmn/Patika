using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Models.Entities.Route;
using WebApi.Models.ViewModels.Update;

namespace WebApi.Application.DirectorOperations.Commands.UpdateDirector
{
    public class UpdateDirectorCommand
    {
        private readonly IMovieStoreDbContext _context;
        public int DirectorId { get; set; }
        public UpdateDirectorModel Model { get; set; }

        public UpdateDirectorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var director = _context.Directors.SingleOrDefault(x => x.Id == DirectorId);
            if (director is null || director.IsActive == false)
            {
                throw new InvalidOperationException("Güncellenecek yönetmen bulunamadı.");
            }
            else if (_context.Directors.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.Surname.ToLower() == Model.Surname.ToLower() && x.Id != DirectorId && x.IsActive))
            {
                throw new InvalidOperationException("Aynı isim ve soyisimli yönetmen mevcut.");
            }
            else
            {
                director.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? director.Name : Model.Name;
                director.Surname = string.IsNullOrEmpty(Model.Surname.Trim()) ? director.Surname : Model.Surname;

                if (Model.ActedMovies.Count() != 0)
                {
                    _context.ActorAndMovies.Where(x => x.ActorId == DirectorId).ToList().ForEach(x => _context.ActorAndMovies.Remove(x));
                    foreach (var item in Model.ActedMovies)
                    {
                        director.ActedMovies.Add(
                            new ActorAndMovie
                            {
                                ActorId = director.Id,
                                MovieId = item
                            }
                        );
                    }
                }

                if (Model.DirectedMovies.Count() != 0)
                {
                    _context.DirectorAndMovies.Where(x => x.DirectorId == DirectorId).ToList().ForEach(x => _context.DirectorAndMovies.Remove(x));

                    foreach (var item in Model.DirectedMovies)
                    {
                        director.DirectedMovies.Add(
                            new DirectorAndMovie
                            {
                                DirectorId = director.Id,
                                MovieId = item
                            }
                        );
                    }
                }
                _context.SaveChanges();
            }
        }
    }
}