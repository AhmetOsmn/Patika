using System;
using System.Linq;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperations.UpdateAuthor;
using WebApi.DBOperations;
using Xunit;

namespace Application.AuthorOptions.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;

        public UpdateAuthorCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }

        [Fact]
        public void WhenInvalidAuthorIdIsGiven_InvalidOperationException_ShouldBeReturnErrors()
        {
            //arrange
            int authorId = 10;

            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.AuthorId = authorId;

            FluentActions
                    .Invoking(() => command.Handle())
                    .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Güncellenecek yazar bulunamadı");
        }

        [Fact]
        public void WhenValidAuthorIdIsGiven_Author_ShouldBeUpdated()
        {
            //arrange
            int authorId = 2;
            UpdateAuthorModel model = new UpdateAuthorModel()
            {
                Name = "deneme 3",
                Surname = "deneme 3"
            };

            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.AuthorId = authorId;
            command.Model = model;

            //act
            FluentActions.Invoking(() => command.Handle()).Invoke();

            //assert
            var author = _context.Authors.SingleOrDefault(x => x.Id == authorId);

            author.Name.Should().Be(model.Name);
            author.Surname.Should().Be(model.Surname);
        }
    }
}