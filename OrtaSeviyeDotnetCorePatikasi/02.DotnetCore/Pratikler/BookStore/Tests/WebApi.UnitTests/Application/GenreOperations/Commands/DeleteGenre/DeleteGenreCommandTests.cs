using System;
using System.Linq;
using FluentAssertions;
using TestSetup;
using WebApi.Application.GenreOperations.DeleteGenre;
using WebApi.DBOperations;
using Xunit;

namespace Application.GenreOperations.Commands.DeleteGenre
{
    public class DeleteGenreCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;

        public DeleteGenreCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }

        [Fact]
        public void WhenInvalidGenreIdIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange
            int genreId = 10;
            DeleteGenreCommand command = new DeleteGenreCommand(_context);
            command.GenreId = genreId;

            //act && assert
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("Silinecek kitap türü bulunamadı.");

        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void WhenValidBookIdIsGiven_Book_ShouldBeDeleted(int genreId)
        {
            //arrange
            DeleteGenreCommand command = new DeleteGenreCommand(_context);
            command.GenreId = genreId;

            FluentActions.Invoking(() => command.Handle()).Invoke();

            var genre = _context.Genres.SingleOrDefault(genre => genre.Id == genreId);
            genre.Should().Be(null);
        }

    }
}