using FluentValidation;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQueryValidator : AbstractValidator<GetAuthorDetail>
    {
        public GetAuthorDetailQueryValidator()
        {
            RuleFor(query => query.AuthorId).GreaterThan(0);
        }
    }
}