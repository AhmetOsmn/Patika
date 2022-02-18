using System;
using FluentAssertions;
using TestSetup;
using WebApi.Application.BookOperations.Commands.CreateBook;
using Xunit;
using static WebApi.Application.BookOperations.Commands.CreateBook.CreateBookCommand;

namespace Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {

        [Theory]
        [InlineData("Lord Of the Rings", 0, 0, 0)]
        [InlineData("Lord Of the Rings", 0, 1, 0)]
        [InlineData("Lord Of the Rings", 0, 0, 1)]
        [InlineData("Lord Of the Rings", 0, 1, 1)]
        // [InlineData("Lord Of the Rings",1,1,1)] 
        // Doğru data girildiği için validator içerisinde 0 hata çıkıyor. 
        //Test'te validatorden çıkan hata sayısının 0dan büyük olmasını beklediğimiz için test başarız olmuş oluyor.
        [InlineData("", 0, 0, 0)]
        [InlineData("", 1, 0, 0)]
        [InlineData("", 0, 1, 0)]
        [InlineData("", 0, 0, 1)]
        [InlineData("", 1, 1, 1)]
        [InlineData("lo", 1, 1, 1)]
        [InlineData("lo", 0, 1, 0)]
        [InlineData("lo", 0, 0, 1)]
        [InlineData("lo", 0, 0, 0)]
        [InlineData("lor", 1, 1, 1)]
        [InlineData("lor", 0, 1, 0)]
        [InlineData("lor", 0, 0, 1)]
        [InlineData("lor", 0, 0, 0)]
        // [InlineData("lord",1,1,1)]
        // Doğru data girildiği için validator içerisinden 0 hata çıkıyor. 
        //Test'te validatorden çıkan hata sayısının 0dan büyük olmasını beklediğimiz için test başarız olmuş oluyor.
        [InlineData("lord", 0, 1, 0)]
        [InlineData("lord", 0, 0, 1)]
        [InlineData("lord", 0, 0, 0)]
        [InlineData(" ", 111, 111, 111)]

        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string title, int pageCount, int genreId, int authorId)
        {
            //arrange
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = title,
                PageCount = pageCount,
                PublishDate = DateTime.Now.Date.AddYears(-10),
                GenreId = genreId,
                AuthorId = authorId
            };

            // act
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnError() // Sadece datetime test edilecek, diğer durumlar valid verilmelidir.
        {
            //arrange
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = "Lord Of The Rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date,
                GenreId = 2,
                AuthorId = 2
            };

            // act
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);

        }

        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnError()  // Happy Path
        {
            //arrange
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = "Lord Of The Rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date.AddYears(-10),
                GenreId = 2,
                AuthorId = 2
            };

            // act
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().Be(0);

        }
    }
}