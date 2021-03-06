using FluentValidation;
using WebApi.Application.AuthorOperations.CreateAuthor;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();
            RuleFor(command => command.Model.Name).MinimumLength(3);
            RuleFor(command => command.Model.Surname).NotEmpty();
            RuleFor(command => command.Model.Surname).MinimumLength(3);
            RuleFor(command => command.Model.BirthDay.Date).NotEmpty().LessThan(System.DateTime.Now.Date.AddYears(-15));
        }
    }
}