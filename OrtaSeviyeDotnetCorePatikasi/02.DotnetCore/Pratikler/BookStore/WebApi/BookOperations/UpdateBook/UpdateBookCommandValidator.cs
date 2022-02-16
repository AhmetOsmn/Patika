using FluentValidation;

namespace WebApi.BookOperations.UdpateBook
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Title).MinimumLength(3);
        }
    }
}