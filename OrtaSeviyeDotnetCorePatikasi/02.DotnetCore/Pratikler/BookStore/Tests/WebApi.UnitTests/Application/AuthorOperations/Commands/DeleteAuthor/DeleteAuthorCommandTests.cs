using System;
using System.Linq;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperations.DeleteAuthor;
using WebApi.DBOperations;
using Xunit;

namespace Application.AuthorOptions.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;

        public DeleteAuthorCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }

        [Fact]
        public void WhenInvalidAuthorIdIsGiven_InvalidOperationException_ShouldBeReturnErrors()
        {
            //arrange
            int authorId = 10;
            DeleteAuthorCommand command = new DeleteAuthorCommand(_context);
            command.AuthorId = authorId;

            //act && assert
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("Silinecek yazar bulunamadı.");
        }

        [Theory]
        [InlineData(1)]
        public void WhenAuthorHasABook_InvalidOperationException_ShouldBeReturnErrors(int authorId)
        {
            //arrange
            DeleteAuthorCommand command = new DeleteAuthorCommand(_context);
            command.AuthorId = authorId;

            //act && assert
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("Kitabı yayında olan yazar silinemez.");
        }


        [Theory]
        [InlineData(4)]
        public void WhenValidAuthorIdIsGiven_Author_ShouldBeDeleted(int authorId)
        {
            //arrange
            DeleteAuthorCommand command = new DeleteAuthorCommand(_context);
            command.AuthorId = authorId;

            FluentActions.Invoking(() => command.Handle()).Invoke();

            var author = _context.Authors.SingleOrDefault(author => author.Id == authorId);
            author.Should().Be(null);
        }

    }
}