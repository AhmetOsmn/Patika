using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;
using WebApi.Models.ViewModels.Create;

namespace WebApi.Application.DirectorOperations.Commands.CreateDirector
{
    public class CreateDirectorCommand
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateDirectorModel Model { get; set; }

        public CreateDirectorCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var director = _context.Directors.SingleOrDefault(x => x.Name.ToLower() == Model.Name.ToLower() && x.Surname.ToLower() == Model.Surname.ToLower());

            if (director is not null && director.IsActive == false)
            {
                director.IsActive = true;
                _context.SaveChanges();
            }
            else if (director is not null)
            {
                throw new InvalidOperationException("Eklenecek yönetmen zaten mevcut.");
            }
            else
            {
                director = _mapper.Map<Director>(Model);

                foreach (var item in Model.ActedMovies)
                {
                    director.ActorsAndMovies.Add(
                        new ActorAndMovie
                        {
                            ActorId = director.Id,
                            MovieId = item
                        }
                    );
                }

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

                _context.Directors.Add(director);
                _context.SaveChanges();
            }
        }
    }
}
