using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;

namespace WebApi.DbOperations
{
    public class MovieStoreDbContext : DbContext, IMovieStoreDbContext
    {
        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<ActorAndMovie> ActorAndMovies { get; set; }
        public DbSet<CustomerAndGenre> CustomerAndGenres { get; set; }
        public DbSet<CustomerAndMovie> CustomerAndMovies { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
        
}