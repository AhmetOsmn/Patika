using FluentAssertions;
using TestSetup;
using WebApi.Application.BookOperations.Queries.GetBookDetail;
using Xunit;

namespace Application.BookOperations.Queries.GetBookDetail
{
    public class GetBookDetailQueryValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-50)]

        public void WhenInvalidBookIdIsGiven_Validator_ShouldBeReturnErrors(int id)
        {
            //arrange
            GetBookDetailQuery query = new GetBookDetailQuery(null, null);
            query.BookId = id;

            //act
            GetBookDetailQueryValidator validator = new GetBookDetailQueryValidator();
            var result = validator.Validate(query);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]

        public void WhenValidBookIdIsGiven_Validator_ShouldNotBeReturnErrors(int id)
        {
            //arrange
            GetBookDetailQuery query = new GetBookDetailQuery(null, null);
            query.BookId = id;

            //act
            GetBookDetailQueryValidator validator = new GetBookDetailQueryValidator();
            var result = validator.Validate(query);

            //assert
            result.Errors.Count.Should().Be(0);
        }
    }
}