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
                        ActorsAndMovies = {
                            // new ActorAndMovie
                            // {
                            //     ActorId = 1
                            // },
                            new ActorAndMovie
                            {
                                ActorId = 2
                            },
                            new ActorAndMovie
                            {
                                ActorId = 3
                            },
                        },
                        Price = "$58 Million"
                    },
                    new Movie
                    {
                        Name = "Fight Club",
                        Year = new DateTime(1999, 2, 11),
                        GenreId = 1, //drama
                        DirectorId = 2, // David Fincher
                        ActorsAndMovies = {
                            new ActorAndMovie
                            {
                                ActorId = 4
                            },
                            new ActorAndMovie
                            {
                                ActorId = 5
                            },
                            new ActorAndMovie
                            {
                                ActorId = 6
                            },
                        },
                        Price = "$100 Million"
                    },
                    new Movie
                    {
                        Name = "The Green Mile",
                        Year = new DateTime(1999, 3, 11),
                        GenreId = 1, //drama
                        DirectorId = 1, // Frank Darabont
                        ActorsAndMovies = {
                            new ActorAndMovie
                            {
                                ActorId = 7
                            },
                            new ActorAndMovie
                            {
                                ActorId = 8
                            },
                            new ActorAndMovie
                            {
                                ActorId = 9
                            },
                        },
                        Price = "$80 Million"
                    },
                    new Movie
                    {
                        Name = "Interstellar",
                        Year = new DateTime(2014, 4, 11),
                        GenreId = 2, //science fiction
                        DirectorId = 3, // Christopher Nolan
                        ActorsAndMovies = {
                            new ActorAndMovie
                            {
                                ActorId = 10
                            },
                            new ActorAndMovie
                            {
                                ActorId = 11
                            },
                            new ActorAndMovie
                            {
                                ActorId = 12
                            },
                        },
                        Price = "$165 Million"
                    },
                    new Movie
                    {
                        Name = "The Prestige",
                        Year = new DateTime(1994, 5, 11),
                        GenreId = 3, //mystery
                        DirectorId = 3, // Christopher Nolan
                        ActorsAndMovies = {
                            new ActorAndMovie
                            {
                                ActorId = 13
                            },
                            new ActorAndMovie
                            {
                                ActorId = 14
                            },
                            new ActorAndMovie
                            {
                                ActorId = 15
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
                        ActorsAndMovies = {
                            new ActorAndMovie
                            {
                                MovieId = 1
                            },
                        }
                    }
                //     new Actor
                //     {
                //         Name = "Tim", // esaretin bedeli
                //         Surname = "Robbins",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 1
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Bob", // esaretin bedeli
                //         Surname = "Gunton",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 1
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Brad", // fight club
                //         Surname = "Pitt",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 2
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Edward", // fight club
                //         Surname = "Norton",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 2
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Helena Bonham", // fight club
                //         Surname = "Carter",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 2
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Tom", // yesil yol
                //         Surname = "Hanks",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 3
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Michael Clarke", // yesil yol
                //         Surname = "Duncan",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 3
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "David", // yesil yol
                //         Surname = "Morse",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 3
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Matthew", // yıldızlar arası
                //         Surname = "McConaughey",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 4
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Anne", // yıldızlar arası
                //         Surname = "Hathaway",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 4
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Jessica", // yıldızlar arası
                //         Surname = "Chastain",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 4
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Christian", // prestij
                //         Surname = "Bale",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 5
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Hugh", // prestij
                //         Surname = "Jackman",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 5
                //             },
                //         }
                //     },
                //     new Actor
                //     {
                //         Name = "Michael", // prestij
                //         Surname = "Caine",
                //         ActorsAndMovies = {
                //             new ActorAndMovie
                //             {
                //                 MovieId = 5
                //             },
                //         }
                //     }
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