using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Models.Entities;
using WebApi.Models.Entities.Route;

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
                        Year = 1994,
                        GenreId = 1, //Drama
                        DirectorId = 1, // Frank Darabont
                        Price = "$58 Million"
                    },
                    new Movie
                    {
                        Name = "Fight Club",
                        Year = 1999,
                        GenreId = 1, //drama
                        DirectorId = 2, // David Fincher
                        Price = "$100 Million"
                    },
                    new Movie
                    {
                        Name = "The Green Mile",
                        Year = 1999,
                        GenreId = 1, //drama
                        DirectorId = 1, // Frank Darabont
                        Price = "$80 Million"
                    },
                    new Movie
                    {
                        Name = "Interstellar",
                        Year = 2014,
                        GenreId = 2, //science fiction
                        DirectorId = 3, // Christopher Nolan
                        Price = "$165 Million"
                    },
                    new Movie
                    {
                        Name = "The Prestige",
                        Year = 1994,
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
                        MovieId = 2,
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
                        Email = "Ahmet@gmail.com",
                    },
                    new Customer
                    {
                        Name = "Osman",
                        Surname = "Sezgin",
                        Email = "Osman@gmail.com",
                    },
                    new Customer
                    {
                        Name = "Sezgin",
                        Surname = "Sezgin",
                        Email = "Sezgin@gmail.com",
                    }
                );

                context.CustomerAndGenres.AddRange(
                    new CustomerAndGenre
                    {
                        CustomerId = 1,
                        GenreId = 1
                    },
                    new CustomerAndGenre
                    {
                        CustomerId = 1,
                        GenreId = 2
                    },
                    new CustomerAndGenre
                    {
                        CustomerId = 1,
                        GenreId = 3
                    },
                
                    new CustomerAndGenre
                    {
                        CustomerId = 2,
                        GenreId = 1
                    },
                    new CustomerAndGenre
                    {
                        CustomerId = 2,
                        GenreId = 2
                    },
                    
                    new CustomerAndGenre
                    {
                        CustomerId = 3,
                        GenreId = 1
                    }
                );
                
                context.CustomerAndMovies.AddRange(
                    new CustomerAndMovie
                    {
                        CustomerId = 1,
                        MovieId = 1
                    },
                    new CustomerAndMovie
                    {
                        CustomerId = 1,
                        MovieId = 2
                    },
                    new CustomerAndMovie
                    {
                        CustomerId = 1,
                        MovieId = 3
                    },
                    new CustomerAndMovie
                    {
                        CustomerId = 1,
                        MovieId = 4
                    },
                    
                    new CustomerAndMovie
                    {
                        CustomerId = 2,
                        MovieId = 2
                    },
                    new CustomerAndMovie
                    {
                        CustomerId = 2,
                        MovieId = 3
                    },
                    
                    new CustomerAndMovie
                    {
                        CustomerId = 3,
                        MovieId = 4
                    },
                    new CustomerAndMovie
                    {
                        CustomerId = 3,
                        MovieId = 5
                    },
                    new CustomerAndMovie
                    {
                        CustomerId = 3,
                        MovieId = 1
                    }
                );

                context.SaveChanges();
            }
        }
    }
}