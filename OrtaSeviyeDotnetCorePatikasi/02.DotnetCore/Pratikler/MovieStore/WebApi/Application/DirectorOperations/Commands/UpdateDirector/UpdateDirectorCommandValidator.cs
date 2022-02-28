using FluentValidation;

namespace WebApi.Application.DirectorOperations.Commands.UpdateDirector
{
    public class UpdateDirectorCommandValidator : AbstractValidator<UpdateDirectorCommand>
    {
        public UpdateDirectorCommandValidator()
        {
            RuleFor(command => command.Model.Name).MinimumLength(3).When(x => x.Model.Name.Trim() != string.Empty);
            RuleFor(command => command.Model.Name).MinimumLength(3).When(x => x.Model.Name.Trim() != string.Empty);
        }
    }
}