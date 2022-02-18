using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.BookOperations.Commands.CreateBook;
using WebApi.DBOperations;
using WebApi.Entities;
using Xunit;
using static WebApi.Application.BookOperations.Commands.CreateBook.CreateBookCommand;

namespace Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public CreateBookCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenAlreadyExistBookTitleGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange - Hazırlık
            var book = new Book()
            {
                Title = "WhenAlreadyExistBookTitleGiven_InvalidOperationException_ShouldBeReturn",
                PageCount = 100,
                PublishDate = new System.DateTime(1990, 01, 10),
                GenreId = 1,
                AuthorId = 1
            };
            _context.Books.Add(book);
            _context.SaveChanges();

            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            command.Model = new CreateBookModel(){Title = book.Title};

            //act - Çalıştırma & assert - Doğrulama
            FluentActions
                    .Invoking(() => command.Handle())
                    .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Eklenecek kitap zaten mevcut");

        }

        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldBeCreated()
        {
            //arrange
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            CreateBookModel model = new CreateBookModel()
            {
                Title = "Hobbit",
                AuthorId = 1,
                GenreId = 2,
                PageCount = 800,
                PublishDate = DateTime.Now.Date.AddYears(-20)
            };
            command.Model = model;

            //act
            FluentActions.Invoking(() => command.Handle()).Invoke();

            //assert
            var book =  _context.Books.SingleOrDefault(book => book.Title == model.Title && book.GenreId == model.GenreId);
            
            book.Should().NotBeNull();
            book.PageCount.Should().Be(model.PageCount);
            book.PublishDate.Should().Be(model.PublishDate);
            book.Title.Should().Be(model.Title);
            book.AuthorId.Should().Be(model.AuthorId);

        }
    }
}