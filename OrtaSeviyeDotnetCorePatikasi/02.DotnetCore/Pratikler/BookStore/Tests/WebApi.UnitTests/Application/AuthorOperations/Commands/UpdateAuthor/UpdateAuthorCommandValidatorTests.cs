using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperations.UpdateAuthor;
using Xunit;

namespace Application.AuthorOptions.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {

        [Theory]
        [InlineData("ti", "asfasdg")]
        [InlineData("asr", "as")]
        [InlineData("a", "d")]

        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string name, string surname)
        {
            //arrange
            UpdateAuthorCommand command = new UpdateAuthorCommand(null);
            command.Model = new UpdateAuthorModel()
            {
                Name = name,
                Surname = surname,
            };

            //act
            UpdateAuthorCommandValidator validator = new UpdateAuthorCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData("Deneme 1", "Deneme 12")]
        [InlineData("Deneme 2", "Deneme 22")]

        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErrors(string name, string surname)
        {
            //arrange
            UpdateAuthorCommand command = new UpdateAuthorCommand(null);

            command.Model = new UpdateAuthorModel()
            {
                Name = name,
                Surname = surname,
            };

            //act
            UpdateAuthorCommandValidator validator = new UpdateAuthorCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().Be(0);
        }
    }
}