using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperations.CreateAuthor;
using WebApi.DBOperations;
using WebApi.Entities;
using Xunit;

namespace Application.AuthorOptions.Commands.CreateAuthor
{
    public class CreateAuthorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public CreateAuthorCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenAlreadyExistAuthorGiven_InvalidOperationException_ShouldBeReturnErrors()
        {
            //arrange - Hazırlık
            var author = new Author()
            {
                Name = "Deneme 2",
                Surname = "Deneme 2",
                BirthDay = new DateTime(2000,3,21)
            };
            _context.Authors.Add(author);
            _context.SaveChanges();

            CreateAuthorCommand command = new CreateAuthorCommand(_context, _mapper);
            command.Model = new CreateAuthorModel() { Name = author.Name, Surname = author.Surname, BirthDay = author.BirthDay };

            //act - Çalıştırma & assert - Doğrulama
            FluentActions
                    .Invoking(() => command.Handle())
                    .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Eklenecek yazar zaten mevcut.");

        }

        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldBeCreated()
        {
            //arrange
            CreateAuthorCommand command = new CreateAuthorCommand(_context, _mapper);
            CreateAuthorModel model = new CreateAuthorModel()
            {
                Name = "WhenAlreadyExistAuthorGiven_InvalidOperationException_ShouldBeReturnErrors",
                Surname = "Deneme 2",
                BirthDay = new DateTime(2000,3,21)
            };
            command.Model = model;

            //act
            FluentActions.Invoking(() => command.Handle()).Invoke();

            //assert
            var author = _context.Authors.FirstOrDefault(author => author.Name == model.Name);

            author.Should().NotBeNull();
            author.Name.Should().Be(model.Name);
            author.Surname.Should().Be(model.Surname);
        }
    }
}