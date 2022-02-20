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
                        ActorsIds = new List<Cast>() {
                            new Cast
                            {
                                ActorId = 1
                            },
                            new Cast
                            {
                                ActorId = 2
                            },
                            new Cast
                            {
                                ActorId = 3
                            }
                        },
                        Price = "$58 Million"
                    },
                    new Movie
                    {
                        Name = "Fight Club",
                        Year = new DateTime(1999, 2, 11),
                        GenreId = 1, //drama
                        DirectorId = 2, // David Fincher
                        ActorsIds = new List<Cast>() {
                            new Cast
                            {
                                ActorId = 4
                            },
                            new Cast
                            {
                                ActorId = 5
                            },
                            new Cast
                            {
                                ActorId = 6
                            }
                         },
                        Price = "$100 Million"
                    },
                    new Movie
                    {
                        Name = "The Green Mile",
                        Year = new DateTime(1999, 3, 11),
                        GenreId = 1, //drama
                        DirectorId = 1, // Frank Darabont
                        ActorsIds = new List<Cast>() {
                            new Cast
                            {
                                ActorId = 7
                            },
                            new Cast
                            {
                                ActorId = 8
                            },
                            new Cast
                            {
                                ActorId = 9
                            }
                         },
                        Price = "$80 Million"
                    },
                    new Movie
                    {
                        Name = "Interstellar",
                        Year = new DateTime(2014, 4, 11),
                        GenreId = 2, //science fiction
                        DirectorId = 3, // Christopher Nolan
                        ActorsIds = new List<Cast>() {
                            new Cast
                            {
                                ActorId = 10
                            },
                            new Cast
                            {
                                ActorId = 11
                            },
                            new Cast
                            {
                                ActorId = 12
                            }
                         },
                        Price = "$165 Million"
                    },
                    new Movie
                    {
                        Name = "The Prestige",
                        Year = new DateTime(1994, 5, 11),
                        GenreId = 3, //mystery
                        DirectorId = 3, // Christopher Nolan
                        ActorsIds = new List<Cast>() {
                            new Cast
                            {
                                ActorId = 13
                            },
                            new Cast
                            {
                                ActorId = 14
                            },
                            new Cast
                            {
                                ActorId = 13
                            },
                         },
                        Price = "$109 Million"
                    }
                );

                context.Actors.AddRange(
                    new Actor
                    {
                        Name = "Morgan", // esaretin bedeli
                        Surname = "Freeman",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 1
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Tim", // esaretin bedeli
                        Surname = "Robbins",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 1
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Bob", // esaretin bedeli
                        Surname = "Gunton",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 1
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Brad", // fight club
                        Surname = "Pitt",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 2
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Edward", // fight club
                        Surname = "Norton",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 2
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Helena Bonham", // fight club
                        Surname = "Carter",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 2
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Tom", // yesil yol
                        Surname = "Hanks",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 3
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Michael Clarke", // yesil yol
                        Surname = "Duncan",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 3
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "David", // yesil yol
                        Surname = "Morse",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 3
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Matthew", // yıldızlar arası
                        Surname = "McConaughey",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 4
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Anne", // yıldızlar arası
                        Surname = "Hathaway",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 4
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Jessica", // yıldızlar arası
                        Surname = "Chastain",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 4
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Christian", // prestij
                        Surname = "Bale",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 5
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Hugh", // prestij
                        Surname = "Jackman",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 5
                            }
                        }
                    },
                    new Actor
                    {
                        Name = "Michael", // prestij
                        Surname = "Caine",
                        StarringMoviesIds = new List<StarringMovie>(){
                            new StarringMovie
                            {
                                MovieId = 5
                            }
                        }
                    }
                );

                context.Directors.AddRange(
                    new Director
                    {
                        Name = "Frank",
                        Surname = "Darabont",
                        DirectedMoviesIds = new List<DirectedMovie>() {
                            new DirectedMovie
                            {
                                MovieId = 1
                            },
                            new DirectedMovie
                            {
                                MovieId = 3
                            }
                         },
                        StarringMoviesIds = new List<StarringMovie>() { }
                    },
                    new Director
                    {
                        Name = "David",
                        Surname = "Fincher",
                        DirectedMoviesIds = new List<DirectedMovie>() {
                            new DirectedMovie
                            {
                                MovieId = 2
                            }
                        },
                        StarringMoviesIds = new List<StarringMovie>() { }
                    },
                    new Director
                    {
                        Name = "Christopher",
                        Surname = "Nolan",
                        DirectedMoviesIds = new List<DirectedMovie>() {
                            new DirectedMovie
                            {
                                MovieId = 4
                            },
                            new DirectedMovie
                            {
                                MovieId = 5
                            }
                        },
                        StarringMoviesIds = new List<StarringMovie>() { }
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
                        FavoriteGenresIds = new List<FavoriteGenre>(){
                            new FavoriteGenre
                            {
                                GenreId = 1
                            },
                            new FavoriteGenre
                            {
                                GenreId = 2
                            }
                        },
                        PurchasedMoviesIds = new List<PurchasedMovie>(){
                            new PurchasedMovie
                            {
                                MovieId = 1
                            },
                            new PurchasedMovie
                            {
                                MovieId = 2
                            },
                            new PurchasedMovie
                            {
                                MovieId = 3
                            }
                        }
                    },
                    new Customer
                    {
                        Name = "Osman",
                        Surname = "Sezgin",
                        FavoriteGenresIds = new List<FavoriteGenre>(){
                            new FavoriteGenre
                            {
                                GenreId = 1
                            },
                            new FavoriteGenre
                            {
                                GenreId = 2
                            },
                            new FavoriteGenre
                            {
                                GenreId = 3
                            },
                        },
                        PurchasedMoviesIds = new List<PurchasedMovie>(){
                            new PurchasedMovie
                            {
                                MovieId = 1
                            },
                            new PurchasedMovie
                            {
                                MovieId = 2
                            },
                            new PurchasedMovie
                            {
                                MovieId = 3
                            },
                            new PurchasedMovie
                            {
                                MovieId = 4
                            },
                            new PurchasedMovie
                            {
                                MovieId = 5
                            }
                        }
                    },
                    new Customer
                    {
                        Name = "Sezgin",
                        Surname = "Sezgin",
                        FavoriteGenresIds = new List<FavoriteGenre>(){
                            new FavoriteGenre
                            {
                                GenreId = 3
                            },
                            new FavoriteGenre
                            {
                                GenreId = 2
                            },
                        },
                        PurchasedMoviesIds = new List<PurchasedMovie>(){
                            new PurchasedMovie
                            {
                                MovieId = 4
                            },
                            new PurchasedMovie
                            {
                                MovieId = 5
                            }
                        }
                    }
                );

                context.SaveChanges();
            }
        }
    }
}