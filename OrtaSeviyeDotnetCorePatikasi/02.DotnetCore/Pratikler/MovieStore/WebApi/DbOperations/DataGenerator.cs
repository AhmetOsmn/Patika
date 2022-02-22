using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;
using WebApi.Entities.Route;

namespace WebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {
                if (context.Genres.Any())
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
                        Price = "$58 Million"
                    },
                    new Movie
                    {
                        Name = "Fight Club",
                        Year = new DateTime(1999, 2, 11),
                        GenreId = 1, //drama
                        DirectorId = 2, // David Fincher
                        Price = "$100 Million"
                    },
                    new Movie
                    {
                        Name = "The Green Mile",
                        Year = new DateTime(1999, 3, 11),
                        GenreId = 1, //drama
                        DirectorId = 1, // Frank Darabont
                        Price = "$80 Million"
                    },
                    new Movie
                    {
                        Name = "Interstellar",
                        Year = new DateTime(2014, 4, 11),
                        GenreId = 2, //science fiction
                        DirectorId = 3, // Christopher Nolan
                        Price = "$165 Million"
                    },
                    new Movie
                    {
                        Name = "The Prestige",
                        Year = new DateTime(1994, 5, 11),
                        GenreId = 3, //mystery
                        DirectorId = 3, // Christopher Nolan
                        Price = "$109 Million"
                    }
                );

                context.Actors.AddRange(
                    new Actor
                    {
                        Name = "Morgan", // esaretin bedeli
                        Surname = "Freeman",
                        
                    },
                    new Actor
                    {
                        Name = "Tim", // esaretin bedeli
                        Surname = "Robbins",
                        
                    },
                    new Actor
                    {
                        Name = "Bob", // esaretin bedeli
                        Surname = "Gunton",
                        
                    },
                    new Actor
                    {
                        Name = "Brad", // fight club
                        Surname = "Pitt",
                        
                    },
                    new Actor
                    {
                        Name = "Edward", // fight club
                        Surname = "Norton",
                        
                    },
                    new Actor
                    {
                        Name = "Helena Bonham", // fight club
                        Surname = "Carter",
                        
                    },
                    new Actor
                    {
                        Name = "Tom", // yesil yol
                        Surname = "Hanks",
                        
                    },
                    new Actor
                    {
                        Name = "Michael Clarke", // yesil yol
                        Surname = "Duncan",
                        
                    },
                    new Actor
                    {
                        Name = "David", // yesil yol
                        Surname = "Morse",
                        
                    },
                    new Actor
                    {
                        Name = "Matthew", // yıldızlar arası
                        Surname = "McConaughey",
                        
                    },
                    new Actor
                    {
                        Name = "Anne", // yıldızlar arası
                        Surname = "Hathaway",
                        
                    },
                    new Actor
                    {
                        Name = "Jessica", // yıldızlar arası
                        Surname = "Chastain",
                        
                    },
                    new Actor
                    {
                        Name = "Christian", // prestij
                        Surname = "Bale",
                        
                    },
                    new Actor
                    {
                        Name = "Hugh", // prestij
                        Surname = "Jackman",
                        
                    },
                    new Actor
                    {
                        Name = "Michael", // prestij
                        Surname = "Caine",
                        
                    }
                );

                context.ActorAndMovies.AddRange(
                    new ActorAndMovie
                    {
                        MovieId = 1,
                        ActorId = 1
                    },
                    new ActorAndMovie
                    {
                        MovieId = 1,
                        ActorId = 2
                    },
                    new ActorAndMovie
                    {
                        MovieId = 1,
                        ActorId = 3
                    },
                    new ActorAndMovie
                    {
                        MovieId = 2,
                        ActorId = 4
                    },
                    new ActorAndMovie
                    {
                        MovieId = 2,
                        ActorId = 5
                    },
                    new ActorAndMovie
                    {
                        MovieId = 3,
                        ActorId = 6
                    },
                    new ActorAndMovie
                    {
                        MovieId = 3,
                        ActorId = 7
                    },
                    new ActorAndMovie
                    {
                        MovieId = 3,
                        ActorId = 8
                    },
                    new ActorAndMovie
                    {
                        MovieId = 3,
                        ActorId = 9
                    },
                    new ActorAndMovie
                    {
                        MovieId = 4,
                        ActorId = 10
                    },
                    new ActorAndMovie
                    {
                        MovieId = 4,
                        ActorId = 11
                    },
                    new ActorAndMovie
                    {
                        MovieId = 4,
                        ActorId = 12
                    },
                    new ActorAndMovie
                    {
                        MovieId = 5,
                        ActorId = 13
                    },
                    new ActorAndMovie
                    {
                        MovieId = 5,
                        ActorId = 14
                    },
                    new ActorAndMovie
                    {
                        MovieId = 5,
                        ActorId = 15
                    }
                   
                );

                context.Directors.AddRange(
                    new Director
                    {
                        Name = "Frank",
                        Surname = "Darabont",
                    },
                    new Director
                    {
                        Name = "David",
                        Surname = "Fincher",
                    },
                    new Director
                    {
                        Name = "Christopher",
                        Surname = "Nolan",
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
                    },
                    new Customer
                    {
                        Name = "Osman",
                        Surname = "Sezgin",
                    },
                    new Customer
                    {
                        Name = "Sezgin",
                        Surname = "Sezgin",
                    }
                );

                context.SaveChanges();
            }
        }
    }
}