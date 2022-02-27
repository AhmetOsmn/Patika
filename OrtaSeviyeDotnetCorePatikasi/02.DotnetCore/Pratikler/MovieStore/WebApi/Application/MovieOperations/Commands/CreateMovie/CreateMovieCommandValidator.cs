using System;
using FluentValidation;

namespace WebApi.Application.MovieOperations.Commands.CreateMovie
{
    public class CreateMovieCommandValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(2); 
            RuleFor(command => command.Model.GenreId).GreaterThan(0); 
            RuleFor(command => command.Model.Price).GreaterThanOrEqualTo(0); 
            RuleFor(command => command.Model.Year).GreaterThan(1800).LessThanOrEqualTo(DateTime.Now.Year); 
        }
    }
}