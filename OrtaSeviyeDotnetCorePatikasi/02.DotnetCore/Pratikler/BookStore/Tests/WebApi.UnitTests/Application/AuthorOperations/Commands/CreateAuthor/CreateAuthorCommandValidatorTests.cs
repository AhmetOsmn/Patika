using System;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.Application.AuthorOperations.CreateAuthor;
using Xunit;

namespace Application.AuthorOptions.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {

        [Theory]
        [InlineData("na", "aasg")]
        [InlineData("asgdf", "dg")]
        [InlineData("asgdf", "")]
        [InlineData("", "asfsdg")]

        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string name, string surname)
        {
            //arrange
            CreateAuthorCommand command = new CreateAuthorCommand(null, null);
            command.Model = new CreateAuthorModel()
            {
                Name = name,
                Surname = surname,
                BirthDay = DateTime.Now.AddYears(-20)
            };

            // act
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnError() // Sadece datetime test edilecek, diğer durumlar valid verilmelidir.
        {
            //arrange
            CreateAuthorCommand command = new CreateAuthorCommand(null, null);
            command.Model = new CreateAuthorModel()
            {
                Name = "Deneme 1",
                Surname = "Deneme 1",
                BirthDay = DateTime.Now.Date,
            };

            // act
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnError()  // Happy Path
        {
            //arrange
            CreateAuthorCommand command = new CreateAuthorCommand(null, null);
            command.Model = new CreateAuthorModel()
            {
                Name = "ahmet osman",
                Surname = "sezgin",
                BirthDay = DateTime.Now.AddYears(-20)
            };

            // act
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            var result = validator.Validate(command);

            //assert
            result.Errors.Count.Should().Be(0);

        }
    }
}