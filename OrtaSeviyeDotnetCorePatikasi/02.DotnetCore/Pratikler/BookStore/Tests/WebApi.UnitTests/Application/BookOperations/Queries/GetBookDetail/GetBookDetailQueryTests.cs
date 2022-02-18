using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.BookOperations.Queries.GetBookDetail;
using WebApi.DBOperations;
using Xunit;

namespace Application.BookOperations.Queries.GetBookDetail
{
    public class GetBookDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetBookDetailQueryTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(66)]
        [InlineData(42)]
        [InlineData(-5)]
        public void WhenInvalidBookIdIsGiven_InvalidOperationException_ShouldBeReturnError(int bookId)
        {
            GetBookDetailQuery query = new GetBookDetailQuery(_context, _mapper);
            query.BookId = bookId;

            FluentActions
                .Invoking(() => query.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("Aranan kitap bulunamadı.");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void WhenValidBookIdIsGiven_InvalidOperationException_ShouldNotBeReturnError(int bookId)
        {
            GetBookDetailQuery query = new GetBookDetailQuery(_context, _mapper);
            query.BookId = bookId;

            BookDetailViewModel vm = new BookDetailViewModel();
            FluentActions.Invoking(() => vm = query.Handle()).Invoke();

            var book = _context.Books.SingleOrDefault(x => x.Id == bookId);

            vm.Title.Should().Be(book.Title);
            vm.PageCount.Should().Be(book.PageCount);
            vm.Genre.Should().NotBeNullOrEmpty();
            vm.Author.Should().NotBeNullOrEmpty();
            vm.PublishDate.Should().NotBeNullOrEmpty();
        }
    }
}