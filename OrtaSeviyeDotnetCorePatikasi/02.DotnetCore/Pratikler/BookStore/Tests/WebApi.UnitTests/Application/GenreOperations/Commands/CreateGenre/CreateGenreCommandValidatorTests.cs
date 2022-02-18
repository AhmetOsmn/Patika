using FluentAssertions;
using TestSetup;
using WebApi.Application.GenreOperations.CreateGenre;
using Xunit;

namespace Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommandValidatorTests : IClassFixture<CommonTestFixture>
    {

        [Theory]
        [InlineData("de")]
        [InlineData(" ")]

        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string name)
        {
            //arrange
            CreateGenreCommand command = new CreateGenreCommand(null);
            command.Model = new CreateGenreModel()
            {
                Name = name
            };

            // act
            CreateGenreCommandValidator validator = new CreateGenreCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnError()  // Happy Path
        {
            //arrange
            CreateGenreCommand command = new CreateGenreCommand(null);
            command.Model = new CreateGenreModel()
            {
                Name = "Tiyatro"
            };

            // act
            CreateGenreCommandValidator validator = new CreateGenreCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().Be(0);

        }
    }
}