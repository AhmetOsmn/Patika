using Microsoft.EntityFrameworkCore;
using WebApi.Entities;
using WebApi.Entities.Route;

namespace WebApi.DbOperations
{
    public interface IMovieStoreDbContext
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Actor> Actors { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Director> Directors { get; set; }
        // public DbSet<ActorAndMovie> ActorAndMovies { get; set; }

        int SaveChanges();
    }
}