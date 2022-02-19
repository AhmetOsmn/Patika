
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace WebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        Name = "The Shawshank Redemption",
                        Year = new DateTime(1994, 1, 11),
                        GenreId = 1, //Drama
                        DirectorId = 1, // Frank Darabont
                        ActorsIds = new List<int>() { },
                        Price = "$58 Million"
                    },
                    new Movie
                    {
                        Name = "Fight Club",
                        Year = new DateTime(1999, 2, 11),
                        GenreId = 1, //drama
                        DirectorId = 2, // David Fincher
                        ActorsIds = new List<int>() { },
                        Price = "$100 Million"
                    },
                    new Movie
                    {
                        Name = "The Green Mile",
                        Year = new DateTime(1999, 3, 11),
                        GenreId = 1, //drama
                        DirectorId = 1, // Frank Darabont
                        ActorsIds = new List<int>() { },
                        Price = "$80 Million"
                    },
                    new Movie
                    {
                        Name = "Interstellar",
                        Year = new DateTime(2014, 4, 11),
                        GenreId = 2, //science fiction
                        DirectorId = 3, // Christopher Nolan
                        ActorsIds = new List<int>() { },
                        Price = "$165 Million"
                    },
                    new Movie
                    {
                        Name = "The Prestige",
                        Year = new DateTime(1994, 5, 11),
                        GenreId = 3, //mystery
                        DirectorId = 3, // Christopher Nolan
                        ActorsIds = new List<int>() { },
                        Price = "$109 Million"
                    }
                );

                context.Actors.AddRange(
                    new Actor
                    {
                        Name = "Morgan", // esaretin bedeli
                        Surname = "Freeman",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Tim", // esaretin bedeli
                        Surname = "Robbins",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Bob", // esaretin bedeli
                        Surname = "Gunton",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Brad", // fight club
                        Surname = "Pitt",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Edward", // fight club
                        Surname = "Norton",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Helena Bonham", // fight club
                        Surname = "Carter",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Tom", // yesil yol
                        Surname = "Hanks",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Michael Clarke", // yesil yol
                        Surname = "Duncan",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "David", // yesil yol
                        Surname = "Morse",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Matthew", // yıldızlar arası
                        Surname = "McConaughey",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Anne", // yıldızlar arası
                        Surname = "Hathaway",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Jessica", // yıldızlar arası
                        Surname = "Chastain",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Christian", // prestij
                        Surname = "Bale",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Hugh", // prestij
                        Surname = "Jackman",
                        StarringMoviesIds = new List<int>() { }
                    },
                    new Actor
                    {
                        Name = "Michael", // prestij
                        Surname = "Caine",
                        StarringMoviesIds = new List<int>() { }
                    }
                );

                context.Directors.AddRange(
                    new Director
                    {
                        Name = "Frank",
                        Surname = "Darabont",
                        DirectedMoviesIds = new List<int>() { 1, 3 },
                        StarringMoviesIds = new List<int>(){}
                    },
                    new Director
                    {
                        Name = "David",
                        Surname = "Fincher",
                        DirectedMoviesIds = new List<int>() { 2 },
                        StarringMoviesIds = new List<int>(){}
                    },
                    new Director
                    {
                        Name = "Christopher",
                        Surname = "Nolan",
                        DirectedMoviesIds = new List<int>() { 4, 5 },
                        StarringMoviesIds = new List<int>(){}
                    }
                );

                context.Genres.AddRange(
                    new Genre
                    {
                        Name = "Drama",
                        IsActive = true
                    },
                    new Genre
                    {
                        Name = "Science Fiction",
                        IsActive = true
                    },
                    new Genre
                    {
                        Name = "Mystery",
                        IsActive = true
                    }
                );

                context.Customers.AddRange(
                    new Customer
                    {
                        Name = "Ahmet",
                        Surname = "Sezgin",
                        FavoriteGenresIds = new List<int>(){1,3},
                        PurchasedMoviesIds = new List<int>(){1,2,3}
                    },
                    new Customer
                    {
                        Name = "Osman",
                        Surname = "Sezgin",
                        FavoriteGenresIds = new List<int>(){1,2,3},
                        PurchasedMoviesIds = new List<int>(){1,2,3,4,5}
                    },
                    new Customer
                    {
                        Name = "Sezgin",
                        Surname = "Sezgin",
                        FavoriteGenresIds = new List<int>(){3,2},
                        PurchasedMoviesIds = new List<int>(){4,5}
                    }
                );

                context.SaveChanges();
            }
        }
    }
}