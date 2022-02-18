using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetail;
using WebApi.DBOperations;
using Xunit;

namespace Application.AuthorOptions.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetAuthorDetailQueryTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(66)]
        [InlineData(42)]
        [InlineData(-5)]
        public void WhenInvalidAuthorIdIsGiven_InvalidOperationException_ShouldBeReturnError(int authorId)
        {
            GetAuthorDetailQuery query = new GetAuthorDetailQuery(_mapper, _context);
            query.AuthorId = authorId;

            FluentActions
                .Invoking(() => query.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("Aranan yazar bulunamadı.");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void WhenValidAuthorIdIsGiven_InvalidOperationException_ShouldNotBeReturnError(int authorId)
        {
            GetAuthorDetailQuery query = new GetAuthorDetailQuery(_mapper, _context);
            query.AuthorId = authorId;

            AuthorDetailViewModel vm = new AuthorDetailViewModel();
            FluentActions.Invoking(() => vm = query.Handle()).Invoke();

            var author = _context.Authors.SingleOrDefault(x => x.Id == authorId);

            vm.Name.Should().Be(author.Name);
            vm.Surname.Should().Be(author.Surname);
            vm.BirthDay.Should().Be(author.BirthDay.Date.ToString());
        }
    }
}