using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Authors
    {
        public static void AddAuthors(this BookStoreDbContext context)
        {
            context.Authors.AddRange(
                    new Author { Name = "Ahmet", Surname = "Sezgin", BirthDay = new DateTime(2000,3,21) },
                    new Author { Name = "Osman", Surname = "Sezgin", BirthDay = new DateTime(2000,4,25) },
                    new Author { Name = "Sezgin", Surname = "Sezgin", BirthDay = new DateTime(2000,6,11) },
                    new Author { Name = "Deneme", Surname = "Sezgin", BirthDay = new DateTime(2000,8,21) }
            );
        }
    }
}