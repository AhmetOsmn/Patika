using System;
using FluentValidation;

namespace WebApi.Application.MovieOperations.Commands.UpdateMovie
{
    public class UpdateMovieCommandValidator : AbstractValidator<UpdateMovieCommand>
    {
        public UpdateMovieCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(2); 
            RuleFor(command => command.Model.DirectorId).GreaterThan(0); 
            RuleFor(command => command.Model.GenreId).GreaterThan(0); 
            RuleFor(command => command.Model.Price).GreaterThanOrEqualTo(0); 
            RuleFor(command => command.Model.Year).GreaterThan(1800).LessThanOrEqualTo(DateTime.Now.Year); 
            
        }
    }
}