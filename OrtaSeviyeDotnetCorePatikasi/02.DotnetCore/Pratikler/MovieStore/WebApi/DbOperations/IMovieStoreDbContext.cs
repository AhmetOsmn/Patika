using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;

namespace WebApi.DbOperations
{
    public interface IMovieStoreDbContext
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Actor> Actors { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Director> Directors { get; set; }
        public DbSet<ActorAndMovie> ActorAndMovies { get; set; }
        public DbSet<DirectorAndMovie> DirectorAndMovies { get; set; }
        public DbSet<CustomerAndGenre> CustomerAndGenres { get; set; }
        public DbSet<CustomerAndMovie> CustomerAndMovies { get; set; }

        int SaveChanges();
    }
}