using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetail;
using Xunit;

namespace Application.AuthorOptions.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQueryValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-50)]

        public void WhenInvalidAuthorIdIsGiven_Validator_ShouldBeReturnErrors(int id)
        {
            //arrange
            GetAuthorDetailQuery query = new GetAuthorDetailQuery(null, null);
            query.AuthorId = id;

            //act
            GetAuthorDetailQueryValidator validator = new GetAuthorDetailQueryValidator();
            var result = validator.Validate(query);

            //assert
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]

        public void WhenValidAuthorIdIsGiven_Validator_ShouldNotBeReturnErrors(int id)
        {
            //arrange
            GetAuthorDetailQuery query = new GetAuthorDetailQuery(null, null);
            query.AuthorId = id;

            //act
            GetAuthorDetailQueryValidator validator = new GetAuthorDetailQueryValidator();
            var result = validator.Validate(query);

            //assert
            result.Errors.Count.Should().Be(0);
        }
    }
}