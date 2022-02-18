using System;
using System.Linq;
using FluentAssertions;
using TestSetup;
using WebApi.Application.GenreOperations.UpdateGenre;
using WebApi.DBOperations;
using Xunit;

namespace Application.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;

        public UpdateGenreCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }

        [Fact]
        public void WhenInvalidGenreIdIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange
            int genreId = 10;

            UpdateGenreCommand command = new UpdateGenreCommand(_context);
            command.GenreId = genreId;

            FluentActions
                    .Invoking(() => command.Handle())
                    .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Güncellenecek kitap türü bulunamadı.");
        }

        [Theory]
        [InlineData(1, "Romance")]
        [InlineData(2, "Romance")]
        public void WhenAlreadyExistGenreNameIsGiven_InvalidOperationException_ShouldBeReturn(int genreId, string genreName)
        {
            //arrange
            UpdateGenreCommand command = new UpdateGenreCommand(_context);
            command.GenreId = genreId;

            command.Model = new UpdateGenreModel()
            {
                Name = genreName,
                IsActive = true
            };

            FluentActions
                    .Invoking(() => command.Handle())
                    .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Aynı isimli kitap türü mevcut.");
        }

        [Fact]
        public void WhenValidGenreIdIsGiven_Genre_ShouldBeUpdated()
        {
            //arrange
            int genreId = 2;
            UpdateGenreModel model = new UpdateGenreModel()
            {
                Name = "Tiyatro",
                IsActive = true
            };

            UpdateGenreCommand command = new UpdateGenreCommand(_context);
            command.GenreId = genreId;
            command.Model = model;

            //act
            FluentActions.Invoking(() => command.Handle()).Invoke();

            //assert
            var genre = _context.Genres.SingleOrDefault(x => x.Id == genreId);

            genre.Name.Should().Be(model.Name);
            genre.IsActive.Should().Be(model.IsActive);


        }
    }
}